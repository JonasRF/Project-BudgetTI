using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Models;
using BudgetIT.Models.viewModels;
using BudgetIT.Services;
using BudgetIT.Services.Exception;
using Microsoft.AspNetCore.Mvc;

namespace BudgetIT.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ServicoService _ServicoService;
        private readonly FornecedorService _FornecedorService;

        public ServicosController(ServicoService ServicoService, FornecedorService FornecedorService)
        {
            _ServicoService = ServicoService;
            _FornecedorService = FornecedorService;
        }

        public IActionResult Index()
        {
            var list = _ServicoService.FindAll();
            return View(list);
        }

        //Metodo Get Serviço 
        public IActionResult Create()
        {
            var fornecedores = _FornecedorService.FindAll();
            var viewModel = new ServicoViewModel { Fornecedor = fornecedores };
            return View(viewModel);
        }

        //Metodo post Servico
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servico Servico)
        {
            _ServicoService.Insert(Servico);
            return RedirectToAction(nameof(Index));
        }

        //Metodo get Servico
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                NotFound();
            }
            var obj = _ServicoService.FindById(id.Value);
            if(obj == null)
            {
                NotFound();
            }
            return View(obj);
        }

        //Metodo post Servico
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Servico servico)
        {
            if(id != servico.Id)
            {
                return NotFound();
            }
            try
            {
                _ServicoService.Update(servico);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
               return NotFound();
            }
            catch (DbUpdateConcurrencyException)
            {
               return BadRequest();
            }


        }
    
    }
}