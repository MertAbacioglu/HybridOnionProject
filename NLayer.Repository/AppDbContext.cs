using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NLayer.Core;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Repository.Seeds;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<AppUserLanguage> AppUsersLanguages { get; set; }


        public override int SaveChanges()
        {
            UpdateChangeTracker();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateChangeTracker();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public void UpdateChangeTracker()
        {
            foreach (EntityEntry item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {

                                entityReference.UpdatedDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }
        }
    }
}