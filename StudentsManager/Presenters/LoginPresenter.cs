using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManager.Views;
using StudentsManager.Models;
using StudentsManager._Repositories;
using StudentsManager.Models.Student;
using StudentsManager.Model;
using StudentsManager.Models.User;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudentsManager.Presenters
{
    public class LoginPresenter
    {
        private ILoginView loginView;
        private IUserRepository userRepository;
        private readonly string sqlConnectionString;
        private bool isLoggedIn;

        public LoginPresenter(ILoginView loginView, string sqlConnectionString)
        {
            this.loginView = loginView;
            this.sqlConnectionString = sqlConnectionString;
            this.loginView.Login += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            userRepository = new UserRepository(sqlConnectionString);
            this.isLoggedIn = userRepository.GetByUserAndPassword(loginView.UserName, loginView.Password);
            if (this.isLoggedIn == true)
            {
                loginView.Hide();
                IStudentView studentView = StudentView.GetInstance();
                IStudentRepository studentRepository = new StudentRepository(sqlConnectionString);
                new StudentPresenter(studentView, studentRepository);
                

            } else
            {
                MessageBox.Show("Fail to login, please check username and password!","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
