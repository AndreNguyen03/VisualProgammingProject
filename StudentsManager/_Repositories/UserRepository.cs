using StudentsManager.Model;
using StudentsManager.Models.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager._Repositories
{
    public class UserRepository: BaseRepository,IUserRepository
    {
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool GetByUserAndPassword(string name, string password)
        {
            var userList = new List<UserModel>();
            string _username = name;
            string _password = password;
            bool isLogin;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM USERADMIN WHERE userName = @UserName AND userPassword = @Password";
                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar).Value = _username;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = _password;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.username = reader[0].ToString();
                        userModel.password = reader[1].ToString();
                        userList.Add(userModel);
                    }
                }
            }
            if(userList.Count>0)
            {
                isLogin = true;
            }
            else isLogin = false;
            return isLogin;
        }

        

        public IEnumerable<UserModel> GetByvalue(string value)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
