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
    internal class MarkJournal : BaseJournal<Mark>
    {
        private EditingMarkForm _mark;
        private MarkPresenter _presenter;


        internal MarkJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {
            WightColumn("ShortName", 400);
            WightColumn("FullName", 500);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _mark = new EditingMarkForm();
                _presenter = new MarkPresenter(_mark);
                _mark.ShowDialog();

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
                    _mark = new EditingMarkForm();
                    _presenter = new MarkPresenter(_mark, Item.ID);
                    _mark.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы действительно хотите удалить марку автомобиля?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Mark.Where(m => m.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить марку, поскольку она привязана к одной или нескольким моделям автомобилей!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Concat("ShortName LIKE '", text, "%'");
        }
        
        protected override async Task<IEnumerable<Mark>> QueryData()
        {
            IEnumerable<Mark> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Mark
                .Select(m => new Mark
                {
                    ID = m.ID,
                    ShortName = m.ShortName,
                    FullName = m.FullName
                }).OrderBy(m => new { m.ShortName, m.FullName }).ToListAsync();
            };

            return result;
        }

        internal override Task<object> GetInfo()
        {
            var item = Item;

            MarkModel mark = new MarkModel
            {
                ID = item.ID,
                ShortName = item.ShortName,
                FullName = item.FullName
            };

            return Task.FromResult((object)mark);
        }
    }
}
