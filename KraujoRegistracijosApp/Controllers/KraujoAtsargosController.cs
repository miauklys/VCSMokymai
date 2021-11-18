using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KraujoRegistracijosApp.Data;
using KraujoRegistracijosApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace KraujoRegistracijosApp.Controllers
{
    public class KraujoAtsargosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KraujoAtsargosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult ParodoLikucius(double likuciai)
        //{
        //    RodoPaieskosRezultatus 
        //}

        // GET: KraujoAtsargos
        public async Task<IActionResult> Index()
        {
            var kraujoGrupes = from ka in _context.KraujoAtsargos
                               group ka by ka.KraujoGrupe into krg
                               select new KraujoAtsargos { 
                                   Atsargos = krg.Sum(s => s.Atsargos), 
                                   KraujoGrupe = krg.Key };

            return View(kraujoGrupes);
        }

        // GET: KraujoAtsargos/Paieska
        public async Task<IActionResult> Paieska()
        {
            return View();
        }

        // PoST: KraujoAtsargos/RodoPaieskosRezultatus
        public async Task<IActionResult> RodoPaieskosRezultatus(string KraujoAtsarguPaieska)
        {
            //sum = 0;
            //foreach(var blood in KraujoAtsarguPaieska)
            //{
            //    sum = KraujoAtsarguPaieska.Sum(x => Convert.ToInt32(x));
            //}
            return View("Index", await _context.KraujoAtsargos.
                Where( j =>j.KraujoGrupe.Contains(KraujoAtsarguPaieska)).ToListAsync());
        }

        // GET: KraujoAtsargos/Details/5
        [HttpGet("KraujoAtsargos/Likutis/{kraujoGrupe}")]
        public async Task<IActionResult> Details(string kraujoGrupe)
        {
            if (kraujoGrupe == null)
            {
                return NotFound();
            }

            var kraujoAtsargos = (from ka in _context.KraujoAtsargos
                                 where ka.KraujoGrupe == kraujoGrupe
                                 group ka by ka.KraujoGrupe into krg
                                 select new KraujoAtsargos
                                 {
                                     Atsargos = krg.Sum(s => s.Atsargos),
                                     KraujoGrupe = krg.Key
                                 })
                                 .ToList()
                                 .FirstOrDefault();

            if (kraujoAtsargos == null)
            {
                return NotFound();
            }

            return View(kraujoAtsargos);
        }

        // GET: KraujoAtsargos/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: KraujoAtsargos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KraujoGrupe,Atsargos")] KraujoAtsargos kraujoAtsargos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kraujoAtsargos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kraujoAtsargos);
        }

        // GET: KraujoAtsargos/Edit/5
        //[Authorize]
        [HttpGet("KraujoAtsargos/Grupe/{kraujoGrupe}")]
        public async Task<IActionResult> Edit(string kraujoGrupe)
        {
            if (kraujoGrupe == null)
            {
                return NotFound();
            }

            var kraujoAtsargos = _context.KraujoAtsargos
                .Where(ka => ka.KraujoGrupe == kraujoGrupe)
                .ToList();
            if (kraujoAtsargos == null)
            {
                return NotFound();
            }

            return View(kraujoAtsargos);
        }

        // POST: KraujoAtsargos/Edit/5
        [Authorize]
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("KraujoAtsargos/Grupe/{kraujoGrupe}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(/*[Bind("Id,KraujoGrupe,Atsargos")] */List<KraujoAtsargos> kraujoAtsargos, string kraujoGrupe)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.UpdateRange(kraujoAtsargos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kraujoAtsargos);
        }

        // GET: KraujoAtsargos/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kraujoAtsargos = await _context.KraujoAtsargos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kraujoAtsargos == null)
            {
                return NotFound();
            }

            return View(kraujoAtsargos);
        }

        // POST: KraujoAtsargos/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kraujoAtsargos = await _context.KraujoAtsargos.FindAsync(id);
            _context.KraujoAtsargos.Remove(kraujoAtsargos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RezervuotiKraujoAtsargas([Bind("Atsargos,KraujoGrupe")]KraujoAtsargos kraujoAtsargos)
        {
            var senosKraujoAtsargos = _context.KraujoAtsargos
                .Where(ka => ka.KraujoGrupe == kraujoAtsargos.KraujoGrupe)
                .ToList();
            var atnaujintosKraujoAtsargos = new List<KraujoAtsargos>();

            while (kraujoAtsargos.Atsargos != 0)
            {
                foreach (var ka in senosKraujoAtsargos)
                {
                    var atnaujintasKiekis = ka.Atsargos - kraujoAtsargos.Atsargos;
                    var atnaujintosAtsargos = new KraujoAtsargos
                    {
                        Atsargos = atnaujintasKiekis,
                        Id = ka.Id,
                        KraujoGrupe = ka.KraujoGrupe
                    };
                    atnaujintosKraujoAtsargos.Add(atnaujintosAtsargos);
                    if (atnaujintasKiekis >= 0)
                    {
                        kraujoAtsargos.Atsargos = 0;
                        break;
                    }
                }
            }

            _context.UpdateRange(atnaujintosKraujoAtsargos);
            _context.SaveChanges();

            return Redirect("Home/Index");
        }

        private bool KraujoAtsargosExists(int id)
        {
            return _context.KraujoAtsargos.Any(e => e.Id == id);
        }
    }
}
