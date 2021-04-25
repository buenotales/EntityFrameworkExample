using EntityFrameworkExample.Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EntityFrameworkExample.Library.Data.Contexts
{
    public class EFContext : DbContext
    {
        private readonly ILoggerFactory loggerFactory;

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<SaleEntity> Sales { get; set; }
        public DbSet<PromotionEntity> Promotions { get; set; }

        public EFContext(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public IEnumerable<EntityEntry> GetChangeTrackerEntries() => ChangeTracker.Entries();
        public EntityEntry GetEntry<T>(T entity) => this.Entry(entity);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromotionProductEntity>().HasKey(pp => new { pp.ProductId, pp.PromotionId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory)
                .UseSqlServer("Data Source=localhost;Initial Catalog=Learning;User ID=sa;Password=Senha@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
