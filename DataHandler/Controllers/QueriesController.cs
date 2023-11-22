using DataHandler.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace DataHandler.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        private readonly CustomerDbContext _dbContext;
        public QueriesController(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("all/{pageNo}/{pageSize}")]
        public IActionResult Get(int pageNo, int pageSize)
        {
            return Ok(_dbContext.Customers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList());
        }

        [HttpGet("allInvoices/{id}")]
        public IActionResult AllInvoices(int id)
        {
            var invoices = _dbContext.CustomerInvoices.Where(x => x.CusCode == id).ToList();
            return Ok(invoices);
        }

        [HttpGet("customerCount")]
        public IActionResult GetCount(int pageNo, int pageSize)
        {
            return Ok(_dbContext.Customers.Count());
        }

        [HttpGet("customer/{id}")]
        public IActionResult Get(int id)
        {
            //avoid meddling with entity tracking
            var customer = new Customer(_dbContext.Customers.FirstOrDefault(x => x.CusCode == id))
            {
                CustomerInvoices = _dbContext.CustomerInvoices.Where(x => x.CusCode == id).ToList()
            };
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
