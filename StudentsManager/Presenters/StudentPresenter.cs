using StudentsManager.Model;
using StudentsManager.Models.Student;
using StudentsManager.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Presenters
{
    public class StudentPresenter
    {
        private IStudentView studentView;
        private IStudentRepository studentRepository;
        private BindingSource studentBindingSource;
        private IEnumerable<StudentModel> studentList;

        public StudentPresenter(IStudentView studentView, IStudentRepository studentRepository)
        {
            this.studentBindingSource = new BindingSource();
            this.studentView = studentView;
            this.studentRepository = studentRepository;
            //Subcribe event handler methods to view events
            this.studentView.SearchEvent += SearchStudent;
            this.studentView.AddNewEvent += AddNewStudent;
            this.studentView.EditEvent += LoadSelectedStudentToEdit;
            this.studentView.DeleteEvent += DeleteSelectedStudent;
            this.studentView.CancelEvent += CancelAction;
            this.studentView.SaveEvent += SaveStudent;
            //Set students binding source
            this.studentView.SetStudentListBindingSource(studentBindingSource);
            //Load student list view
            LoadAllStudentList();
            //Show view
            this.studentView.Show();
    }

        

        private void LoadAllStudentList()
        {
            studentList = studentRepository.GetAll();
            studentBindingSource.DataSource = studentList; // set data source
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.studentView.searchValue);
            if (emptyValue == false)
            {
                studentList = studentRepository.GetByValue(this.studentView.searchValue);
            }
            else
            {
                studentList = studentRepository.GetAll();
            }
            studentBindingSource.DataSource = studentList;
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            studentView.isEdit = false;
        }

        private void LoadSelectedStudentToEdit(object sender, EventArgs e)
        {
            var student = (StudentModel)studentBindingSource.Current;
            studentView.studentId = student.Id;
            studentView.studentName = student.Name;
            studentView.studentClassName = student.ClassName;
            studentView.mathScore = student.MathScore;
            studentView.literatureScore = student.LiteratureScore;
            studentView.englishScore = student.EnglishScore;
            studentView.isEdit = true;
        }
        private void SaveStudent(object sender, EventArgs e)
        {
            var model = new StudentModel();
            model.Id = studentView.studentId;
            model.Name = studentView.studentName ;
            model.ClassName = studentView.studentClassName;
            model.MathScore = studentView.mathScore;
            model.LiteratureScore = studentView.literatureScore;
            model.EnglishScore = studentView.englishScore;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(studentView.isEdit) //edit model
                {
                    studentRepository.Edit(model);
                    studentView.message = "Student edited successfully!";
                }
                else // add new model
                {
                    studentRepository.Add(model);
                    studentView.message = "Student added successfully!";
                }
                studentView.isSuccessful = true;
                LoadAllStudentList();
                CleanviewFields();
            } 
            catch (Exception ex)
            {
                studentView.isSuccessful = false;
                studentView.message = ex.Message;
            }
        }
        private void CleanviewFields()
        {
            studentView.studentId = "";
            studentView.studentName = "";
            studentView.studentClassName = "";
            studentView.mathScore = 0;
            studentView.literatureScore = 0;
            studentView.englishScore = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void DeleteSelectedStudent(object sender, EventArgs e)
        {
            try
            {
                var student = (StudentModel)studentBindingSource.Current;
                studentRepository.Delete(student.Id);
                studentView.isSuccessful = true;
                studentView.message = "Pet deleted successfully!";
                LoadAllStudentList();
            }
            catch 
            {
                studentView.isSuccessful = false;
                studentView.message = "An error occured, could not delete student";
            }
        }
    }
}
