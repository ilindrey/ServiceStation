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
    internal class ReasonCustomerPresenter  : BasePresenter<IEditingReasonCustomerView, Guid?>
    {
        private const string _messageSaveConfirmation = "Причина обращения заказчика будет сохранена, желаете продолжить?";
        private int _numberApplication;
        private Guid? _reasonID;
        private WorkJournal _workJournal;
        private MaterialJournal _materialJournal;
        private MaterialJournal _materialCustomerJournal;
        

        internal ReasonCustomerPresenter(IEditingReasonCustomerView view, int numberApplication) : base(view, _messageSaveConfirmation)
        {
            _numberApplication = numberApplication;

            View.Title = string.Concat("Добавление причины обращения заказчика");

            _workJournal = new WorkJournal(View.Works);
            _materialJournal = new MaterialJournal(View.Materials, false);
            _materialCustomerJournal = new MaterialJournal(View.MaterialsCustomer, true);            
        }

        internal ReasonCustomerPresenter(IEditingReasonCustomerView view, Guid reasonCustomerID, int numberApplication) : base(view, reasonCustomerID, _messageSaveConfirmation)
        {
            _numberApplication = numberApplication;
            View.Title = string.Concat("Редактирование причины обращения заказчика");

            _workJournal = new WorkJournal(View.Works, Identifier);
            _materialJournal = new MaterialJournal(View.Materials, false, Identifier);
            _materialCustomerJournal = new MaterialJournal(View.MaterialsCustomer, true, Identifier);

        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.ReasonCustomer.Where(rc => rc.ID == (Guid)Identifier).Select(rc => new
                    {
                        rc.ID_reason,
                        rc.Reason.ShortName,
                        //rc.Reason.FullName,
                        rc.Reason.Type,
                    }).FirstAsync();

                    _reasonID = result.ID_reason;

                    View.Reason = GetReasonText(result.ShortName, result.Type);


                    await CalculateSum();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private string GetReasonText(string reason, string type)
        {
            return string.Format("{0}, тип проявления: {1}", reason, type);
        }

        protected override void SubscribeEvent()
        {
            View.Save += async () => await SaveAsync();

            View.Loading += View_Loading;

            View.SelectionReason += () =>
            {
                JournalsForm journal = new JournalsForm();
                
                JournalsPresenter<Reason> presenter = new JournalsPresenter<Reason>(journal, new ReasonJournal(journal.Grid, _numberApplication));
                
                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    ReasonModel reason = (ReasonModel)presenter.Info;
                    _reasonID = reason.ID;
                    View.Reason = GetReasonText(reason.ShortName, reason.Type);
                }
            };


            View.AddWork += AddWork;

            View.EditWork += EditWork;

            View.DeleteWork += DeleteWork;

            View.AddMaterial += AddMaterial;
            View.EditMaterial += EditMaterial;


            View.DeleteMaterial += DeleteMaterial;

            View.AddMaterialCustomer += AddMaterialCustomer;

            View.EditMaterialCustomer += EditMaterialCustomer;
            View.DeleteMaterialCustomer += DeleteMaterialCustomer;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            await _workJournal.Update();
            await _materialJournal.Update();
            await _materialCustomerJournal.Update();
        }

        private async Task AddWork()
        {
            var verif = await VerificationSaved();

            if (verif)
            {
                await _workJournal.AddRecord();
                await CalculateSum();
            }
        }

        private async Task EditWork()
        {
            await _workJournal.EditRecord();
            await CalculateSum();
        }

        private async Task DeleteWork()
        {
            await _workJournal.DeleteRecord();
            await CalculateSum();
        }

        private async Task AddMaterial()
        {
            var verif = await VerificationSaved();

            if (verif)
            {
                await _materialJournal.AddRecord();
                await CalculateSum();
            }
        }

        private async Task EditMaterial()
        {
            await _materialJournal.EditRecord();
            await CalculateSum();
        }

        private async Task DeleteMaterial()
        {
            await _materialJournal.DeleteRecord();
            await CalculateSum();
        }

        private async Task DeleteMaterialCustomer()
        {
            await _materialCustomerJournal.DeleteRecord();
        }

        private async Task EditMaterialCustomer()
        {
            await _materialCustomerJournal.EditRecord();
        }

        private async Task AddMaterialCustomer()
        {
            var verif = await VerificationSaved();

            if (verif)
                await _materialCustomerJournal.AddRecord();
        }

        internal async Task CalculateSum()
        {
            try
            {

                using (var context = new DbSSContext())
                {

                    var sum = await context.ReasonCustomer.Where(rc => rc.ID == (Guid)Identifier).Select(rc =>

                        new
                        {
                            Price = ((rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)) == null ? 0

                        : rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)))
                        
                        +

                        (rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)) == null ? 0


                        : rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price))))
                        }).FirstAsync();

                    View.Sum = sum.Price?.ToString();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
                           
        protected override async Task SaveAsync()
        {
            try
            {
                if (_reasonID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали причину обращения заказчика!");

                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        Guid id = (Guid)_reasonID;
                        await context.ReasonCustomer.Where(rc => rc.ID == _reasonID).UpdateAsync(rc => new ReasonCustomerModel
                        {
                            ID_reason = id
                        });
                    }
                    else
                    {
                        ReasonCustomerModel insertReasonCustomerInfo = new ReasonCustomerModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ID_reason = (Guid)_reasonID,
                            Number = _numberApplication
                        };

                        context.ReasonCustomer.Add(insertReasonCustomerInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertReasonCustomerInfo.ID;

                        _workJournal.ReasonCustomerID = Identifier;
                        _materialJournal.ReasonCustomerID = Identifier;
                        _materialCustomerJournal.ReasonCustomerID = Identifier;
                    }
                }
                if (!openView)
                    View.Close();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
