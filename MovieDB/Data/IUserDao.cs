using System.Collections.Generic;

namespace MovieDB.Data
{
    public interface IUserDao
    {
        User AddUser(User user);
        bool Authenticate(string username, string password);
        User EditUser(User user);
        IList<User> GetList();
        User GetById(int id);
    }
}
