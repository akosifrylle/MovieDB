using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieDB.Services;

namespace MovieDB.Web.Controllers.Api
{
    public class GenreController : ApiController
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            this._genreService = genreService;
        }

        [HttpGet]
        public IList<Genre> Get()
        {
            return _genreService.GetList();
        } 
    }
}
