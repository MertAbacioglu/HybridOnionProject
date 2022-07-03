namespace NLayer.Core.Models

{
    public class ProductFeature : BaseEntity
    {
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        //Relational Properties
        public Product Product { get; set; }
    }
}
