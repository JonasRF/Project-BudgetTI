using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BudgetIT.Models;

namespace BudgetIT.Controllers
{
    public class BudgetRecordsController : Controller
    {
        private readonly BudgetRecordService _budgetRecordService;

        public BudgetRecordsController(BudgetRecordService budgetRecordService)
        {
            _budgetRecordService = budgetRecordService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var result = _budgetRecordService.FindById(minDate, maxDate);
            
            var result1 = _budgetRecordService.FindById1(minDate, maxDate);

           
            return View(result);
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}