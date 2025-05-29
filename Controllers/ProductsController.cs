using ContractTrack.Application.DTOS;
using ContractTrack.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContractTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductService service) : ControllerBase
    {
        private readonly IProductService _service = service;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateDto dto)
        {
            var result = await _service.CreateAsync(dto);

            return CreatedAtAction(nameof(GetAll), null, result);
        }

        [HttpGet]
        private object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
