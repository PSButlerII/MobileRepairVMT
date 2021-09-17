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
    [Route("api/EmployeeLTI")]
    [ApiController]
    public class EmployeeLtisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeLtisController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<EmployeeLtisController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            {
                var employeeLtis = _context.EmployeeLtis;
                return Ok(employeeLtis);
            }
        }

        // GET api/<EmployeeLtisController>/5
        [HttpGet("{LtiId}")]
        public IActionResult GetLTIById(int LtiId)
        {
            var employeeLtis = _context.EmployeeLtis.FirstOrDefault(eu => eu.LtiId == LtiId);
            if (employeeLtis == null)
            {
                return NotFound();
            }
            return Ok(employeeLtis);
        }
        // POST api/<EmployeeLtisController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] EmployeeLti value)
        {
            _context.EmployeeLtis.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<EmployeeLtisController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] EmployeeLti value)
        {
            _context.EmployeeLtis.Update(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }



        // DELETE api/<EmployeeLtisController>/5
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var LtiGone = _context.EmployeeLtis.Find(id);
            _context.EmployeeLtis.Remove(LtiGone);
            _context.SaveChanges();
            return Ok(LtiGone);
        }
    }
}
