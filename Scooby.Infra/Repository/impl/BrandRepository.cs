using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scooby.Domain.Entity;
using System.Collections.Generic;
using Scooby.Infra.EFCore;
using Scooby.Domain.Request;

namespace Scooby.Infra.Repository.impl
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ScoobyContext _db;
        public BrandRepository(ScoobyContext context)
        {
            _db = context;
        }
        public async Task<IEnumerable<Brand>> GetAll() {
            return await _db.Brands.ToListAsync();
        }
        public async Task Save(BrandRequest brand) {
            
            _db.Brands.Add(new Brand(brand.Description));
            await _db.SaveChangesAsync();
        }
    }
}