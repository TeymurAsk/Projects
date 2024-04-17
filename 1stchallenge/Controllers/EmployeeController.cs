using _1stchallenge.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1stchallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        DasherContext db = new DasherContext();
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            if(employee == null)
            {
                BadRequest("Item data is null");
            }
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            db.Employees.Find(id).Name = employee.Name;
            db.Employees.Find(id).Surname = employee.Surname;
            db.Employees.Find(id).JobTitle = employee.JobTitle;
            db.Employees.Find(id).Price = employee.Price;
            db.Employees.Find(id).Availability = employee.Availability;
            db.Employees.Find(id).Bio = employee.Bio;
            db.Employees.Find(id).Rating = employee.Rating;
            db.Employees.Find(id).Password = employee.Password;
            db.SaveChanges();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Employees.Remove(db.Employees.Find(id));
            db.SaveChanges();
        }
    }
}
