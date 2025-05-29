using ContractTrack.Application.DTOS;

namespace ContractTrack.Application.Services
{
    public interface IProductService
    {
        Task<ProductViewDto> CreateAsync(ProductCreateDto dto);

    }
}