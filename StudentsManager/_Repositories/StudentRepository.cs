using StudentsManager.Model;
using StudentsManager.Models.Student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager._Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository

    {
        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        public void Add(StudentModel studentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO STUDENT VALUES " +
                    "(@Id,@Name,@ClassName,@MathScore,@LiteratureScore,@EnglishScore)";
                command.Parameters.Add("@Id",System.Data.SqlDbType.VarChar).Value = studentModel.Id;
                command.Parameters.Add("@Name",System.Data.SqlDbType.NVarChar).Value = studentModel.Name;
                command.Parameters.Add("@ClassName",System.Data.SqlDbType.VarChar).Value = studentModel.ClassName;
                command.Parameters.Add("@MathScore",System.Data.SqlDbType.Float).Value = studentModel.MathScore;
                command.Parameters.Add("@LiteratureScore",System.Data.SqlDbType.Float).Value = studentModel.LiteratureScore;
                command.Parameters.Add("@EnglishScore",System.Data.SqlDbType.Float).Value = studentModel.EnglishScore;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM STUDENT WHERE id = @Id";
                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(StudentModel studentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE STUDENT SET " +
                                      "studentName = @Name" +
                                      "className = @ClassName" +
                                      "mathMark = @MathScore" +
                                      "literatureMark = @LiteratureScore" +
                                      "englishMark = @EnglishScore" +
                                      "WHERE id = @Id";
                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = studentModel.Id;
                command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = studentModel.Name;
                command.Parameters.Add("@ClassName", System.Data.SqlDbType.VarChar).Value = studentModel.ClassName;
                command.Parameters.Add("@MathScore", System.Data.SqlDbType.Float).Value = studentModel.MathScore;
                command.Parameters.Add("@LiteratureScore", System.Data.SqlDbType.Float).Value = studentModel.LiteratureScore;
                command.Parameters.Add("@EnglishScore", System.Data.SqlDbType.Float).Value = studentModel.EnglishScore;
                command.ExecuteNonQuery();
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<StudentModel> GetAll()
        {
            var studentList = new List<StudentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * " +
                                      "FROM STUDENT " +
                                      "ORDER BY id ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.Id = reader[0].ToString();
                        studentModel.Name = reader[1].ToString();
                        studentModel.ClassName = reader[2].ToString();
                        studentModel.MathScore = float.Parse(reader[3].ToString());
                        studentModel.LiteratureScore = float.Parse(reader[4].ToString());
                        studentModel.EnglishScore = float.Parse(reader[5].ToString());
                        studentList.Add(studentModel);
                    }
                }
            }
            return studentList;
        }

        public IEnumerable<StudentModel> GetByValue(string value)
        {
            var studentList = new List<StudentModel>();
            string studentId = value;
            string studentName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM STUDENT WHERE id = @Id OR studentName like N'%'+@Name ORDER BY id DESC";
                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = studentId;
                command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = studentName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.Id = reader[0].ToString();
                        studentModel.Name = reader[1].ToString();
                        studentModel.ClassName = reader[2].ToString();
                        studentModel.MathScore = float.Parse(reader[3].ToString());
                        studentModel.LiteratureScore = float.Parse(reader[4].ToString());
                        studentModel.EnglishScore = float.Parse(reader[5].ToString());
                        studentList.Add(studentModel);
                    }
                }
            }
            return studentList;
        }

    }
}
