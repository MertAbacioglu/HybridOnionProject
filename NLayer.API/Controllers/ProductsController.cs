using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{


    public class ProductsController : CustomBaseController
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository;
        private readonly IAppUserLanguagesService _appUserLanguageService;

        public ProductsController(IProductService productService, IMapper mapper, IAppUserLanguagesService appUserLanguageService, IProductRepository productRepository)
        {
            _productService = productService;
            _appUserLanguageService = appUserLanguageService;
            _productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _appUserLanguageService.GetActives());
        }

        [ServiceFilter(typeof(NotFoundFilter<Product, ProductDto>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return null;
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


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Remove(int id)
        //{
        //    //ProductDto productDto = (await _productService.FindAsync(id)).Data;
        //    return CreateActionResult(await _productService.RemoveAsync(id));
        //}


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

            #region Repository Ile Guncelleme Denemesi
            //Product productRep = _productRepository.FindAsync(1).Result;
            //productRep.Name = "REP UPDATED";
            //_productRepository.Update(productRep);
            #endregion

            #region Servis ile guncelleme denemesi
            //ProductDto toBeUpdated = (await _productService.FindAsync(1)).Data;
            //toBeUpdated.Name = "updated product name fff";

            //return CreateActionResult(await _productService.UpdateAsync(toBeUpdated));
            #endregion

            #region many-to many update deneme
            //AppUserLanguageDto a = new AppUserLanguageDto
            //{
            //    AppUserID = 1,
            //    LanguageID = 2,
            //    CreatedDate = DateTime.Now,
            //    GivenBy = $"yeni level",
            //    Status = DataStatus.Inserted
            //};
            //await _appUserLanguageService.AddAsync(a);
            List<AppUserLanguageDto> existedDtos = (await _appUserLanguageService.Where(x => x.AppUserID == 9, false)).Data.ToList();

            int appUserId = existedDtos[0].AppUserID;


            List<int> eskiIntler = existedDtos.Select(x => x.LanguageID).ToList();


            List<int> newLanguageIds = new List<int> { 3, 4, 5 };

            await _appUserLanguageService.DestroyRangeAsync(existedDtos);

            List<AppUserLanguageDto> dtos = new List<AppUserLanguageDto>();

            dtos.AddRange(newLanguageIds.Select(x => new AppUserLanguageDto
            {
                AppUserID = appUserId,
                LanguageID = x,
                GivenBy = $"yeni level",
                Status = DataStatus.Inserted
            }));

            return CreateActionResult(await _appUserLanguageService.AddRangeAsync(dtos));

            #endregion
        }
    }
}