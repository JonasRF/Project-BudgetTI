using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetIT.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ServicoService _ServicoService;

        public ServicosController(ServicoService ServicoService)
        {
            _ServicoService = ServicoService;
        }

        public IActionResult Index()
        {
            var list = _ServicoService.FindAll();
            return View(list);
        }
    }
}