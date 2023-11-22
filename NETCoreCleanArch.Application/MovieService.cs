using NETCoreCleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        //Constructor Dependency Injection
        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            var newMovie = _movieRepository.CreateMovie(movie);
            return newMovie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
