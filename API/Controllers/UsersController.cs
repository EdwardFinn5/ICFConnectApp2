
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        public UsersController(DataContext context,
                            IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }

        // [HttpPost("post-major")]
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostMajor(AppUser appUser)
        {

            // if (UserNameExists(major.MajorName))
            // {
            //     return BadRequest("Major already Exists");
            // }

            _context.Users.Add(appUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = appUser.AppUserId }, appUser);
        }


        // PUT: api/PaymentDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUser appUser)
        {
            if (id != appUser.AppUserId)
            {
                return BadRequest();
            }

            _context.Entry(appUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMajor(int id)
        {
            var appUser = await _context.Users.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            _context.Users.Remove(appUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool AppUserExists(int id)
        {
            return _context.Users.Any(e => e.AppUserId == id);
        }

        [HttpPost("SaveFile")]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(filename);
            }
            catch (Exception)
            {
                return new JsonResult("anonymous.jpg");
            }
        }

    }
}
