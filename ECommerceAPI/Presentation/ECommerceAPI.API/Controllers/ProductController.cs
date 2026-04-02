using ECommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Name = "A Product", Price = 100,Stock = 200},
                new(){Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Name = "B Product", Price = 200,Stock = 300},
                new(){Id = Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Name = "C Product", Price = 300,Stock = 400}
            });
           await _productWriteRepository.SaveAsync();
        }
    }
}
