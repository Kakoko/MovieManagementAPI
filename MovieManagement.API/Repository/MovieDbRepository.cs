using MovieManagement.API.Data;
using MovieManagement.API.Models;

namespace MovieManagement.API.Repository
{
    public class MovieDbRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieDbRepository(MovieDbContext context )
        {
            _context = context;
        }
        public Movie CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            //_context.SaveChanges();
            return movie;
        }

        public Movie DeleteMovie(int id)
        {
           var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if(movie != null)
            {
                _context.Movies.Remove(movie);
                return movie;
            }

            throw new ArgumentNullException("Movie not found");
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _context.Movies.ToList();
            return movies;
        }

        public Movie GetMovieById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                
                return movie;
            }

            throw new ArgumentNullException("Movie not found");
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() >= 0);
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            var movieFromDatabase = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                movieFromDatabase.Name = movie.Name;
                movieFromDatabase.Cost = movie.Cost;

                _context.Movies.Update(movieFromDatabase);
                return movieFromDatabase;
            }

            throw new ArgumentNullException("Movie not found");
        }
    }
}
