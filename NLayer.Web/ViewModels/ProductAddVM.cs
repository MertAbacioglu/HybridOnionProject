using Microsoft.AspNetCore.Mvc.Rendering;

namespace NLayer.Web.ViewModels
{
    public class ProductAddVM:ProductVM
    {
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

    }
}
