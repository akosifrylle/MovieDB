using System.Web.Mvc;
using MovieDB.NHibernate.Dao;
using MovieDB.Services;

namespace MovieDB.Web.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            this._genreService = genreService;
        }

        public ActionResult Index()
        {
            //var genre = new Genre
            //{
            //    Name = "Acoustic"
            //};
            //_genreService.Save(genre);

            //var genre = _genreService.GetById(2);
            return View();
        }
    }
}