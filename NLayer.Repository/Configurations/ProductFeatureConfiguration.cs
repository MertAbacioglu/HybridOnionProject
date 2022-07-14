using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using NLayer.Core.Models;

namespace NLayer.Repository.Configurations
{
    public class ProductFeatureConfiguration : BaseConfiguration<ProductFeature>
    {
        public override void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            base.Configure(builder);
            builder.ToTable("UrunOzellikleri");
        }
    }
}
