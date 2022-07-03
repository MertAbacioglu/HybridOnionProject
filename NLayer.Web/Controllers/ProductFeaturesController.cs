using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Services;
using NLayer.Web.Services;

namespace NLayer.Web.Controllers
{
    
    public class ProductFeaturesController : Controller
    {
        private readonly ProductFeatureApiService _productFeatureApiService;
        public ProductFeaturesController(ProductFeatureApiService productFeatureApiService)
        {
            _productFeatureApiService = productFeatureApiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAll()
        {
            var result= await _productFeatureApiService.GetAllAsync();
            JsonResult a = Json(result);
            return  Json(result);
        }

        public async Task<IActionResult> GetById(int id)
        {
            ProductFeatureDto result = await _productFeatureApiService.GetByIdAsync(id);
            return Json(result);
        }
    }
}