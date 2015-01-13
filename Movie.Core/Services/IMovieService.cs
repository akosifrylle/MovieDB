using System.Collections.Generic;

namespace Movie.Core.Services
{
    public interface IMovieService
    {
        Movie Add(Movie movie);
        void Remove(Movie movie);
        Movie GetById(string id);
        IList<Movie> GetList();
    }
}
