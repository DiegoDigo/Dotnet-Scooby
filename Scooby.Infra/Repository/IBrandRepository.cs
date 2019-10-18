using System.Collections.Generic;
using System.Threading.Tasks;
using Scooby.Domain.Entity;
using Scooby.Domain.Request;

namespace Scooby.Infra.Repository
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAll();
        Task Save(BrandRequest brand);
    }
}