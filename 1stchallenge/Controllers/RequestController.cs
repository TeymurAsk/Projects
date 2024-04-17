using _1stchallenge.Components.Pages;
using _1stchallenge.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1stchallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        DasherContext db = new DasherContext();
        // GET: api/<RequestController>
        [HttpGet]
        public List<Request> Get()
        {
            return db.Requests.ToList();
        }

        // GET api/<RequestController>/5
        [HttpGet("{id}")]
        public Request Get(int id)
        {
            return db.Requests.Find(id);
        }

        // POST api/<RequestController>
        [HttpPost]
        public void Post([FromBody] Request request)
        {
            if (request == null)
            {
                BadRequest("the data is null");
            }
            db.Requests.Add(request);
            db.SaveChanges();
        }

        // PUT api/<RequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Request request)
        {
            db.Requests.Find(id).EmployeeId = request.EmployeeId;
            db.Requests.Find(id).EmployerId = request.EmployerId;
            db.SaveChanges();
        }

        // DELETE api/<RequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Requests.Remove(db.Requests.Find(id));
            db.SaveChanges();
        }
    }
}
