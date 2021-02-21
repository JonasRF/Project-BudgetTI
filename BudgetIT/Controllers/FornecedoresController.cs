using Microsoft.AspNetCore.Mvc;
using BudgetIT.Services;
using BudgetIT.Models;
using BudgetIT.Services.Exception;

namespace BudgetIT.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly FornecedorService _Fornecedorservice;

        public FornecedoresController(FornecedorService Fornecedorservice)
        {
            _Fornecedorservice = Fornecedorservice;
        }

        public IActionResult Index()
        {
            var list = _Fornecedorservice.FindAll();
            return View(list);
        }

        //MÉTODO GET
        public IActionResult Create()
        {
            return View();
        }

        //MÉTODO POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fornecedor fornecedor)
        {
            _Fornecedorservice.Insert(fornecedor);
            return RedirectToAction(nameof(Index));
        }

        //Metodo Get da função Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _Fornecedorservice.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Método post da função Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _Fornecedorservice.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Método get da função Edit
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                NotFound();
            }
           var obj = _Fornecedorservice.FindById(id.Value);
            if(obj == null)
            {
                NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Fornecedor fornecedor)
        {
            if(id != fornecedor.Id)
            {
                return NotFound();
            }
            try
            {
                _Fornecedorservice.Update(fornecedor);
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