using AutoMapper;
using rest_api.Interfaces;
using rest_api.Models;

namespace rest_api.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Product> _repo;

        public ProductService(IRepository<Product> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _repo.GetListAsync();
            return _mapper.Map<List<Product>, List<ProductDto>>(products);
        }

        public async Task<ProductDto> Create(ProductDto productDto)
        {
            var newItem = _mapper.Map<ProductDto, Product>(productDto);
            await _repo.InsertAsync(newItem);
            return _mapper.Map<Product, ProductDto>(newItem);
        }
    }
}
