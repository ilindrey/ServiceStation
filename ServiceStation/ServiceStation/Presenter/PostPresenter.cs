using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class PostPresenter : BasePresenter<IEditingPostView, Guid?>
    {
        internal PostPresenter(IEditingPostView view) : base(view)
        {
            View.Title = string.Concat("Добавление должности сотрудника");
        }

        internal PostPresenter(IEditingPostView view, Guid postID) : base(view, postID)
        {
            View.Title = string.Concat("Редактирование должности сотрудника");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Post.Where(p => p.ID == (Guid)Identifier).FirstAsync();

                    View.Post = result.Name;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
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

        protected override async Task SaveAsync()
        {
            try
            {
                var post = View.Post;
                
                if (string.IsNullOrWhiteSpace(post))
                    throw new ArgumentNullException(null, "Вы не ввели должность сотрудника!");


                using (var context = new DbSSContext())
                {
                    if(Identifier != null)
                    {
                        await context.Post.Where(p => p.ID == (Guid)Identifier).UpdateAsync(p => new PostModel
                        {
                            Name = post
                        });
                    }
                    else
                    {
                        PostModel insertPostInfo = new PostModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            Name = post
                        };

                        context.Post.Add(insertPostInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertPostInfo.ID;
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
