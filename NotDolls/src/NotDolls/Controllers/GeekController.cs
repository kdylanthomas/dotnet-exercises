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
    public class GeekController : Controller
    {
        private NotDollsContext _context;

        public GeekController(NotDollsContext context)
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

            IQueryable<object> geeks = from g in _context.Geek
                                           select g;

            if (geeks == null)
            {
                return NotFound();
            }

            return Ok(geeks);
        }

        // GET api/values/5
        [HttpGet("{id}", Name="GetGeek")]
        public IActionResult Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Geek geek = _context.Geek.Single(m => m.GeekId == id);

            if (geek == null)
            {
                return NotFound();
            }

            return Ok(geek);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Geek geek)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Geek.Add(geek);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GeekExists(geek.GeekId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetGeek", new { id = geek.GeekId }, geek);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Geek geek)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != geek.GeekId)
            {
                return BadRequest();
            }

            _context.Entry(geek).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeekExists(id))
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

            Geek geek = _context.Geek.Single(g => g.GeekId == id);
            if (geek == null)
            {
                return NotFound();
            }

            _context.Geek.Remove(geek);
            _context.SaveChanges();

            return Ok(geek);
        }

        private bool GeekExists(int id)
        {
            return _context.Geek.Count(e => e.GeekId == id) > 0;
        }
    }
}
