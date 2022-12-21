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
    public class KategoriController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public KategoriController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetKategori()
        {
            return Ok(_context.kategorilers.ToList());
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUrun(int id, Kategoriler kategoriler)
        {
            var update = _context.kategorilers.FirstOrDefault(I => I.KategoriID == id);
            update.KategoriAd = kategoriler.KategoriAd;
            update.KategoriAciklama = kategoriler.KategoriAciklama;
            update.UrunID = kategoriler.UrunID;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult DeleteKategori(int id)
        {
            var delete = _context.kategorilers.FirstOrDefault(I => I.KategoriID == id);
            _context.kategorilers.Remove(delete);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Addkategori(Kategoriler kategoriler)
        {
            _context.Add(kategoriler);
            _context.SaveChanges();
            return Created("", kategoriler);
        }

        [HttpGet("{id}")]
        public IActionResult GetKategoriById(int id)
        {
            return Ok(_context.kategorilers.FirstOrDefault(I => I.KategoriID == id));
        }
    }
}
