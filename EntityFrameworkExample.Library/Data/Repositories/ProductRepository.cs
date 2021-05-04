using EntityFrameworkExample.Library.Data.Contexts;
using EntityFrameworkExample.Library.Data.Entities;
using EntityFrameworkExample.Library.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkExample.Library.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EFContext context;

        public ProductRepository(EFContext context)
        {
            this.context = context;
        }

        public ProductEntity Add(ProductEntity entity)
        {
            context.Products.Add(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }

        public ProductEntity Get(int id)
        {
            return context.Products.Include(s => s.Sales).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return context.Products;
        }

        public ProductEntity Update(ProductEntity entity)
        {
            context.Products.Update(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }
    }
}
