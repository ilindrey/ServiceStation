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
    internal class OptionJournal : BaseJournal<Option>
    {
        private int _numberApplication;
        private OptionPresenter _presenter;
        private EditingOptionForm _options;


        internal OptionJournal(DataGridView journal) : base(journal) { }
        internal OptionJournal(DataGridView journal, int numberaplication) : base(journal)
        {
            _numberApplication = numberaplication;
        }


        protected override void OperationColumn()
        {
            WightColumn("ShortName", 250);
            WightColumn("FullName", 400);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _options = new EditingOptionForm();
                _presenter = new OptionPresenter(_options);
                _options.ShowDialog();

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
                    _options = new EditingOptionForm();
                    _presenter = new OptionPresenter(_options, Item.ID);
                    _options.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление комплектации?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Option.Where(o => o.ID == Item.ID).DeleteAsync();
                    };

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить комплектацию, поскольку она содержится в одной или нескольких заявках!");
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

        protected override async Task<IEnumerable<Option>> QueryData()
        {
            IEnumerable<Option> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Option.Select(o => new Option
                {
                    ID = o.ID,
                    ShortName = o.ShortName,
                    FullName = o.FullName
                }).OrderBy(o => new { o.ShortName, o.FullName }).ToListAsync();
            }

            return result;
        }



        internal override async Task<object> GetInfo()
        {
            bool exists = false;

            try
            {
                Guid id = Item.ID;
                int verificationExists = 0;

                using (var context = new DbSSContext())
                {
                    verificationExists = await context.OptionCustomer.Where(oc => oc.ID_option == id && oc.Number == _numberApplication).CountAsync();

                    if (verificationExists > 0)
                    {
                        ShowError("Эти коплектация уже находится у заказчика!");
                        exists = false;
                    }
                    else
                    {
                        context.OptionCustomer.Add(new OptionCustomerModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ID_option = id,
                            Number = _numberApplication
                        });

                        await context.SaveChangesAsync();

                        exists = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return exists;
        }
    }
}