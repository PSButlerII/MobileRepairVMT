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

    [Route("api/Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Start requests here.
        // get all Product 
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var product = _context.Products;
            return Ok(product);
        }
        // get Product by id TESTED
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        // post or "add" new product to database TESTED
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        

        // delete product by id TESTED 
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }


}

