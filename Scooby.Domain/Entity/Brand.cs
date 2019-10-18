using System;

namespace Scooby.Domain.Entity
{
    public class Brand
    {
        public long Id { get; private set; }
        public string Description { get; private set; }

        public Brand(string Description)
        {
            this.Description = Description;
        }
    }
}
