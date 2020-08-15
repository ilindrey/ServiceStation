using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.GridView;
using System.Threading.Tasks;
using ServiceStation.Presenter;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class CarPresenter : BasePresenter<IEditingCarView, Guid?>
    {
        private Guid? _modelID;
        private Guid _contractorID;


        internal CarPresenter(IEditingCarView view, Guid contractorID) : base(view)
        {
            _contractorID = contractorID;
            View.Title = string.Concat("Добавление автомобиля");
        }

        internal CarPresenter(IEditingCarView view, Guid carID, Guid contractorID) : base(view, carID)
        {
            _contractorID = contractorID;
            View.Title = string.Concat("Редактирование автомобиля");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Car.Where(c => c.ID == (Guid)Identifier).Select(c => new
                    {
                        c.ID,
                        c.ID_model,
                        c.Color,
                        c.ID_contractor,
                        Model = c.Model.Name,
                        c.VIN,
                        c.Mileage,
                        c.LicensePlate,
                        c.NumberEngine,
                        c.NumberChassis,
                        c.NumberBody,
                        c.Year,
                        c.Price
                    }).FirstAsync();


                    _modelID = result.ID_model;
                    _contractorID = result.ID_contractor;

                    View.SetCarInfo(result.Model, result.VIN, result.Mileage, result.LicensePlate, result.NumberEngine, result.NumberChassis, result.NumberBody, result.Year, result.Color, result.Price);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        
        protected override void SubscribeEvent()
        {
            View.Save += async () => await SaveAsync();

            View.Loading += View_Loading;

            View.SelectionModel += () =>
            {
                JournalsForm journal = new JournalsForm();

                JournalsPresenter<GridView.Model> presenter = new JournalsPresenter<GridView.Model>(journal, new ModelJournal(journal.Grid));

                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    ModelModel model = (ModelModel)presenter.Info;
                    _modelID = model.ID;
                    View.NameModel = model.Name;
                }                
            };
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }

        protected override async Task SaveAsync()
        {
            try
            {
                var VIN = View.VIN;
                var mileage = View.Mileage;
                var licensePlate = View.LicensePlate;
                var numberEngine = View.NumberEngine;
                var numberChassis = View.NumberChassis;
                var numberBody = View.NumberBody;
                var year = View.Year;
                var price = View.Price;
                var color = View.Color;


                if (_modelID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали модель автомобиля!");
                if (string.IsNullOrWhiteSpace(VIN))
                    throw new ArgumentNullException(null, "Вы не до конца ввели VIN автомобиля!");
                

                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Car.Where(v => v.ID == (Guid)Identifier).UpdateAsync(v => new CarModel
                        {
                            VIN = VIN,
                            ID_model = (Guid)_modelID,
                            Mileage = mileage,
                            LicensePlate = GetNullValue(licensePlate),
                            NumberEngine = GetNullValue(numberEngine),
                            NumberChassis = GetNullValue(numberChassis),
                            NumberBody = GetNullValue(numberBody),
                            Year = year,
                            Price = price,
                            Color = GetNullValue(color),
                            ID_contractor = _contractorID
                        });
                    }
                    else
                    {
                        CarModel insertCarInfo = new CarModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            VIN = VIN,
                            ID_model = (Guid)_modelID,
                            LicensePlate = GetNullValue(licensePlate),
                            NumberEngine = GetNullValue(numberEngine),
                            NumberChassis = GetNullValue(numberChassis),
                            NumberBody = GetNullValue(numberBody),
                            Year = year,
                            Mileage = mileage,
                            Price = price,
                            Color = GetNullValue(color),
                            ID_contractor = _contractorID
                        };

                        context.Car.Add(insertCarInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertCarInfo.ID;
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
