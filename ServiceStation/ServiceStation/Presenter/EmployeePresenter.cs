using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class EmployeePresenter : BasePresenter<IEditingEmployeeView, Guid?>
    {
        private UserModel _userInfo;
        private Guid? _postID;


        internal EmployeePresenter(IEditingEmployeeView view) : base(view)
        {
            View.Title = string.Concat("Добавление сотрудника предприятия");
        }

        internal EmployeePresenter(IEditingEmployeeView view, Guid employeeID) : base(view, employeeID)
        {
            View.Title = string.Concat("Редактирование сотрудника предприятия");
        }

        internal EmployeePresenter(IEditingEmployeeView view, bool administrator) : base(view)
        {
            View.EditingUser.Visible = administrator;
            View.Title = string.Concat("Добавление сотрудника предприятия");
        }

        internal EmployeePresenter(IEditingEmployeeView view, Guid employeeID, bool administrator) : base(view, employeeID)
        {
            View.EditingUser.Visible = administrator;
            View.Title = string.Concat("Редактирование сотрудника предприятия");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Employee.Where(e => e.ID == (Guid)Identifier).Select(e => new
                    {
                        e.FFP,
                        e.ID_post,
                        Post = e.Post.Name
                    }).FirstAsync();

                    _postID = result.ID_post;
                    View.SetEmployeeInfo(result.FFP, result.Post);

                    if (View.EditingUser.Visible)
                        await GetUser((Guid)Identifier);
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

            View.SelectionPost += () =>
            {
                JournalsForm journal = new JournalsForm();

                JournalsPresenter<Post> presenter = new JournalsPresenter<Post>(journal, new PostJournal(journal.Grid));

                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    PostModel post = (PostModel)presenter.Info;
                    _postID = post.ID;
                    View.Post = post.Name;
                }                
            };

            View.DeleteUser += DeleteUser;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            else if (View.EditingUser.Visible)
            {
                View.EnterUser = true;
                await GetUser(new Guid());
            }
        }

        private async Task DeleteUser()
        {
            try
            {
                if(_userInfo != null)
                {
                    using (var context = new DbSSContext())
                    {
                        await context.User.Where(u => u.ID == _userInfo.ID).DeleteAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private async Task GetUser(Guid employeeID)
        {
            try
            {
                using (var context = new DbSSContext())
                {

                    var user = await context.User.Where(u => u.ID_employee == employeeID)
                                .Select(u => new { u.ID, u.Name, u.Administrator, u.ID_employee }).ToListAsync();

                    if (user.Count() > 0)
                    {
                        foreach (var u in user)
                        {
                            _userInfo = new UserModel
                            {
                                ID = u.ID,
                                Name = u.Name,
                                Administrator = u.Administrator,
                                ID_employee = u.ID_employee
                            };
                        }

                        View.VisibleDeleteUser = true;

                        View.SetUserInfo(_userInfo.Name, "                    ", _userInfo.Administrator);


                        var editingUser = View.EditingUser;

                        editingUser.Visible = true;
                        editingUser.PerformClick();
                    }
                    else
                    {
                        View.SetUserInfo(null, null, false);
                    }
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
                var FFP = View.FFP;
                var enterUser = View.EnterUser;
                var username = View.Username;
                var password = View.Password;
                var administrator = View.Administrator;

                if (string.IsNullOrWhiteSpace(FFP))
                    throw new ArgumentNullException(null, "Вы не ввели фамилию, имя и отчество сотрудника!");
                if (_postID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали должность сотрудника!");
                if (enterUser && string.IsNullOrWhiteSpace(username))
                    throw new ArgumentNullException(null, "Вы не ввели имя пользователя!");
                if (enterUser && string.IsNullOrWhiteSpace(password))
                    throw new ArgumentNullException(null, "Вы не ввели пароль сотрудника!");


                    using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Employee.Where(e => e.ID == (Guid)Identifier).UpdateAsync(e => new EmployeeModel
                        {
                            FFP = FFP,
                            ID_post = (Guid)_postID
                        });
                    }
                    else
                    {
                        EmployeeModel insertEmployeeInfo = new EmployeeModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            FFP = FFP,
                            ID_post = (Guid)_postID
                        };


                        context.Employee.Add(insertEmployeeInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertEmployeeInfo.ID;
                    }
                }

                if (View.EnterUser)
                    await SaveUserAsync(username, password, administrator);

                View.Close();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private async Task SaveUserAsync(string username, string password, bool administrator)
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    if (_userInfo != null)
                    {
                        await context.User.Where(u => u.ID == _userInfo.ID).UpdateAsync(u => new UserModel
                        {
                            Name = username,
                            Password = SHA256.Hash(password),
                            Administrator = administrator
                        });
                    }
                    else
                    {
                        UserModel insertUserInfo = new UserModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            Name = username,
                            Password = SHA256.Hash(password),
                            Administrator = administrator,
                            ID_employee = (Guid)Identifier
                        };

                        context.User.Add(insertUserInfo);

                        await context.SaveChangesAsync();

                        _userInfo = insertUserInfo;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}