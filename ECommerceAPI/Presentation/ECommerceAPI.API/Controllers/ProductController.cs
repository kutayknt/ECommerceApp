using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
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
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //Product p = await _productReadRepository.GetByIdAsync("7bdc2df4-8cc5-47af-a80e-b1fc8e9e94a9",tracking : false);
            //p.Name = "KutayNoTracking Product";
            //await _productWriteRepository.SaveAsync();

            //var customerId = Guid.NewGuid();

            //await _customerWriteRepository.AddAsync(new()
            //{
            //    Id = customerId,
            //    Name = "Kutay Kunt"
            //});

            //await _orderWriteRepository.AddAsync(new Order()
            //{
            //    Adress = "Antalya,Kepez",
            //    Description = "Sossuz",
            //    CustomerId = customerId,
            //});
            //await _orderWriteRepository.AddAsync(new Order()
            //{
            //    Adress = "Antalya,Muratpaşa",
            //    Description = "Soslu",
            //    CustomerId = customerId,
            //});

            var order = await _orderReadRepository.GetByIdAsync("019d67a3-85a7-7a40-91e4-3fa0de940525");
            order.Adress = "Antalya,Lara";

            await _orderWriteRepository.SaveAsync();
        }
    }
}
