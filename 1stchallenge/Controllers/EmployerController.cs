using _1stchallenge.Components.Pages;
using _1stchallenge.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1stchallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        DasherContext db = new DasherContext();
        // GET: api/<EmployerController>
        [HttpGet]
        public List<Employer> Get()
        {
            return db.Employers.ToList();
        }

        // GET api/<EmployerController>/5
        [HttpGet("{id}")]
        public Employer Get(int id)
        {
            return db.Employers.Find(id);
        }

        // POST api/<EmployerController>
        [HttpPost]
        public void Post([FromBody] Employer employer)
        {
            if(employer == null)
            {
                BadRequest("the data is null");
            }
            db.Employers.Add(employer);
            db.SaveChanges();
        }

        // PUT api/<EmployerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employer employer)
        {
            db.Employers.Find(id).CompanyName = employer.CompanyName;
            db.Employers.Find(id).Name = employer.Name;
            db.Employers.Find(id).Saved = employer.Saved;
            db.Employers.Find(id).Surname = employer.Surname;
            db.Employers.Find(id).Password = employer.Password;
            db.SaveChanges();
        }

        // DELETE api/<EmployerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Employers.Remove(db.Employers.Find(id));
            db.SaveChanges();
        }
    }
}
