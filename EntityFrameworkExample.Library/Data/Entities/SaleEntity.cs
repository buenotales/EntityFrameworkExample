using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Library.Data.Entities
{
    [Table("sales")]
    public class SaleEntity
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("productId")]
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; }
    }
}
