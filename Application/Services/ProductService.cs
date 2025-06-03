using ContractTrack.Application.DTOS;
using ContractTrack.Application.Services;
using ContractTrack.Domain;
using ContractTrack.Domain.Entities;

public class ProductService : IProductService
{

    private readonly IRepository<Product> _productRepository;
    public ProductService(IRepository<Product> repository)
    {
        _productRepository = repository;
    }
    public async Task<ProductViewDto> CreateAsync(ProductCreateDto dto)
    {
        var product = ProductMapper.ToProductEntity(dto);
        product.Id = Guid.NewGuid();

        await _productRepository.AddAsync(product);
        await _productRepository.SaveChangesAsync();

        return ProductMapper.ToProductViewDto(product);
    }
}