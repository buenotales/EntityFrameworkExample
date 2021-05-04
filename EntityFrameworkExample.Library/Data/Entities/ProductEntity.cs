using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Library.Data.Entities
{
    [Table("products")]
    public class ProductEntity
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        public IList<PromotionProductEntity> Promotions { get; set; }
        public IList<SaleEntity> Sales { get; set; }

        public ProductEntity()
        {
            Promotions = new List<PromotionProductEntity>();
        }
    }
}
