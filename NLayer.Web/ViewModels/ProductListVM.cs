namespace NLayer.Web.ViewModels
{
    public class ProductListVM
    {
        public ProductListVM()
        {
            productVMs = new List<ProductVM>();
        }
        public List<ProductVM> productVMs { get; set; }

    }
}