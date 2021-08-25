using MobileRepairMT.Data;
using MobileRepairMT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MobileRepairMT.Controllers
{

    [Route("api/ShopService")]
    [ApiController]
    public class ShopServiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShopServiceController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Start requests here.
        // get all ShopService 
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var ShopService = _context.ShopServices;
            return Ok(ShopService);
        }
        // get ShopService by id TESTED
        [HttpGet("{id}")]
        public IActionResult GetShopServiceById(int id)
        {
            var ShopService = _context.ShopServices.Find(id);
            if (ShopService == null)
            {
                return NotFound();
            }
            return Ok(ShopService);
        }

        // post or "add" new ShopService to database TESTED
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] ShopService value)
        {
           
            _context.ShopServices.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        // update ShopServices by id TESTED

        // delete ShopServices by id TESTED 
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var ShopService = _context.ShopServices.Find(id);
            _context.ShopServices.Remove(ShopService);
            _context.SaveChanges();
            return Ok(ShopService);
        }

    }


}

