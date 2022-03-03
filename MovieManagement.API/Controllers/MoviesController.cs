using Microsoft.AspNetCore.Mvc;
using MovieManagement.API.Models;
using MovieManagement.API.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieManagement.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;

        public MoviesController(IMovieRepository movieRepositorys)
        {
            movieRepository = movieRepositorys;
        }
       // MovieRepository movieRepository = new MovieRepository();
        // GET: api/<MoviessController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromRepo = movieRepository.GetAllMovies();
            return Ok(moviesFromRepo);
        }

        // GET api/<MoviessController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            var movieFromRepo = movieRepository.GetMovieById(id);

            if(movieFromRepo != null)
            {
                return Ok(movieFromRepo);
            }
            return NotFound("Movie not found");
        }

        // POST api/<MoviessController>
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            var createdMovie = movieRepository.CreateMovie(movie);
            if(createdMovie != null)
            {
                movieRepository.SaveChanges();
                return Ok(createdMovie);
            }

            return NotFound();
            
        }

        // PUT api/<MoviessController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Movie movie)
        {
            var updatedMovie = movieRepository.UpdateMovie(id, movie);
            if(updatedMovie != null)
            {
                movieRepository.SaveChanges();
                return Ok(updatedMovie);
            }
            return NotFound("Movie not found");
        }

        // DELETE api/<MoviessController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            var deletedMovie = movieRepository.DeleteMovie(id);
            if(deletedMovie != null)
            {
                movieRepository.SaveChanges();
                return Ok(deletedMovie);
            }
            return NotFound("Movie not found");
        }
    }
}
