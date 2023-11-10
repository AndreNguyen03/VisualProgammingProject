using StudentsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager.Models.Student
{
    public interface IStudentRepository
    {
        void Add(StudentModel studentModel);
        void Edit(StudentModel studentModel);
        void Delete(string id);
        IEnumerable<StudentModel> GetAll();
        IEnumerable<StudentModel> GetByValue(string value);

    }
}
