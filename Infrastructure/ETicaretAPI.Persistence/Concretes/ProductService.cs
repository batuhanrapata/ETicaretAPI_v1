using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new(){Id=Guid.NewGuid(), Name="Product1", price=100, Stock=11},
                new(){Id=Guid.NewGuid(), Name="Product2", price=200, Stock=12},
                new(){Id=Guid.NewGuid(), Name="Product3", price=300, Stock=13},
                new(){Id=Guid.NewGuid(), Name="Product4", price=400, Stock=14},
                new(){Id=Guid.NewGuid(), Name="Product5", price=500, Stock=15},
            };
    }
}
