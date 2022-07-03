using Microsoft.AspNetCore.Mvc;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Web.Services;
using NLayer.Web.ViewModels;

namespace NLayer.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryApiService _categoryApiService;

        public CategoriesController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _categoryApiService.GetAllAsync());

        }

        [ServiceFilter(typeof(NotFoundFilter<Category>))]
        public async Task<IActionResult> Update(int id)
        {

            return View(await _categoryApiService.GetByIdAsync(id));

        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryVM categoryVM)
        {
            if (ModelState.IsValid)
            {

                await _categoryApiService.UpdateAsync(categoryVM);

                return RedirectToAction(nameof(Index));

            }



            return RedirectToAction(nameof(Index));

        }

        [HttpGet]

        public IActionResult Save()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryVM categoryVM)

        {
            if (ModelState.IsValid)
            {

                await _categoryApiService.SaveAsync(categoryVM);


                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        public async Task<IActionResult> Remove(int id)
        {
            await _categoryApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
