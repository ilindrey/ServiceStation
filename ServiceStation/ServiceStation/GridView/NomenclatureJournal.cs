using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    internal class NomenclatureJournal : BaseJournal<Nomenclature>
    {
        private EditingNomenclatureForm _nomencature;
        private NomenclaturePresenter _presenter;


        internal string Type { get; set; }


        internal NomenclatureJournal(DataGridView journal) : base(journal) { }

        internal NomenclatureJournal(DataGridView journal, string type) : base(journal)
        {
            Type = type;
        }


        protected override void OperationColumn()
        {
            WightColumn("Number", 50);
            WightColumn("ShortName", 370);
            WightColumn("FullName", 400);
            WightColumn("VendorCode", 125);
            WightColumn("Unit", 175);
            WightColumn("Type", 50);
        }

        internal override async Task AddRecord()
        {
            try
            {
                InitializeNomenclatureForm();

                _presenter = new NomenclaturePresenter(_nomencature);
                _nomencature.ShowDialog();

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
                    InitializeNomenclatureForm();

                    _presenter = new NomenclaturePresenter(_nomencature, Item.Number);
                    _nomencature.ShowDialog();

                    await Update();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void InitializeNomenclatureForm()
        {
            _nomencature = new EditingNomenclatureForm();

            if (Type == TypeNomernclature.Work)
            {
                _nomencature.Good.Enabled = false;
                _nomencature.Work.Checked = true;
            }
            else if (Type == TypeNomernclature.Good)
            {
                _nomencature.Work.Enabled = false;
                _nomencature.Good.Checked = true;
            }
        }

        internal override async Task DeleteRecord()
        {
            try
            {
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление номенклатуры?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Nomenclature.Where(n => n.Number == Item.Number).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить номенклатуру, поскольку она привязана к одной или нескольким заявкам!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("ShortName LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Nomenclature>> QueryData()
        {
            IEnumerable<Nomenclature> result = null;

            using (var context = new DbSSContext())
            {
                if (string.IsNullOrEmpty(Type))
                    result = await context.Nomenclature.Select(n => new Nomenclature
                    {
                        Number = n.Number,
                        ShortName = n.ShortName,
                        FullName = n.FullName,
                        VendorCode = n.VendorCode,
                        Unit = n.Unit.Name,
                        Type = n.Type
                    }).OrderBy(n => new { n.ShortName, n.FullName, n.VendorCode, n.Unit }).ToListAsync();
                else
                    result = await context.Nomenclature.Where(n => n.Type == this.Type).Select(n => new Nomenclature
                    {
                        Number = n.Number,
                        ShortName = n.ShortName,
                        FullName = n.FullName,
                        VendorCode = n.VendorCode,
                        Unit = n.Unit.Name,
                        Type = n.Type
                    }).OrderBy(n => new { n.ShortName, n.FullName, n.VendorCode, n.Unit }).ToListAsync();
            }

            return result;
        }

        internal override async Task<object> GetInfo()
        {
            NomenclatureModel nomenclature = null;

            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Nomenclature.Where(n => n.Number == Item.Number).Select(n => new { n.Number, n.ShortName, n.Price }).FirstAsync();

                    nomenclature = new NomenclatureModel
                    {
                        Number = result.Number,
                        ShortName = result.ShortName,
                        Price = result.Price
                    };
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return nomenclature;
        }
    }
}