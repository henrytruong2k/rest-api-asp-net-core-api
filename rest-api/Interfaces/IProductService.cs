using rest_api.Models;

namespace rest_api.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
        Task<ProductDto> Create(ProductDto productDto);
    }
}
