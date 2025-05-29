using ContractTrack.Application.DTOS;
using ContractTrack.Application.Services;
using ContractTrack.Domain;

public class ProductService : IProductService
{

    private readonly ProductRepository _productRepository;
    public ProductService(ProductRepository repository)
    {
        _productRepository = repository;
    }
    public async Task<ProductViewDto> CreateAsync(ProductCreateDto dto)
    {
        var product = ProductMapper.ToProductEntity(dto);
        product.Id = Guid.NewGuid();

        await _productRepository.AddAsync(product);
        await _productRepository.SaveChangesAsync();
    }
}