namespace NLayer.Core.DTOs
{
    public class ProductWithCategoryAndFeatureDto:ProductDto
    {
        public CategoryDto Category { get; set; }
        public ProductFeatureDto ProductFeature { get; set; }
    }
}
