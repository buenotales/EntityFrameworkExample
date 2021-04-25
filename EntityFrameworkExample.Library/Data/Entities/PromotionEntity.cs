using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Library.Data.Entities
{
    [Table("promotions")]
    public class PromotionEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("dateStart")]
        public DateTime DateStart { get; set; }

        [Column("dateEnd")]
        public DateTime DateEnd { get; set; }

        public IList<PromotionProductEntity> Products { get; set; }

        public PromotionEntity()
        {
            DateStart = DateTime.Now;
            DateEnd = DateStart.AddDays(7);
            Products = new List<PromotionProductEntity>();
        }

        public PromotionEntity AddProduct(ProductEntity p)
        {
            this.Products.Add(new PromotionProductEntity() { Product = p });
            return this;
        }
    }
}
