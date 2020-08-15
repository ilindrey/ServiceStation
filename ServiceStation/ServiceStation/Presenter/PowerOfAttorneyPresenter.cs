using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class PowerOfAttorneyPresenter : BasePresenter<IEditingPowerOfAttorneyView, Guid?>
    {
        private Guid _contactPersonID;


        internal PowerOfAttorneyPresenter(IEditingPowerOfAttorneyView view, Guid contractPersonID) : base(view)
        {
            _contactPersonID = contractPersonID;
            View.Title = string.Concat("Добавление доверенности");
        }

        internal PowerOfAttorneyPresenter(IEditingPowerOfAttorneyView view, Guid powerOfAttornayID, Guid contractPersonID) : base(view, powerOfAttornayID)
        {
            _contactPersonID = contractPersonID;
        }


        protected override void SubscribeEvent()
        {
            View.Loading += View_Loading;

            View.Save += async () => await SaveAsync();
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }

        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.PowerOfAttorney.Where(p => p.ID == (Guid)Identifier).Select(p => new
                    {
                        p.Number,
                        p.Date
                    }).FirstAsync();

                    View.Title = string.Format("Редактирование доверенности №{0} от {1:dd/MM/yy}", result.Number, result.Date);
                    View.SetPowerOfAttorneyInfo(result.Number, result.Date);
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
                var number = View.Number;
                var date = View.Date;


                if (string.IsNullOrWhiteSpace(number))
                    throw new ArgumentNullException(null, "Введите номер доверености");


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.PowerOfAttorney.Where(pa => pa.ID == (Guid)Identifier).UpdateAsync(pa => new PowerOfAttorneyModel
                        {
                            Number = number,
                            Date = date
                        });
                    }
                    else
                    {
                        PowerOfAttorneyModel insertPowerOfAttorneyInfo = new PowerOfAttorneyModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            Number = number,
                            Date = date,
                            ID_contactPerson = _contactPersonID
                        };

                        context.PowerOfAttorney.Add(insertPowerOfAttorneyInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertPowerOfAttorneyInfo.ID;
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
