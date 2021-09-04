using MobileRepairMT.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MobileRepairMT.Controllers
{
    [Route("api/examples")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/examples/user
        [HttpGet("user"), Authorize]
        public IActionResult GetCurrentUser()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpGet("user")]
        public IActionResult GetAllUser()
        {
            var userId = User.FindAll("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
