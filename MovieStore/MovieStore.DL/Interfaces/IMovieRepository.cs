using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        //Movie GetMovieById(int id);
        //void AddMovie(Movie movie);
        //void UpdateMovie(Movie movie);
        //void DeleteMovie(int id);
    }
}
