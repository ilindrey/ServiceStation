using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;

namespace ServiceStation.GridView
{
    internal class MaterialJournal : BaseJournal<Material>
    {
        private EditingMaterialForm _materail;
        private MaterialPresenter _presenter;


        internal bool Customer { get; set; }
        internal Guid? ReasonCustomerID { get; set; }


        internal MaterialJournal(DataGridView journal, bool customer) : base(journal)
        {
            Customer = customer;
        }

        internal MaterialJournal(DataGridView journal, bool customer, Guid? reasonCustomerID) : this(journal, customer)
        {
            ReasonCustomerID = reasonCustomerID;
        }


        protected override void OperationColumn()
        {
            WightColumn("Nomenclature", 365);
            WightColumn("Amount", 75);
            WightColumn("Unit", 135);
            WightColumn("Price", 100);
            WightColumn("Sum", 100);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _materail = new EditingMaterialForm();
                _presenter = new MaterialPresenter(_materail, (Guid)ReasonCustomerID, Customer);
                _materail.ShowDialog();

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
                    _materail = new EditingMaterialForm();
                    _presenter = new MaterialPresenter(_materail, Item.ID);
                    _materail.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаетеудаление метериала?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Material.Where(m => m.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("Material LIKE '{0}%'", text);
        }


        protected override async Task<IEnumerable<Material>> QueryData()
        {
            IEnumerable<Material> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Material.Where(m => m.ID_reasonCustomer == ReasonCustomerID && m.Customer == Customer).Select(m => new Material
                {
                    ID = m.ID,
                    Nomenclature = m.Nomenclature.ShortName,
                    Amount = m.Amount,
                    Unit = m.Nomenclature.Unit.Name,
                    Price = m.Price,
                    Sum = m.Amount * m.Price
                }).OrderBy(m => new { m.Nomenclature }).ToListAsync();
            }

            return result;
        }
        
        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new MaterialModel
            {
                ID = item.ID,
                Nomenclature = new NomenclatureModel { ShortName = item.Nomenclature }
            };

            return Task.FromResult(result);
        }
    }
}