using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<IActionResult> Get() 
        { 
            return Ok( await _context.Users.ToListAsync()); 
        }
    }
}
