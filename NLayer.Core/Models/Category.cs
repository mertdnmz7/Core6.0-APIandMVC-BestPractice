

namespace NLayer.Core
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //Nav Prop... 
        public ICollection<Product> Products { get; set; }
    }
}
