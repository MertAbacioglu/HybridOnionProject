using Microsoft.EntityFrameworkCore;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public static class ModelBuilderDataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Category { Id = 2, Name = "Mobile Phone", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Category { Id = 3, Name = "Vinly", CreatedDate = DateTime.Now, Status = DataStatus.Inserted }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "MSI CX-61", CategoryId = 1, Price = 100, Stock = 5, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 2, Name = "Lenov Z580", CategoryId = 1, Price = 200, Stock = 15, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 3, Name = "HP Probook", CategoryId = 1, Price = 300, Stock = 25, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 4, Name = "IPhone 11", CategoryId = 2, Price = 400, Stock = 35, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 5, Name = "Galaxy Core", CategoryId = 2, Price = 500, Stock = 45, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 6, Name = "Metallica Load", CategoryId = 3, Price = 600, Stock = 55, CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new Product { Id = 7, Name = "ELOY Down", CategoryId = 3, Price = 700, Stock = 65, CreatedDate = DateTime.Now, Status = DataStatus.Inserted }
                );

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature { Id = 1, Height = 11,Width=21, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 2, Height = 12,Width=22, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 3, Height = 13,Width=23, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 4, Height = 14,Width=24, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 5, Height = 15,Width=25, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 6, Height = 16,Width=26, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted },
                new ProductFeature { Id = 7, Height = 17,Width=27, Color="Blue", CreatedDate = DateTime.Now, Status = DataStatus.Inserted }
                );



        }
    }
}