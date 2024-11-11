using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            return InMemoryDb.Movies;
        }
    }
}
