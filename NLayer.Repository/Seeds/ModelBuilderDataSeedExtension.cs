using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Enums;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    public static class ModelBuilderDataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            FakeData.Init();
            modelBuilder.Entity<Category>().HasData(FakeData.Categories);
            modelBuilder.Entity<Product>().HasData(FakeData.Products);
            modelBuilder.Entity<ProductFeature>().HasData(FakeData.ProductFeatures);
            modelBuilder.Entity<AppUser>().HasData(FakeData.AppUsers);
            modelBuilder.Entity<AppUserProfile>().HasData(FakeData.AppUserProfiles);
            modelBuilder.Entity<Language>().HasData(FakeData.Languages);

        }
    }
}