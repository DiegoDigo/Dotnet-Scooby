using System;

namespace Scooby.Domain.Entity
{
    public class Product
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public Family Family { get; private set; }
        public Category Category { get; private set; }
        public Brand Brand { get; private set; }
        public DateTime CreateAt { get; private set; }


        public Product()
        {
            this.CreateAt = DateTime.UtcNow;
        }


    }
}
