using AutoMapper;
using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.Core.Wrappers;
using NLayer.Service.Exceptions;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{


    public class ProductsController : CustomBaseController
    {
        private readonly IProductService _productService;
        private readonly IAppUserLanguageService _appUserLanguageService;

        public ProductsController(IProductService productService, IMapper mapper, IAppUserLanguageService appUserLanguageService)
        {
            _productService = productService;
            _appUserLanguageService = appUserLanguageService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _productService.GetActives());
        }

        [ServiceFilter(typeof(NotFoundFilter<Product,ProductDto>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _productService.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            return CreateActionResult(await _productService.AddAsync(productDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            return CreateActionResult(await _productService.UpdateAsync(productDto));

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            //ProductDto productDto = (await _productService.FindAsync(id)).Data;
            return CreateActionResult(await _productService.RemoveAsync(id));
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {

            return CreateActionResult(await _productService.GetProductsWithCategory());
        }

        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetProductsWitCategoryAndFeatures()
        //{

        //    return CreateActionResult(await _productService.GetProductsWithCategoryAndFeature());
        //}



        [HttpGet("[action]")]
        public async Task<IActionResult> GetAppUserLanguages()
        {
            return CreateActionResult(await _appUserLanguageService.GetActives());
        }
    }
}