using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class MajorsController : BaseApiController
    {
        private readonly DataContext _context;
        public MajorsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Major>>> GetMajors()
        {
            var majors = await _context.Majors.ToListAsync();

            return majors;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Major>> GetMajor(int id)
        {
            return await _context.Majors.FindAsync(id);

        }


        // [HttpPost("post-major")]
        [HttpPost]
        public async Task<ActionResult<Major>> PostMajor(Major major)
        {

            if (MajorNameExists(major.MajorName))
            {
                return BadRequest("Major already Exists");
            }

            _context.Majors.Add(major);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMajor", new { id = major.MajorId }, major);
        }


        // PUT: api/PaymentDetail/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutMajor(int id, Major major)
        // {
        //     if (id != major.MajorId)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(major).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!MajorExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }
        //     return NoContent();
        // }

        // PUT: api/PaymentDetail/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutMajor(int id, Major major)
        {
            // if (id != major.MajorId)
            // {
            //     return BadRequest();
            // }

            _context.Entry(major).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMajor(int id)
        {
            var major = await _context.Majors.FindAsync(id);
            if (major == null)
            {
                return NotFound();
            }

            _context.Majors.Remove(major);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool MajorExists(int id)
        {
            return _context.Majors.Any(e => e.MajorId == id);
        }

        private bool MajorNameExists(string majorName)
        {
            return _context.Majors.Any(x => x.MajorName == majorName.ToLower());
        }

    }
}
