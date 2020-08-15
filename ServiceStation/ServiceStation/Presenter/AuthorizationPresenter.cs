using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStation.Forms;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class AuthorizationPresenter : BasePresenter<IAuthorizationView>
    {
        private MainForm _main;
        private MainPresenter _presenter;

        internal AuthorizationPresenter(IAuthorizationView view) : base(view) { }


        protected override void SubscribeEvent()
        {
            View.Login += View_Login;
        }
        

        private async Task View_Login()
        {
            try
            {
                var username = View.Username;
                var password = View.Password;

                using (var context = new DbSSContext())
                {
                    string hash = SHA256.Hash(password);
                    var result = await context.User.Where(u => u.Name == username && u.Password == hash).Select(u => u.Administrator).ToListAsync();

                    if (result?.Count > 0)
                    {
                        View.Hide();
                        _main = new MainForm();
                        _presenter = new MainPresenter(_main, result.First());
                        _main.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        ShowError("Вы не верно ввели имя пользователя или пароль!");
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
