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
    public class UrunlerController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UrunlerController(ApplicationContext context )
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUrun()
        {
            return Ok(_context.urunlers.ToList());
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUrun(int id,Urunler urunler)
        {
            var update = _context.urunlers.FirstOrDefault(I => I.UrunID == id);
            update.UrunAd = urunler.UrunAd;
            update.UrunAciklama = urunler.UrunAciklama;
            update.UrunYas = urunler.UrunYas;
            update.UrunBeden = urunler.UrunBeden;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult DeleteUrun(int id)
        {
            var delete = _context.urunlers.FirstOrDefault(I => I.UrunID == id);
            _context.urunlers.Remove(delete);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Addurun(Urunler urunler)
        {
            _context.Add(urunler);
            _context.SaveChanges();
            return Created("", urunler);
        }

        [HttpGet("{id}")]
        public IActionResult GetUrunById(int id)
        {
            return Ok(_context.urunlers.FirstOrDefault(I => I.UrunID == id));
        }
    }
}
