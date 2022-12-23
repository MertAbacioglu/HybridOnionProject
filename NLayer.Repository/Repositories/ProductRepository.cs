using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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

            return await _context.Products.Where(x => x.Status != DataStatus.Deleted).Include(x => x.Category).Where(x => x.Category.Status != DataStatus.Deleted).ToListAsync();
        }

        public async Task<List<Product>> GetProductsWithCategoryAndFeature()
        {

            //return await _context.Products.Where(x => x.Status != DataStatus.Deleted).Include(x => x.ProductFeature).Where(x => x.Status != DataStatus.Deleted).Include(x => x.Category).Where(x=>x.Category.Status!=DataStatus.Deleted).Include(x=>x.ProductFeature).Where(x => x.ProductFeature.Status != DataStatus.Deleted).ToListAsync();
            IQueryable<Product> aa = _context.Products.Where(x => x.Status != DataStatus.Deleted).Include(x => x.Category).Where(x => x.Category.Status != DataStatus.Deleted);

            IQueryable<Product> aas = _context.Products.Include(x => x.Category);
        }

    }
}
