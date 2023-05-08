using Assignment_2.Data;
using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInfoController : ControllerBase
    {

        [HttpGet("/Search/{id}")]
        public IActionResult Get(string id)
        {
            var options = new DbContextOptionsBuilder<MyDBContext>().UseSqlServer("Data Source=MAS-Desktop;Initial Catalog=CustomerInfo;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;").Options;
            var DB = new MyDBContext(options);
            var customer = DB.CustomerInfo.First(C => C.CustomerId.Equals(id));
            return Ok(customer);
        }

        [HttpPut("/Save/{id}/{name}/{phone}/{address}")]
        public IActionResult Put(string id, string name, string phone, string address)
        {
            var options = new DbContextOptionsBuilder<MyDBContext>().UseSqlServer("Data Source=MAS-Desktop;Initial Catalog=CustomerInfo;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;").Options;
            var DB = new MyDBContext(options);
            var new_customer = new CustomerInfo
            {
                CustomerId = id,
                CustomerName = name,
                CustomerPhoneNo = phone,
                CustomerAddress = address
            };
            DB.CustomerInfo.Add(new_customer);
            DB.SaveChanges();
            return Ok(new_customer);
        }

    }
}
