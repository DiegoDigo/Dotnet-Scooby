using System;

namespace Scooby.Domain.Entity
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public Family Family { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public DateTime CreateAt { get; private set; }


        public Product()
        {
            this.CreateAt = DateTime.UtcNow;
        }


    }
}
