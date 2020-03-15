using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using Win.Properties;

namespace Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
            //    //Models.DataSource.ConnectionString = Settings.Default.ConnectionString;
            //    //var isConnected = new UnitOfWork().StartConnection();
            //    //Application.Run(mainForm: new FrmMain() { IsConnected = isConnected });
            //}
            //catch (Exception e)
            //{
            //    Application.Run(mainForm: new FrmMain() { IsConnected = false });
            //}

            Application.Run(new frmSplashScreen());


        }
    }
}
