using System.ComponentModel.DataAnnotations;

namespace NLayer.Web.ViewModels
{
    public class ProductVM : BaseVM
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public CategoryVM CategoryVM { get; set; }
    }
}