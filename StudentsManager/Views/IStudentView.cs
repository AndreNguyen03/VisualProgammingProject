using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Views
{
    public interface IStudentView
    {
        string studentId { get; set; }
        string studentName { get; set; }
        string studentClassName { get; set; }
        float mathScore { get; set; }
        float literatureScore { get; set; }
        float englishScore { get; set; }

        string searchValue { get; set; }
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetStudentListBindingSource(BindingSource studentList);
        void Show();
        void Close();
    }
}
