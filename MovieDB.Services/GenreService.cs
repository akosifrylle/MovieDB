using System.Collections;
using System.Collections.Generic;
using MovieDB.Data;
using MovieDB.NHibernate.Dao;

namespace MovieDB.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreDao _genreDao;

        public GenreService(IGenreDao genreDao)
        {
            _genreDao = genreDao;
        }

        public Genre Save(Genre genre)
        {
            return _genreDao.Save(genre);
        }

        public Genre GetById(int id)
        {
            return _genreDao.GetById(id);
        }

        public void Delete(Genre genre)
        {
            _genreDao.Delete(genre);
        }

        public IList<Genre> GetList()
        {
            return _genreDao.GetList();
        }
    }
}
