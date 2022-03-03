using MovieManagement.API.Models;

namespace MovieManagement.API.Repository
{
    public class NewFeatureRepository : IMovieRepository
    {
        public Movie CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAllMovies()
        {
            return new List<Movie>(){ new Movie { Id = 1 , Name = "cool feature" 
                , Cost = 0 }};
        }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
