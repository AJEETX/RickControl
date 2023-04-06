using app.Data.Entity;
using Microsoft.EntityFrameworkCore;
using app.Data.Seed;
using app.Data.Configurations;

namespace app.Data.Context
{
    public class RiskControlDbContext : DbContext
    {
        public RiskControlDbContext(DbContextOptions<RiskControlDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ClaimCase> Case { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<StoreStock> StoreStock { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionDetail> TransactionDetail { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new StoreStockConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionTypeSeed());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new StoreSeed());
            modelBuilder.ApplyConfiguration(new ProductSeed());
        }
    }
}
