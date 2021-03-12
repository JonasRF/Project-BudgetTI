using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BudgetIT.Models;
using BudgetIT.Services;

namespace BudgetIT.Controllers
{
    public class NotaFiscalProdutosController : Controller
    {
        private readonly NotaFiscalProdutoService _NotaFiscalProdutoService;

        public NotaFiscalProdutosController(NotaFiscalProdutoService NotaFiscalProdutoService)
        {
            _NotaFiscalProdutoService = NotaFiscalProdutoService;
        }


        // GET: NotaFiscalProdutos
        public IActionResult Index()
        {
           var list = _NotaFiscalProdutoService.FindAll();
            return View(list);
        }


        // GET: NotaFiscalProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NotaFiscalProdutos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NotaFiscalProduto notaFiscalProduto)
        {
            _NotaFiscalProdutoService.Insert(notaFiscalProduto);
            return RedirectToAction(nameof(Index));
        }


    }
}
