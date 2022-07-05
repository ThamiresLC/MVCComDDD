using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVCComDDD.Application.Interfaces;
using WebMVCComDDD.Application.ViewsModels;
using WebMVCComDDD.Data;

namespace WebMVCComDDD.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProdutoApplication _produtoApplication;
        public ProdutosController(ApplicationDbContext context, IProdutoApplication produtoApplication)
        {
            _context = context;
            _produtoApplication = produtoApplication;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
          
            return View(_produtoApplication.GetAll());
                          
        }

        public async Task<IActionResult> Details(int id)
        {

            return View(_produtoApplication.GetById(id));
        }


        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            _produtoApplication.Insert(produtoViewModel);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            return View(_produtoApplication.GetById(id));
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdutoViewModel produtoViewModel)
        {

            _produtoApplication.Update(produtoViewModel);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            return View(_produtoApplication.GetById(id));

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _produtoApplication.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
