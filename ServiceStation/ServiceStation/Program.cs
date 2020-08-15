using ServiceStation.Forms;
using System;
using System.Threading;
using System.Windows.Forms;
using ServiceStation.Presenter;
using System.IO.Compression;
using System.IO;

namespace ServiceStation
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            Mutex M = new Mutex(true, "ServiceStation", out createdNew);
            if (!createdNew) return;


            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                ZipFile.CreateFromDirectory(Directory.GetCurrentDirectory() + @"\DocumentTemplates\", "template.dat", CompressionLevel.Optimal, false);
            }
            catch (Exception) { }

            AuthorizationForm authorization = new AuthorizationForm();
            AuthorizationPresenter presenter = new AuthorizationPresenter(authorization);
            //MainForm main = new MainForm();
            //MainPresenter presenter = new MainPresenter(main, true);
            Application.Run(authorization);


            GC.KeepAlive(M);
        }
    }
}
