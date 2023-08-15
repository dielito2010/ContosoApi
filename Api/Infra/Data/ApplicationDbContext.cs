using Api.Domain.Product;
using Flunt.Notifications;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Infra.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<DimProduct> DimProducts { get; set; }
        public DbSet<DimProductCategory> DimProductCategories { get; set; }
        public DbSet<DimProductSubcategory> DimProductSubcategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<Notification>();

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ProductKey)
                .IsRequired();

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ColorName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ProductLabel)
                .HasMaxLength(255);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ProductName)
                .HasMaxLength(500);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ProductDescription)
                .HasMaxLength(400);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.Manufacturer)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.BrandName)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ClassID)
                .HasMaxLength(10);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ClassName)
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.StyleID)
                .HasMaxLength(10);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.StyleName)
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ColorID)
                .HasMaxLength(10);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.Size)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.SizeRange)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.SizeUnitMeasureID)
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.WeightUnitMeasureID)
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.UnitOfMeasureID)
                .HasMaxLength(20);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.UnitOfMeasureName)
                .HasMaxLength(40);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.StockTypeID)
                .HasMaxLength(10);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.StockTypeName)
                .HasMaxLength(40);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.Status)
                .HasMaxLength(7);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ImageURL)
                .HasMaxLength(150);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.ProductURL)
                .HasMaxLength(150);

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.UnitPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<DimProduct>()
                .Property(p => p.UnitCost)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<DimProductCategory>()
                .Property(c => c.ProductCategoryKey)
                .IsRequired();

            modelBuilder.Entity<DimProductCategory>()
                .Property(c => c.ProductCategoryLabel)
                .HasMaxLength(100);

            modelBuilder.Entity<DimProductCategory>()
                .Property(c => c.ProductCategoryName)
                .HasMaxLength(30);

            modelBuilder.Entity<DimProductCategory>()
                .Property(c => c.ProductCategoryDescription)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProductSubcategory>()
                .Property(sc => sc.ProductSubcategoryKey)
                .IsRequired();

            modelBuilder.Entity<DimProductSubcategory>()
                .Property(sc => sc.ProductSubcategoryLabel)
                .HasMaxLength(100);

            modelBuilder.Entity<DimProductSubcategory>()
                .Property(sc => sc.ProductSubcategoryName)
                .HasMaxLength(50);

            modelBuilder.Entity<DimProductSubcategory>()
                .Property(sc => sc.ProductSubcategoryDescription)
                .HasMaxLength(100);
        }
    }
}