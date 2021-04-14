using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public interface IUserRepository
    {
        void AddUser(UserViewModel model);
        UserViewModel GetUserByUserId(string userId);
        bool IsCorrectUser(string userId, string password);
        void ModifyUser(int uid, string userId, string password);
        UserViewModel IsCorrectUserReturnModel(string userId, string password);
    }
}
