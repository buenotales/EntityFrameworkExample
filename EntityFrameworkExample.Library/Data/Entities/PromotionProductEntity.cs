using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Library.Data.Entities
{
    [Table("promotion_product")]
    public class PromotionProductEntity
    {
        [Column("productId"), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Column("promotionId"), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PromotionId { get; set; }

        public ProductEntity Product { get; set; }
        public PromotionEntity Promotion { get; set; }
    }
}
