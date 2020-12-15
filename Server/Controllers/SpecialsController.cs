using BlazingPizza.Server.Models;
using BlazingPizza.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpecialsController : ControllerBase
    {
        private readonly PizzaStoreConext _context;

        public SpecialsController(PizzaStoreConext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaSpecial>>> GetSpecials()
        {
            return await _context.Specials
                .OrderByDescending(s => s.BasePrice).ToListAsync();
        }
    }
}
