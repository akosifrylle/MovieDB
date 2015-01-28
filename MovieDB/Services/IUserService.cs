using System.Collections.Generic;

namespace MovieDB.Services
{
    interface IUserService
    {
        User AddUser(User user);
        bool AuthenticateUser(string username, string password);
        User EditUser(User user);
        IList<User> GetList();
        User GetById(int id);
    }
}
