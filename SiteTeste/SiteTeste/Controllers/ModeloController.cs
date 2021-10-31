using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteTeste.Data;
using SiteTeste.Models;

namespace SiteTeste.Controllers
{
    public class ModeloController : Controller
    {
        private readonly AppDbContext _context;

        public ModeloController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Modelos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }
            
            public IActionResult Create()
            {
                return View();
            }
            
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,Id_fornecedor,Nome,CodReferencia,Cor,Tamanho")] Modelo modelo)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(modelo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(modelo);
            }

            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var modelo = await _context.Modelos.FindAsync(id);
                if (modelo == null)
                {
                    return NotFound();
                }
                return View(modelo);
            }
            
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Id_fornecedor,Nome,CodReferencia,Cor,Tamanho")] Modelo modelo)
            {
                if (id != modelo.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(modelo);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ModeloExists(modelo.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(modelo);
            }
            
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var modelo = await _context.Modelos
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (modelo == null)
                {
                    return NotFound();
                }

                return View(modelo);
            }
            
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var modelo = await _context.Modelos.FindAsync(id);
                _context.Modelos.Remove(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool ModeloExists(int id)
            {
                return _context.Modelos.Any(e => e.Id == id);
            }
    }
}





