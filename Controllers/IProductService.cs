
namespace ContractTrack.Controllers
{
    public interface IProductService
    {
        Task<ProductCreateDto> CreateAsync(ProductCreateDto dto);
        
    }
}