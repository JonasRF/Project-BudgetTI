using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Models;
using BudgetIT.Models.viewModels;
using BudgetIT.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetIT.Controllers
{
    public class NotaFiscalServicosController : Controller
    {
        private readonly NotaFiscalServicoService _notaFiscalServicoService;
        private readonly FornecedorService _fornecedorService;

        public NotaFiscalServicosController(NotaFiscalServicoService notaFiscalServicoService, FornecedorService fornecedorService)
        {
            _notaFiscalServicoService = notaFiscalServicoService;
            _fornecedorService = fornecedorService;
        }

        public IActionResult Index()
        {
            var obj = _notaFiscalServicoService.FindAll();
            return View(obj);
        }

        //Metodo GET NOTAFISCALSERVICO
        public IActionResult Create()
        {
            var fornecedores = _fornecedorService.FindAll();
            var viewModel = new NotaFiscalServicoViewModel { Fornecedor = fornecedores };
            return View(viewModel);
        }

        //metodo POST NOTAFISCALSERVICO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NotaFiscalServico NotaFiscalServico)
        {
            _notaFiscalServicoService.Insert(NotaFiscalServico);
            return RedirectToAction(nameof(Index));
        }
        
    }
}