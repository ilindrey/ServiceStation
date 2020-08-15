using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;

namespace ServiceStation.Presenter
{
    internal class WorkPresenter : BasePresenter<IEditingWorkView, Guid?>
    {
        private decimal _price;
        private Guid _reasonCustomerID;
        private int? _numberNomenclature;
        private Guid? _workingHourID;


        internal WorkPresenter(IEditingWorkView view, Guid reasonCustomerID) : base(view)
        {
            _reasonCustomerID = reasonCustomerID;

            View.Title = string.Concat("Добавление работы");
        }

        internal WorkPresenter(IEditingWorkView view, Guid workID, Guid reasonCustomerID) : base(view, workID)
        {
            _reasonCustomerID = reasonCustomerID;

            View.Title = string.Concat("Редактирование работы");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Work.Where(w => w.ID == (Guid)Identifier).Select(w => new
                    {
                        w.ID_workingHour,
                        w.Number_nomenclature,
                        w.Nomenclature.ShortName,
                        w.WorkingHour.Name,
                        w.WorkingHour.Price,
                        w.Amount,
                        w.NormOfTime
                    }).FirstAsync();

                    _workingHourID = result.ID_workingHour;
                    _numberNomenclature = result.Number_nomenclature;

                    _price = result.Price;
                    string priceText = GetPriceText(result.Price);

                    View.SetWorkInfo(result.ShortName, result.Amount, result.Name, priceText, result.NormOfTime);


                    CalculateSum();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        private string GetPriceText(decimal price)
        {
            return string.Concat(price, " рублей");
        }

        protected override void SubscribeEvent()
        {
            View.Loading += View_Loading;

            View.Save += async () => await SaveAsync();


            View.SelectionNomenclature += () =>
            {
                JournalsForm journal = new JournalsForm();

                JournalsPresenter<Nomenclature> presenter = new JournalsPresenter<Nomenclature>(journal, new NomenclatureJournal(journal.Grid, TypeNomernclature.Work));
                
                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    NomenclatureModel nomenclature = (NomenclatureModel)presenter.Info;
                    _numberNomenclature = nomenclature.Number;
                    View.Nomenclature = nomenclature.ShortName;
                    View.NormOfTime = nomenclature.Price;
                }
            };

            View.SelectionWorkingHour += () =>
            {
                JournalsForm journal = new JournalsForm();

                JournalsPresenter<WorkingHour> presenter = new JournalsPresenter<WorkingHour>(journal, new WorkingHourJournal(journal.Grid));
                
                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    WorkingHourModel workingHour = (WorkingHourModel)presenter.Info;

                    _workingHourID = workingHour.ID;
                    _price = workingHour.Price;
                    View.NameWorkingHour = workingHour.Name;
                    View.PriceWorkingHour = GetPriceText(workingHour.Price);
                    CalculateSum();
                }
            };

            View.CalculateSum += CalculateSum;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }

        private void CalculateSum()
        {
            int amount = View.Amount;
            decimal normOfTime = View.NormOfTime;

            View.Sum = string.Concat(amount * normOfTime * _price);
        }

        protected override async Task SaveAsync()
        {
            try
            {
                if (_numberNomenclature == null)
                    throw new ArgumentNullException("_numberNomenclature", "Вы не выбрали работу!");
                if (_workingHourID == null)
                    throw new ArgumentNullException("_workingHourID", "Вы не выбрали нормочас!");


                var amount = View.Amount;
                var normOfTime = View.NormOfTime;


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Work.Where(w => w.ID == Identifier).UpdateAsync(w => new WorkModel
                        {
                            ID_workingHour = (Guid)_workingHourID,
                            Number_nomenclature = (int)_numberNomenclature,
                            Amount = amount,
                            NormOfTime = normOfTime
                        });
                    }
                    else
                    {
                        WorkModel insertWorkInfo = new WorkModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ID_reasonCustomer = _reasonCustomerID,
                            ID_workingHour = (Guid)_workingHourID,
                            Number_nomenclature = (int)_numberNomenclature,
                            Amount = amount,
                            NormOfTime = normOfTime
                        };

                        context.Work.Add(insertWorkInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertWorkInfo.ID;

                    }
                }
                View.Close();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}