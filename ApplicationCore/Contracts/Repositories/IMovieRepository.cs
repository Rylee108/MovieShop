using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IMovieRepository
    {
        //CRUD methods
        // get top30 grossing movies from database
        List<Movie> GetTop30GrossingMovies();




        // get Movie by Id
        //get movie bu Genre

    }
}
