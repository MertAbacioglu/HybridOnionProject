using Bogus;
using NLayer.Core.Enums;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    public static class FakeData
    {
        static FakeData()
        {
            Init();
        }
        public static void Init()
        {
            #region Fake Category Datas
            int categoryId = 1;
            Faker<Category> categoryFaker = new Faker<Category>()
            .RuleFor(x => x.Name, x => x.Commerce.Categories(1).First())
            .StrictMode(true)
            .RuleFor(x => x.Id, x => categoryId++)
            .RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.UpdatedDate, x => null)
            .RuleFor(x => x.Products, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);

            Categories = categoryFaker.Generate(10);
            #endregion

            #region Fake Product Datas
            int productId = 1;
            Faker<Product> productFaker = new Faker<Product>()
            .StrictMode(false)
            .RuleFor(x => x.Id, x => productId++)
            .RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.Price, x => x.Commerce.Price(1).First())
            .RuleFor(x => x.UpdatedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted)
            .RuleFor(x => x.Stock, x => x.Random.Int(1, 200))
            .RuleFor(d => d.CategoryId, f => f.PickRandom(Categories).Id);
            Products = productFaker.Generate(30);
            #endregion

            #region Fake ProductFeature Datas
            int productFeatureIds = 1;
            Faker<ProductFeature> productFeatureFaker = new Faker<ProductFeature>()
            .StrictMode(false)
            .RuleFor(x => x.Id, x => productFeatureIds++)
            .RuleFor(x => x.Height, x => x.Random.Int(1, 200))
            .RuleFor(x => x.Width, x => x.Random.Int(1, 200))
            .RuleFor(x => x.Color, x => x.Internet.Color())
            .RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.UpdatedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);

            ProductFeatures = productFeatureFaker.Generate(30);
            #endregion

            //#region Fake AppUser Datas
            //int appUserId = 1;
            //Faker<AppUser> appUserFaker = new Faker<AppUser>()
            //.RuleFor(u => u.UserName, x => x.Internet.UserName())
            //.StrictMode(true)
            //.RuleFor(x => x.Id, x => appUserId++)
            //.RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            //.RuleFor(x => x.DeletedDate, x => null)
            //.RuleFor(x => x.UpdatedDate, x => null)
            //.RuleFor(x => x.Status, x => DataStatus.Inserted);

            //AppUsers = appUserFaker.Generate(10);


            //#endregion

            #region Fake AppUserProfile Datas
            //AppUserProfiles.Add(new AppUserProfile
            //{
            //    Id = 1,
            //    Status = DataStatus.Inserted,
            //    Address = "Üsküdar",
            //    CreatedDate = DateTime.Now,
            //    FirstName = "mert",
            //    LastName = "abacıoğlu"


            //});
            //AppUserProfiles.Add(new AppUserProfile
            //{
            //    Id = 2,
            //    Status = DataStatus.Inserted,
            //    Address = "Üsküdar",
            //    CreatedDate = DateTime.Now,
            //    FirstName = "ergün",
            //    LastName = "abacıoğlu"
            //});
            //AppUserProfiles.Add(new AppUserProfile
            //{
            //    Id = 3,
            //    Status = DataStatus.Inserted,
            //    Address = "Üsküdar",
            //    CreatedDate = DateTime.Now,
            //    FirstName = "adalet",
            //    LastName = "abacıoğlu"


            //});
            #endregion

        }
        public static Language lang1 = new Language
        {
            CreatedDate = DateTime.Now,
            LanguageName = "Türkçe",
            Level = 1,
            Status = DataStatus.Inserted,
            Id= 1,

        };
        public static Language lang2 = new Language
        {
            CreatedDate = DateTime.Now,
            LanguageName = "İngilizce",
            Level = 1,
            Status = DataStatus.Inserted,
            Id = 2,

        };
        public static Language lang3 = new Language
        {
            CreatedDate = DateTime.Now,
            LanguageName = "Almanca",
            Level = 1,
            Status = DataStatus.Inserted,
            Id = 3,

        };

        public static List<Category> Categories { get; set; }
        public static List<Product> Products { get; set; }
        public static List<ProductFeature> ProductFeatures { get; set; }
        public static List<AppUser> AppUsers { get; set; } = new List<AppUser>();
        public static List<AppUserProfile> AppUserProfiles { get; set; } = new List<AppUserProfile>();
        public static List<Language> Languages { get; set; } = new List<Language>() { lang1,lang2,lang3};

    }
}
