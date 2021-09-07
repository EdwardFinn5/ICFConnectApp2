using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EmpTypesController : BaseApiController
    {
        private readonly DataContext _context;
        public EmpTypesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpType>>> GetEmpTypes()
        {
            return await _context.EmpTypes.ToListAsync();
        }
    }
}