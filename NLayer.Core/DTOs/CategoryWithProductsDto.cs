namespace NLayer.Core.DTOs
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<CategoryDto> Products { get; set; }
    }
}
