using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new(){CreatedDate = DateTime.Now,Id = Guid.NewGuid(),Name = "Product A",Price = 150,Stock = 200},
                new(){CreatedDate = DateTime.Now,Id = Guid.NewGuid(),Name = "Product B",Price = 250,Stock = 300},
                new(){CreatedDate = DateTime.Now,Id = Guid.NewGuid(),Name = "Product C",Price = 350,Stock = 400},
                new(){CreatedDate = DateTime.Now,Id = Guid.NewGuid(),Name = "Product D",Price = 450,Stock = 500},
                new(){CreatedDate = DateTime.Now,Id = Guid.NewGuid(),Name = "Product E",Price = 550,Stock = 600},
            };
    }
}
