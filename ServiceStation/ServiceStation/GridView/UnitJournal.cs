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
    internal class UnitJournal : BaseJournal<Unit>
    {
        private EditingUnitForm _unit;
        private UnitPresenter _presenter;


        internal UnitJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {
            WightColumn("Code", 75);
            WightColumn("Name", 250);
            WightColumn("ShortName", 250);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _unit = new EditingUnitForm();
                _presenter = new UnitPresenter(_unit);
                _unit.ShowDialog();

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
                    _unit = new EditingUnitForm();
                    _presenter = new UnitPresenter(_unit, Item.Code);
                    _unit.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление единицы измерения"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Unit.Where(u => u.Code == Item.Code).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить единицу измерения, поскольку она используется в одной или несколких номенклатурах");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("Name LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Unit>> QueryData()
        {
            IEnumerable<Unit> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Unit.Select(u => new Unit { Code = u.Code, Name = u.Name, ShortName = u.ShortName }).OrderBy(u => new { u.Name, u.ShortName }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new UnitModel
            {
                Code = item.Code,
                Name = item.Name,
                ShortName = item.ShortName
            };

            return Task.FromResult(result);
        }
    }
}