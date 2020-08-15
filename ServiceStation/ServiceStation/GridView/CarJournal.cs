using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;

namespace ServiceStation.GridView
{
    internal class CarJournal : BaseJournal<Car>
    {
        private EditingCarForm _car;
        private CarPresenter _presenter;


        internal Guid? ContractorID { get; set; }


        internal CarJournal(DataGridView journal) : base(journal) { }

        internal CarJournal(DataGridView journal, Guid? contractorID) : base(journal)
        {
            ContractorID = contractorID;
        }


        protected override void OperationColumn()
        {
            WightColumn("Model", 120);
            WightColumn("VIN", 125);
            WightColumn("LicensePlate", 175);
            WightColumn("Mileage", 150);
            WightColumn("Color", 125);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _car = new EditingCarForm();
                _presenter = new CarPresenter(_car, (Guid)ContractorID);
                _car.ShowDialog();

                await Update();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override async Task EditRecord()
        {
            try
            {
                if (ExistsRecord)
                {
                    _car = new EditingCarForm();

                    _presenter = new CarPresenter(_car, Item.ID, (Guid)ContractorID);
                    _car.ShowDialog();

                    await Update();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override async Task DeleteRecord()
        {

            try
            {
                if (ExistsRecord && ShowConfirmation("Вы подтверждате удаление автомобиля?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Car.Where(v => v.ID.Equals(Item.ID)).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить автомобиль, поскольку он содержится в одной или нескольких заявках!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("Model LIKE '{0}%'", text);
        }


        protected override async Task<IEnumerable<Car>> QueryData()
        {
            IEnumerable<Car> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Car.Where(c => c.ID_contractor == ContractorID).Select(c => new Car
                {
                    ID = c.ID,
                    Model = c.Model.Name,
                    VIN = c.VIN,
                    Mileage = c.Mileage,
                    LicensePlate = c.LicensePlate,
                    Year = SqlFunctions.DatePart("yyyy", c.Year),
                    Color = c.Color
                }).OrderBy(c => new { c.Model, c.VIN }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new CarModel
            {
                ID = item.ID,
                VIN = item.VIN,
                Model = new ModelModel { Name = item.Model }
            };

            return Task.FromResult(result);
        }
    }
}