using EntityFrameworkExample.Library.Data.Contexts;
using EntityFrameworkExample.Library.Data.Entities;
using EntityFrameworkExample.Library.Data.Repositories.Interfaces;
using System.Collections.Generic;

namespace EntityFrameworkExample.Library.Data.Repositories
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly EFContext context;

        public PromotionRepository(EFContext context)
        {
            this.context = context;
        }

        public PromotionEntity Add(PromotionEntity entity)
        {
            context.Promotions.Add(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }

        public PromotionEntity Get(int id)
        {
            return context.Promotions.Find(id);
        }

        public IEnumerable<PromotionEntity> GetAll()
        {
            return context.Promotions;
        }

        public PromotionEntity Update(PromotionEntity entity)
        {
            context.Promotions.Update(entity);
            if (context.SaveChanges() > 0)
                return entity;

            return default;
        }

    }
}
