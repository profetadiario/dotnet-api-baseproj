using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Boilerplate.Core.Models;
using Boilerplate.Infra.Context;
using Boilerplate.Application.Services;
using Boilerplate.Application.Interfaces;
using Boilerplate.Application.ViewModel.Entities;

namespace Boilerplate.Presentation.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorService _service;

        public FornecedoresController(IFornecedorService service)
        {
            _service = service;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetFornecedoresAsync()); //_context.Fornecedor.ToListAsync());
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
                return NotFound();

            var fornecedorViewModel = await _service.GetFornecedorByIdAsync(id);

            if (fornecedorViewModel == null)
                return NotFound();

            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Vertical,Link,MantemHistorico,Logo,Id")] FornecedorViewModel fornecedorViewModel)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateViewModel(fornecedorViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Edit/5
        //public async Task<IActionResult> Edit(Guid id)
        //{
        //    if (id == null)
        //        return NotFound();


        //    var fornecedorViewModel = await _service.(id);

        //    if (fornecedor == null)
        //        return NotFound();

        //    return View(fornecedor);
        //}

        // POST: Fornecedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Vertical,Link,MantemHistorico,Logo,Id")] FornecedorViewModel fornecedorViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.UpdateViewModel(fornecedorViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedorViewModel.Id))
                        return NotFound();

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
                return NotFound();

            var fornecedor = await _service.GetFornecedorByIdAsync(id);

            await _service.DeleteViewModel(fornecedor);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var fornecedor = await _context.Fornecedor.FindAsync(id);
        //    _context.Fornecedor.Remove(fornecedor);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool FornecedorExists(Guid id)
        {
            var result = _service.GetFornecedorByIdAsync(id);

            return result == null ? false : true;
        }
    }
}
