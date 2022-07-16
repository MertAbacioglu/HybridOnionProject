using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core;
using NLayer.Core.Models;
using NLayer.Core.DTOs;
using NLayer.Core.Services;
using NLayer.Web.Services;
using NLayer.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using NLayer.Core.Enums;

namespace NLayer.Web.Controllers
{
    [Authorize(Roles = "Admin")]

    public class ProductsController : Controller
    {

        private readonly ProductApiService _productApiService;
        private readonly CategoryApiService _categoryApiService;

        public ProductsController(CategoryApiService categoryApiService, ProductApiService productApiService)
        {
            _categoryApiService = categoryApiService;
            _productApiService = productApiService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _productApiService.GetProductsWithCategoryAsync());
        }


        public async Task<IActionResult> Save()
        {


            CategoryListVM categoryListVM = await _categoryApiService.GetAllAsync();
            return View(new ProductAddVM
            {
                CategorySelectList = categoryListVM.CategorySelectList,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductAddVM productAddVM)

        {
            if (ModelState.IsValid)
            {

                await _productApiService.SaveAsync(productAddVM);


                return RedirectToAction(nameof(Index));
            }

            CategoryListVM categoryListVM = await _categoryApiService.GetAllAsync();
            return View(new ProductAddVM
            {
                CategorySelectList = categoryListVM.CategorySelectList,
            });
        }
        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        public async Task<IActionResult> Update(int id)
        {
            ProductAddVM productVM = await _productApiService.GetByIdAsync(id);


            CategoryListVM categoriesDto = await _categoryApiService.GetAllAsync();


            return View(productVM);

        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductAddVM productAddVM)
        {
            if (ModelState.IsValid)
            {

                await _productApiService.UpdateAsync(productAddVM);

                return RedirectToAction(nameof(Index));

            }

            return View(productAddVM);

        }


        public async Task<IActionResult> Remove(int id)
        {
            await _productApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ProductList()
        {
            return View();
        }

    }
}
