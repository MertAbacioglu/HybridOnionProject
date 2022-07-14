using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }



        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            List<Product> products = await _productRepository.GetProductsWitCategory();
            List<ProductWithCategoryDto> productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);

        }

        public async Task<CustomResponseDto<List<ProductWithCategoryAndFeatureDto>>> GetProductsWithCategoryAndFeature()
        {
            List<Product> products = await _productRepository.GetProductsWithCategoryAndFeature();
            List<ProductWithCategoryAndFeatureDto> productsDto = _mapper.Map<List<ProductWithCategoryAndFeatureDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryAndFeatureDto>>.Success(200, productsDto);
        }
    }
}