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
    internal class PostJournal : BaseJournal<Post>
    {
        private EditingPostForm _post;
        private PostPresenter _presenter;


        internal PostJournal(DataGridView journal) : base(journal) { }

        protected override void OperationColumn()
        {
            WightColumn("Name", 400);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _post = new EditingPostForm();
                _presenter = new PostPresenter(_post);
                _post.ShowDialog();

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
                    _post = new EditingPostForm();
                    _presenter = new PostPresenter(_post, Item.ID);
                    _post.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление должности?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Post.Where(p => p.ID == Item.ID).DeleteAsync();
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
            Binding.Filter = string.Format("Name LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Post>> QueryData()
        {
            IEnumerable<Post> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Post.Select(p => new Post { ID = p.ID, Name = p.Name }).OrderBy(p => new { p.Name }).ToListAsync();
            }

            return result;
        }



        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new PostModel
            {
                ID = item.ID,
                Name = item.Name
            };

            return Task.FromResult(result);
        }
    }
}