using MovieDB.Data;

namespace MovieDB.NHibernate.Dao
{
    public class UserDao : IUserDao
    {
        public User AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool Authenticate(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public User EditUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<User> GetList()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
