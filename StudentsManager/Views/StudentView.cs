using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Views
{
    public partial class StudentView : Form,IStudentView
    {
        //Fields
        
        private string messageSV;
        private bool isSuccessfulSV;
        private bool isEditSV;
        private ILoginView loginView;
        public StudentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        

        private void AssociateAndRaiseViewEvents()
        {
            tabControlStudent.TabPages.Remove(tabPageStudentDetail);

            //Mainview Closed => show loginview
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxSearchStudent.KeyDown += (s, e) => {
                if(e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add new
            btnAddNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControlStudent.TabPages.Add(tabPageStudentDetail);
                tabControlStudent.TabPages.Remove(tabPageStudentList);
                tabPageStudentDetail.Text = "Add new student";
            };
            //Edit
            btnEdit.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlStudent.TabPages.Remove(tabPageStudentList);
                tabControlStudent.TabPages.Add(tabPageStudentDetail);
                tabPageStudentDetail.Text = "Edit student";
            };
            //Delete
            btnDelete.Click += delegate 
            { 
                var result = MessageBox.Show("Are you sure you want to delete the selected student ?","Warning",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
            };
            //Save
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if(isSuccessful)
                {
                    tabControlStudent.TabPages.Remove(tabPageStudentDetail);
                    tabControlStudent.TabPages.Add(tabPageStudentList);
                }
                MessageBox.Show(message);
            };
            //Cancel
            btnCancel.Click += delegate
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlStudent.TabPages.Remove(tabPageStudentDetail); 
                tabControlStudent.TabPages.Add(tabPageStudentList);
            };

        }

        public string studentId { get => textBoxStudentId.Text; set => textBoxStudentId.Text = value; }
        public string studentName { get => textBoxStudentName.Text; set => textBoxStudentName.Text = value; }
        public string studentClassName { get => textBoxStudentClassName.Text; set => textBoxStudentClassName.Text = value; }
        public float mathScore { get => float.Parse(textBoxMathScore.Text); set => textBoxMathScore.Text = value.ToString(); }
        public float literatureScore { get => float.Parse(textBoxLiteratureScore.Text); set => textBoxLiteratureScore.Text = value.ToString(); }
        public float englishScore { get => float.Parse(textBoxEnglishScore.Text); set => textBoxEnglishScore.Text = value.ToString(); }
        public string searchValue { get => textBoxSearchStudent.Text; set => textBoxSearchStudent.Text = value; }
        public bool isEdit { get => isEditSV; set => isEditSV = value; }
        public bool isSuccessful { get => isSuccessfulSV; set => isSuccessfulSV = value; }
        public string message { get => messageSV; set => messageSV = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetStudentListBindingSource(BindingSource studentList)
        {
            dataGridViewStudentList.DataSource = studentList;
        }

        //Singleton pattern (Open a single form instance)
        private static StudentView instance;
        public static StudentView GetInstance()
        {
            if(instance ==null || instance.IsDisposed)
            {
                instance = new StudentView();
            } else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void StudentView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            loginView = new LoginView();
            loginView.Show();
        }

    }
}
