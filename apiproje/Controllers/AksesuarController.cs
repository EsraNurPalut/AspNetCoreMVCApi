using apiproje.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiproje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AksesuarController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AksesuarController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAksesuar()
        {
            return Ok(_context.aksesuars.ToList());
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAksesuar(int id, Aksesuar aksesuar)
        {
            var update = _context.aksesuars.FirstOrDefault(I => I.AksesuarID == id);
            update.AksesuarAd = aksesuar.AksesuarAd;
            update.AksesuarRenk = aksesuar.AksesuarRenk;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult DeleteAksesuar(int id)
        {
            var delete = _context.aksesuars.FirstOrDefault(I => I.AksesuarID == id);
            _context.aksesuars.Remove(delete);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Addaksesuar(Aksesuar aksesuar)
        {
            _context.Add(aksesuar);
            _context.SaveChanges();
            return Created("",aksesuar);
        }

        [HttpGet("{id}")]
        public IActionResult GetAksesuarById(int id)
        {
            return Ok(_context.aksesuars.FirstOrDefault(I => I.AksesuarID == id));
        }
    }
}
