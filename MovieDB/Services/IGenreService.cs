using System.Collections;
using System.Collections.Generic;

namespace MovieDB.Services
{
    public interface IGenreService
    {
        Genre Save(Genre genre);
        Genre GetById(int id);
        IList<Genre> GetList();
        void Delete(Genre genre);
    }
}
