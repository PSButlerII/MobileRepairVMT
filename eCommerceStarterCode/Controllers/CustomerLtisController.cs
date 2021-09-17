using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileRepairMT.Data;
using MobileRepairMT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileRepairMT.Controllers
{
    [Route("api/customerLTI")]
    [ApiController]
    public class CustomerLtisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CustomerLtisController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<CustomerLtisController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            {
                var customerLtis = _context.CustomerLtis;
                return Ok(customerLtis);
            }
        }

        // GET api/<CustomerLtisController>/5
        [HttpGet("{CustomerLtiId}")]
        public IActionResult GetLtiById(int CustomerLtiId)
        {
            var customerLti = _context.CustomerLtis.FirstOrDefault(cu => cu.CustomerLtiId == CustomerLtiId);
            if (customerLti == null)
            {
                return NotFound();
            }
            return Ok(customerLti);
        }
        // POST api/<CustomerLtisController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] CustomerLti value)
        {
            _context.CustomerLtis.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<CustomerLtisController>/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put([FromBody] CustomerLti value)
        {
            _context.CustomerLtis.Update(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        
        

        // DELETE api/<CustomerLtisController>/5
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _context.CustomerLtis.Find(id);
            _context.CustomerLtis.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
