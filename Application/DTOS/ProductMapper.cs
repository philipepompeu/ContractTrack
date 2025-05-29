using ContractTrack.Domain.Entities;

namespace ContractTrack.Application.DTOS
{
    public class ProductMapper
    {

        public static Product ToProductEntity(ProductCreateDto dto)
        {
            var product = new Product();
            product.Description = dto.Description;
            return product;
        }

        public static ProductViewDto ToProductViewDto(Product product)
        {
            var view = new ProductViewDto();
            view.Id = product.Id.ToString();
            view.Description = product.Description;

            return view;
        }
    }
}
