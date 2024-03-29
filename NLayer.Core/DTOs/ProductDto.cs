﻿using NLayer.Core.Enums;
using NLayer.Core.Models;

namespace NLayer.Core.DTOs
{
    public class ProductDto : IBaseDto
    {
        public int ID { get; set; }
        public DataStatus Status { get; set; }
        public string Name { get; set; }

        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}