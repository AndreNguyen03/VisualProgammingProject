using StudentsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager.Models.User
{
    public interface IUserRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(int id);
        IEnumerable<UserModel> GetAll(); // Populate all Data
        IEnumerable<UserModel> GetByvalue(string value); // For Search
        bool GetByUserAndPassword(string name, string password);
    }
}
