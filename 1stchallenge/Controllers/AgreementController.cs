using _1stchallenge.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1stchallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        DasherContext db = new DasherContext();
        // GET: api/<AgreementController>
        [HttpGet]
        public List<Agreement> Get()
        {
            return db.Agreements.ToList();
        }

        // GET api/<AgreementController>/5
        [HttpGet("{id}")]
        public Agreement Get(int id)
        {
            return db.Agreements.Find(id);
        }

        // POST api/<AgreementController>
        [HttpPost]
        public void Post([FromBody] Agreement agreement)
        {
            if(agreement == null)
            {
                BadRequest("the data is null!");
            }
            db.Agreements.Add(agreement);
            db.SaveChanges();
        }

        // PUT api/<AgreementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Agreement agreement)
        {
            db.Agreements.Find(id).EmployeeId = agreement.EmployeeId;
            db.Agreements.Find(id).EmployerId = agreement.EmployerId;
            db.Agreements.Find(id).Status = agreement.Status;
            db.SaveChanges();
        }

        // DELETE api/<AgreementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Agreements.Remove(db.Agreements.Find(id));
        }
    }
}
