﻿using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public  interface IProductService : IService<Product,ProductDto>
    {
        public Task<Response<List<ProductsWithCategoryDto>>> GetProductsWithCategory();
    }
}