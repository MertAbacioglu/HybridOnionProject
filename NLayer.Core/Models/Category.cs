namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public ICollection<Product> Products { get; set; }
    }
}
