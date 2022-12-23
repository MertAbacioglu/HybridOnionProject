using Bogus;
using Bogus.DataSets;
using NLayer.Core.Enums;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    /// <summary>
    /// This class includes methods that use Bogus Library to create fake datas.
    /// </summary>
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

            #region Fake AppUser Datas
            int appUserId = 1;
            Faker<AppUser> appUserFaker = new Faker<AppUser>()
            .RuleFor(u => u.UserName, x => x.Internet.UserName())
            .StrictMode(false)
            .RuleFor(x => x.Id, x => appUserId++)
            .RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.UpdatedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);

            AppUsers = appUserFaker.Generate(10);

            #endregion

            #region Fake AppUserProfile Datas
            int appUserProfileId = 1;
            Faker<AppUserProfile> appUserProfileFaker = new Faker<AppUserProfile>()
            .StrictMode(false)
            .RuleFor(u => u.FirstName, x => x.Person.FirstName)
            .RuleFor(u => u.LastName, x => x.Person.LastName)
            .RuleFor(x => x.Id, x => appUserProfileId++)
            .RuleFor(x => x.CreatedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.UpdatedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);

            AppUserProfiles = appUserProfileFaker.Generate(10);
            #endregion

            #region Fake(Custom) Language Datas
            Languages = new List<Language>()
            {
                new Language { Id = 1,CreatedDate = DateTime.Now,LanguageName = "Turkish",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 2,CreatedDate = DateTime.Now,LanguageName = "German",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 3,CreatedDate = DateTime.Now,LanguageName = "English",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 4,CreatedDate = DateTime.Now,LanguageName = "Korean",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 5,CreatedDate = DateTime.Now,LanguageName = "Finnish",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 6,CreatedDate = DateTime.Now,LanguageName = "French",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 7,CreatedDate = DateTime.Now,LanguageName = "Czech",Level = 1,Status = DataStatus.Inserted},
                new Language { Id = 8,CreatedDate = DateTime.Now,LanguageName = "Spanish ",Level = 1,Status = DataStatus.Inserted}
            };
            #endregion

            #region Fake AppUserLanguage Datas
            for (int i = 1; i <= AppUsers.Count; i++)
            {
                for (int j = 1; j <= Languages.Count; j++)
                {
                    AppUserLanguage appUserLanguage = new AppUserLanguage
                    {
                        AppUserID = i, LanguageID = j, GivenBy = new Internet().UserName(), CreatedDate = DateTime.Now, Status = DataStatus.Inserted
                    };

                    AppUsersLanguages.Add(appUserLanguage);
                }


            }
            AppUsersLanguages= AppUsersLanguages.GroupBy(x => new { x.AppUserID, x.LanguageID }).Select(x => x.FirstOrDefault()).ToList();//remove duplicate, just a simple BL to continue
            #endregion
        }

        public static List<Category> Categories { get; set; }
        public static List<Product> Products { get; set; }
        public static List<ProductFeature> ProductFeatures { get; set; }
        public static List<AppUser> AppUsers { get; set; }
        public static List<AppUserProfile> AppUserProfiles { get; set; }
        public static List<Language> Languages { get; set; }
        public static List<AppUserLanguage> AppUsersLanguages { get; set; } = new List<AppUserLanguage>();

    }
}

