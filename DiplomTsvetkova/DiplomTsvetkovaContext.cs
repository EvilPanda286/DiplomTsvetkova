using DiplomTsvetkova.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DiplomTsvetkova
{
    public class DiplomTsvetkovaContext : DbContext
    {
        public DiplomTsvetkovaContext() { }
        public DiplomTsvetkovaContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }
       
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
               .Entity<Product>()
               .HasMany(c => c.Storages)
               .WithMany(s => s.Products)
               .UsingEntity<ProductStorage>(
                  j => j
                   .HasOne(pt => pt.Storage)
                   .WithMany(t => t.ProductStorages)
                   .HasForeignKey(pt => pt.StorageId),
               j => j
                   .HasOne(pt => pt.Product)
                   .WithMany(p => p.ProductStorages)
                   .HasForeignKey(pt => pt.ProductId),
               j =>
               {
                   j.ToTable("ProductStorages");
               });

            //modelBuilder.Entity<ProductStorage>().HasOne(p => p.Storage).WithMany(p => p.ProductStorages).HasForeignKey(p => p.StorageId);
            //modelBuilder.Entity<ProductStorage>().HasOne(p => p.Product).WithMany(p => p.ProductStorages).HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<Order>().HasOne(p => p.ProductStorage).WithMany(p => p.Orders);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                    Name = "BANAN1",
                    Price = 1,
                    Image = "1.jpg"
                },
                new Product
                {
                    Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                    Name = "BANAN2",
                    Price = 12,
                    Image = "1.jpg"
                },
                new Product
                {
                    Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e83"),
                    Name = "BANAN3",
                    Price = 123,
                    Image = "1.jpg"
                },
                new Product
                {
                    Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e84"),
                    Name = "BANAN4",
                    Price = 1234,
                    Image = "1.jpg"
                },
                new Product
                {
                    Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                    Name = "BANAN5",
                    Price = 12345,
                    Image = "1.jpg"
                }
                );
            modelBuilder.Entity<Storage>().HasData(
               new Storage
               {
                   Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e11"),
                   Name = "BANANOSKLAD1",
                   Address = "Ново-Московская ул., 2/8, Смоленск, Смоленская обл., 214000",
                   Latitude = 54.79533207632343,
                   Longitude = 32.05564758962073
               },
               new Storage
               {
                   Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                   Name = "BANANOSKLAD2",
                   Address = "ул. 25 Сентября, 35А, Смоленск, Смоленская обл., 214031",
                   Latitude = 54.770775521219925,
                   Longitude = 32.07975394633851
               },
               new Storage
               {
                   Id = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e13"),
                   Name = "BANANOSKLAD3",
                   Address = "ул. Нормандии-Неман, 35, Смоленск, Смоленская обл., 214025",
                   Latitude = 54.78012869907241,
                   Longitude = 32.01669503530315
               }
               );
            modelBuilder.Entity<ProductStorage>().HasData(
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e11"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e13"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e83"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e84"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e13"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e13"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e11"),
                   Quantity = 100
               },
               new ProductStorage
               {
                   ProductId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                   StorageId = Guid.Parse("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                   Quantity = 100
               }
               );
        }

    }
    // public class EFDBContextFactory : IDesignTimeDbContextFactory<DiplomTsvetkovaContext>
    // {
    //   public DiplomTsvetkovaContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<DiplomTsvetkovaContext>();
    //        optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DiplomDB;Integrated Security=True", b => b.MigrationsAssembly("DataLayer"));
    //
    //       return new DiplomTsvetkovaContext(optionsBuilder.Options);
    //   }
    //}
}
