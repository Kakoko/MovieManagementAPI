using MovieManagement.API.Models;

namespace MovieManagement.API.Repository
{
    public class MovieRepository : IMovieRepository
    {
        //Create our Database
        //This is not permanent
        //at build it will revert to the values set below
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie() {Id = 1 , Name = "Eastern Condors" , Cost = 300},
            new Movie() {Id = 2 , Name = "Deadly Prey" , Cost = 400},
            new Movie() {Id = 3 , Name = "Double Impact" , Cost = 500}
        };

        // Get All Movies
        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        //Get a Single Moview by ID
        public Movie GetMovieById(int id)
        {
            var movieFromList = movies.FirstOrDefault(x => x.Id == id);

            if (movieFromList != null)
            {
                return movieFromList;
            }

            throw new ArgumentNullException("Movie does not exist");
        }

        //Create a Movie
        public Movie CreateMovie(Movie movie)
        {
            movies.Add(movie);
            return movie;
        }

        //Update a Movie
        public Movie UpdateMovie(int id, Movie movie)
        {
            var movieFromList = movies.FirstOrDefault(x => x.Id == id);

            if (movieFromList != null)
            {
                movieFromList.Name = movie.Name;
                movieFromList.Cost = movie.Cost;
                return movie;
            }

            throw new ArgumentNullException("Movie does not exist");
        }


        //Delete a Movie
        public Movie DeleteMovie(int id)
        {
            var movieFromList = movies.FirstOrDefault(x => x.Id == id);

            if (movieFromList != null)
            {
                movies.Remove(movieFromList);
                return movieFromList;
            }

            throw new ArgumentNullException("Movie does not exist");
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
