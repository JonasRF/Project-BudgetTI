using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetIT.Controllers
{
    public class NotaFiscalServicosController : Controller
    {
        private readonly NotaFiscalServicoService _notaFiscalServicoService;

        public NotaFiscalServicosController(NotaFiscalServicoService notaFiscalServicoService)
        {
            _notaFiscalServicoService = notaFiscalServicoService;
        }

        public IActionResult Index()
        {
            var obj = _notaFiscalServicoService.FindAll();
            return View(obj);
        }
    }
}