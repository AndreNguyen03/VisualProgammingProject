using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManager.Views;

namespace StudentsManager.Views
{
    public  partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            this.btnLogin.Click += delegate { Login?.Invoke(this,EventArgs.Empty); };
            textBoxPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    Login?.Invoke(this, EventArgs.Empty);
            };

        }

        public string UserName { get => textBoxUsername.Text; set => textBoxUsername.Text = value; }
        public string Password { get => textBoxPassword.Text; set => textBoxPassword.Text = value; }

        public event EventHandler Login;

        
    }
}
