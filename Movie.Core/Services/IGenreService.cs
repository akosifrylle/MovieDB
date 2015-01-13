using System.Collections.Generic;

namespace Movie.Core.Services
{
    public interface IGenreService
    {
        Genre Add(Genre genre);
        void Remove(Genre genre);
        Genre GetById(int id);
        IList<Genre> GetList();
    }
}
