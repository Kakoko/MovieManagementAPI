using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieManagement.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviessController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("This is a get request");
        }

        // GET api/<MoviessController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok("This is a get request with ID");
        }

        // POST api/<MoviessController>
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok("This is a post request");
        }

        // PUT api/<MoviessController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return Ok("This is a put request");
        }

        // DELETE api/<MoviessController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok("This is a delete request");
        }
    }
}
