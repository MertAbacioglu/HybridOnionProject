using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Core.Wrappers;

namespace NLayer.Service.Services
{
    public class ProductService : BaseService<Product,ProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IGenericRepository<Product> genericRepository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(genericRepository, unitOfWork, mapper)
        {
            _productRepository = productRepository;
        }


        public async Task<Response<List<ProductsWithCategoryDto>>> GetProductsWithCategory()
        {
            List<Product> products = await _productRepository.GetProductsWitCategory();
            List<ProductsWithCategoryDto> productsDto = _mapper.Map<List<ProductsWithCategoryDto>>(products);
            return Response<List<ProductsWithCategoryDto>>.Success(200, productsDto);

        }
    }
}