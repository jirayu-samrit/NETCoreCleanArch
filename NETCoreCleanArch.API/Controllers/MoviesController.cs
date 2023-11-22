using Microsoft.AspNetCore.Mvc;
using NETCoreCleanArch.Application;
using NETCoreCleanArch.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCoreCleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            this._movieService = movieService;
        }


        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _movieService.GetAllMovies();
            return Ok(moviesFromService);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var newMovie = _movieService.CreateMovie(movie);
            return Ok(newMovie);
        }

    }
}
