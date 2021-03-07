using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BudgetIT.Models;

namespace BudgetIT.Controllers
{
    public class NotaFiscalProdutosController : Controller
    {
        private readonly BudgetITContext _context;

        public NotaFiscalProdutosController(BudgetITContext context)
        {
            _context = context;
        }

        // GET: NotaFiscalProdutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.NotaFiscalProduto.ToListAsync());
        }

        // GET: NotaFiscalProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscalProduto = await _context.NotaFiscalProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaFiscalProduto == null)
            {
                return NotFound();
            }

            return View(notaFiscalProduto);
        }

        // GET: NotaFiscalProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NotaFiscalProdutos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Emissao,Vencimento,NrNota,Valor,Oc, Notas")] NotaFiscalProduto notaFiscalProduto)
        {
            if (ModelState.IsValid)
            {
                notaFiscalProduto.Fornecedor = _context.Fornecedor.First();
                _context.Add(notaFiscalProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notaFiscalProduto);
        }

        // GET: NotaFiscalProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscalProduto = await _context.NotaFiscalProduto.FindAsync(id);
            if (notaFiscalProduto == null)
            {
                return NotFound();
            }
            return View(notaFiscalProduto);
        }

        // POST: NotaFiscalProdutos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Emissao,Vencimento,NrNota,Valor,Oc")] NotaFiscalProduto notaFiscalProduto)
        {
            if (id != notaFiscalProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaFiscalProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaFiscalProdutoExists(notaFiscalProduto.Id))
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
            return View(notaFiscalProduto);
        }

        // GET: NotaFiscalProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscalProduto = await _context.NotaFiscalProduto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaFiscalProduto == null)
            {
                return NotFound();
            }

            return View(notaFiscalProduto);
        }

        // POST: NotaFiscalProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaFiscalProduto = await _context.NotaFiscalProduto.FindAsync(id);
            _context.NotaFiscalProduto.Remove(notaFiscalProduto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaFiscalProdutoExists(int id)
        {
            return _context.NotaFiscalProduto.Any(e => e.Id == id);
        }
    }
}
