using EntityFrameworkExample.Library.Data.Contexts;
using EntityFrameworkExample.Library.Data.Entities;
using EntityFrameworkExample.Library.Data.Repositories.Interfaces;
using System.Collections.Generic;

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
            return context.Products.Find(id);
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
