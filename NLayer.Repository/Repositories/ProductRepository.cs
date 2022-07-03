using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWitCategory()
        {

            //return await _context.Products.Include(x => x.Category).ToListAsync();
            return await _context.Products.Where(x => x.Status != DataStatus.Deleted).Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Product>> GetProductsWitCategoryAndFeatures()
        {
            return await _context.Products.Where(x => x.Status != DataStatus.Deleted).Include(x => x.ProductFeature).Include(x => x.Category).ToListAsync();

        }

    }
}
