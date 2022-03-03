using MovieManagement.API.Models;

namespace MovieManagement.API.Repository
{
    public interface IMovieRepository
    {
        Movie CreateMovie(Movie movie);
        Movie DeleteMovie(int id);
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        Movie UpdateMovie(int id, Movie movie);
        bool SaveChanges();
    }
}