using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BudgetIT.Models;
using BudgetIT.Services;
using BudgetIT.Services.Exception;
using BudgetIT.Models.viewModels;

namespace BudgetIT.Controllers
{
    public class NotaFiscalProdutosController : Controller
    {
        private readonly NotaFiscalProdutoService _NotaFiscalProdutoService;
        private readonly FornecedorService _FornecedorService;

        public NotaFiscalProdutosController(NotaFiscalProdutoService NotaFiscalProdutoService, FornecedorService FornecedorService)
        {
            _NotaFiscalProdutoService = NotaFiscalProdutoService;
            _FornecedorService = FornecedorService;
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
            var fornecedores = _FornecedorService.FindAll();
            var viewModel = new NotaFiscalProdutoViewModel { Fornecedor = fornecedores };
            return View(viewModel);
        }

        // POST: NotaFiscalProdutos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NotaFiscalProduto notaFiscalProduto)
        {
            _NotaFiscalProdutoService.Insert(notaFiscalProduto);
            return RedirectToAction(nameof(Index));
        }

        //GET: NotaFicalProdutos/Edit
        public IActionResult Edit(int? id)
        {
            if( id == null)
            {
                NotFound();
            }
               var obj =  _NotaFiscalProdutoService.FindById(id.Value);
            if(obj == null)
            {
                BadRequest();
            }
            List<Fornecedor> fornecedores = _FornecedorService.FindAll();
            NotaFiscalProdutoViewModel viewModel = new NotaFiscalProdutoViewModel { NotaFiscalProduto = obj, Fornecedor = fornecedores };
            return View(viewModel);
        }

        //POST: NotaFiscalProduto/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, NotaFiscalProduto notaFiscalProduto)
        {
            if(id != notaFiscalProduto.Id)
            {
               return NotFound();
            }
            try
            {
                _NotaFiscalProdutoService.Update(notaFiscalProduto);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
               return NotFound();
            }
            catch (Services.Exception.DbUpdateConcurrencyException)
            {
                return BadRequest();
            }
        }

        //GET: NotaFsicalProduto/Delete
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
               return NotFound();
            }

            var obj = _NotaFiscalProdutoService.FindById(id.Value);

            if(obj == null)
            {
                return NotFound();
            }
               var fornecedores = _FornecedorService.FindAll();
               var viewModel = new NotaFiscalProdutoViewModel { NotaFiscalProduto = obj, Fornecedor = fornecedores };
            return View(viewModel);
        }

        //POST: NotaFiscalproduto/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _NotaFiscalProdutoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        //GET: NotaFiscalproduto/Details
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _NotaFiscalProdutoService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            var fornecedores = _FornecedorService.FindAll();
            var viewModel = new NotaFiscalProdutoViewModel { NotaFiscalProduto = obj, Fornecedor = fornecedores };
            return View(viewModel);
        }
    }
}
