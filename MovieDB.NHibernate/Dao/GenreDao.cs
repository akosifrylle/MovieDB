using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieDB.Data;
using MovieDB.NHibernate.Repo;

namespace MovieDB.NHibernate.Dao
{
    public class GenreDao : IGenreDao
    {
        public Genre Save(Genre genre)
        {
            var genreRepo = Mapper.Map<GenreRepo>(genre);
            NH.Run(s => s.SaveOrUpdate(genreRepo));
            return Mapper.Map<Genre>(genreRepo);
        }

        public void Delete(Genre genre)
        {
            NH.Run(s => s.Delete(Mapper.Map<GenreRepo>(genre)));
        }

        public Genre GetById(int id)
        {
            return Mapper.Map<Genre>(NH.Select(s => s.Get<GenreRepo>(id)));
        }

        public IList<Genre> GetList()
        {
            var genreList = Mapper.Map<IList<Genre>>(NH.Select(s => s.QueryOver<GenreRepo>().List()));
            return genreList.OrderBy(a => a.Name).ToList();
        }

        public IList<Genre> GetByGenre(string genre)
        {
            throw new NotImplementedException();
        }
    }
}
