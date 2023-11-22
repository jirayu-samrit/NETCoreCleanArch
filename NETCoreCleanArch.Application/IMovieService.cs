using NETCoreCleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Application
{
    //This is a user case
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
