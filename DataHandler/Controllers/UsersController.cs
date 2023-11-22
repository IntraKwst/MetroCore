using DataHandler.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataHandler.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CustomerDbContext _dbContext;
        public UsersController(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("exists/{username}/{password}")]
        public IActionResult Exists(string username, string password)
        {
            return _dbContext.Users.Any(x => x.Username == username && x.Password == password) ? Ok() : BadRequest();
        }

        [HttpGet("create/{username}/{password}")]
        public async Task<IActionResult> Create(string username, string password)
        {
            _dbContext.Users.Add(new DataAccess.User
            {
                Username = username,
                Password = password
            });
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
