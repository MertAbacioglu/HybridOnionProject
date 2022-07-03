using Microsoft.AspNetCore.Mvc.Rendering;

namespace NLayer.Web.ViewModels
{
    public class CategoryListVM
    {
        public List<CategoryVM> CategoryVMList { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
