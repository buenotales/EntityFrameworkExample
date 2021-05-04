using EntityFrameworkExample.Library.Data.Contexts;
using EntityFrameworkExample.Library.Data.Entities;
using EntityFrameworkExample.Library.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkExample.Library.Data.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly EFContext context;

        public SaleRepository(EFContext context)
        {
            this.context = context;
        }

        public SaleEntity Add(SaleEntity entity)
        {
            context.Sales.Add(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }

        public SaleEntity Get(int id)
        {
            return context.Sales.Include(s => s.Product).FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<SaleEntity> GetAll()
        {
            return context.Sales;
        }

        public SaleEntity Update(SaleEntity entity)
        {
            context.Sales.Update(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }
    }
}
