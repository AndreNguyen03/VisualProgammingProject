using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManager._Repositories;
using StudentsManager.Model;
using StudentsManager.Models.Student;
using StudentsManager.Presenters;
using StudentsManager.Views;
using System.Configuration;

namespace StudentsManager
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView loginView = new LoginView();
            new LoginPresenter(loginView, sqlConnectionString);
            Application.Run((Form) loginView);
            
        }
    }
}
