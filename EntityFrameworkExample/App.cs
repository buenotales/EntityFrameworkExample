using EntityFrameworkExample.Library.Data.Repositories.Interfaces;

namespace EntityFrameworkExample
{
    public class App
    {
        private readonly IProductRepository productRepository;
        private readonly ISaleRepository saleRepository;
        private readonly IPromotionRepository promotionRepository;

        public App(IProductRepository productRepository, ISaleRepository saleRepository, IPromotionRepository promotionRepository)
        {
            this.productRepository = productRepository;
            this.saleRepository = saleRepository;
            this.promotionRepository = promotionRepository;
        }

        public void Execute()
        {
            //#region Relacionamento 1:1

            //var sale = new SaleEntity()
            //{
            //    Product = new ProductEntity()
            //    {
            //        Name = "Catchup",
            //        Price = 10,
            //        Quantity = 2
            //    }
            //};
            //sale.Total = sale.Product.Price * sale.Product.Quantity;

            //saleRepository.Add(sale);

            //#endregion

            //#region Relacionamento N:N

            //var p1 = new ProductEntity() { Name = "Suco", Price = 1, Quantity = 2 };
            //var p2 = new ProductEntity() { Name = "Comida", Price = 1, Quantity = 1 };

            //var promotion = new PromotionEntity()
            //    .AddProduct(p1)
            //    .AddProduct(p2);

            //promotionRepository.Add(promotion);

            //#endregion


            //var sales = saleRepository.Get(2);

        }
    }
}
