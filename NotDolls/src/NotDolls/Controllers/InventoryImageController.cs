using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using NotDolls.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NotDolls.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowDevelopmentEnvironment")]
    public class InventoryImageController : Controller
    {
        private NotDollsContext _context;

        public InventoryImageController(NotDollsContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IQueryable<object> images = from i in _context.InventoryImage
                                       select i;

            if (images == null)
            {
                return NotFound();
            }

            return Ok(images);
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetImage")]
        public IActionResult Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InventoryImage image = _context.InventoryImage.Single(i => i.InventoryImageId == id);

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] InventoryImage image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InventoryImage.Add(image);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InventoryImageExists(image.InventoryImageId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetImage", new { id = image.InventoryImageId }, image);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] InventoryImage image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != image.InventoryImageId)
            {
                return BadRequest();
            }

            _context.Entry(image).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryImageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return new StatusCodeResult(StatusCodes.Status204NoContent);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InventoryImage image = _context.InventoryImage.Single(i => i.InventoryImageId == id);
            if (image == null)
            {
                return NotFound();
            }

            _context.InventoryImage.Remove(image);
            _context.SaveChanges();

            return Ok(image);
        }

        private bool InventoryImageExists(int id)
        {
            return _context.InventoryImage.Count(e => e.InventoryImageId == id) > 0;
        }
    }
}
