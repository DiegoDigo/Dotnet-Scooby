using System.Threading.Tasks;
using Scooby.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using Scooby.Domain.Request;
using Scooby.Domain.Entity;

namespace Scooby.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IBrandRepository _brandRepository;

        public BrandController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet]
        [ApiVersion("1.0")]
        public async Task<IActionResult> all()
        {
            var result = await _brandRepository.GetAll();
            if(result == null){
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPost]
        [ApiVersion("1.0")]
        public async Task<IActionResult> create([FromBody] BrandRequest brand)
        {
            await _brandRepository.Save(brand);
            return StatusCode(201);
        }

    }
}