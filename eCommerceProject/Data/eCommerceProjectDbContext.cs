using eCommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceProject.Data
{
    public class eCommerceProjectDbContext:DbContext
    {
        public eCommerceProjectDbContext(DbContextOptions<eCommerceProjectDbContext> options) : base(options) { }

        public DbSet<Brand>Brands { get; set; }
        public DbSet<Cart>Carts { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandID = 1, BrandName = "H&M" },
                new Brand { BrandID = 2, BrandName = "Gucci" },
                new Brand { BrandID = 3, BrandName = "Prada" },
                new Brand { BrandID = 4, BrandName = "Tommy Hilfiger" },
                new Brand { BrandID = 5, BrandName = "Bershka" },
                new Brand { BrandID = 6, BrandName = "Beymen" },
                new Brand { BrandID = 7, BrandName = "Nike" },
                new Brand { BrandID = 8, BrandName = "Adidas" },
                new Brand { BrandID = 9, BrandName = "Puma" },
                new Brand { BrandID = 10, BrandName = "Vakko" },
                new Brand { BrandID = 11, BrandName = "Louis Vuitton" },
                new Brand { BrandID = 12, BrandName = "Dior" },
                new Brand { BrandID = 13, BrandName = "Givenchy" },
                new Brand { BrandID = 14, BrandName = "Hugo Boss" },
                new Brand { BrandID = 15, BrandName = "Chanel" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName= "Shoes"},
                new Category { CategoryID=2, CategoryName= "Clothing"},
                new Category { CategoryID=3, CategoryName= "Accessories"},
                new Category { CategoryID=4, CategoryName= "Sports"},
                new Category { CategoryID=5, CategoryName= "Bags"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { BrandID = 1, ProductID = 1, ProductName = "Product 1", ProductPrice = 50, ProductBarcode = "testbarcode", CategoryID = 1, ProductDescription = "Resolution frequently apartments off all discretion devonshire. Saw sir fat spirit seeing valley. He looked or valley lively. If learn woody spoil of taken he cause." },
                new Product { BrandID = 2, ProductID = 2, ProductName = "Product 2", ProductPrice = 34, ProductBarcode = "testbarcode", CategoryID = 3, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection an in. Mr excellence inquietude conviction is in unreserved particular." },
                new Product { BrandID = 3, ProductID = 3, ProductName = "Product 3", ProductPrice = 21, ProductBarcode = "testbarcode", CategoryID = 5, ProductDescription = "Announcing of invitation principles in. Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance." },
                new Product { BrandID = 4, ProductID = 4, ProductName = "Product 4", ProductPrice = 44, ProductBarcode = "testbarcode", CategoryID = 1, ProductDescription = "Pianoforte solicitude so decisively unpleasing conviction is partiality he. Or particular so diminution entreaties oh do." },
                new Product { BrandID = 5, ProductID = 5, ProductName = "Product 5", ProductPrice = 61, ProductBarcode = "testbarcode", CategoryID = 2, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 6, ProductID = 6, ProductName = "Product 6", ProductPrice = 22, ProductBarcode = "testbarcode", CategoryID = 5, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 7, ProductID = 7, ProductName = "Product 7", ProductPrice = 41, ProductBarcode = "testbarcode", CategoryID = 4, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 8, ProductID = 8, ProductName = "Product 8", ProductPrice = 200, ProductBarcode = "testbarcode", CategoryID = 2, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 9, ProductID = 9, ProductName = "Product 9", ProductPrice = 100, ProductBarcode = "testbarcode", CategoryID = 4, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 10, ProductID = 10, ProductName = "Product 10", ProductPrice = 99, ProductBarcode = "testbarcode", CategoryID = 3, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 11, ProductID = 11, ProductName = "Product 11", ProductPrice = 799, ProductBarcode = "testbarcode", CategoryID = 2, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 12, ProductID = 12, ProductName = "Product 12", ProductPrice = 34, ProductBarcode = "testbarcode", CategoryID = 2, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 13, ProductID = 13, ProductName = "Product 13", ProductPrice = 55, ProductBarcode = "testbarcode", CategoryID = 1, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 14, ProductID = 14, ProductName = "Product 14", ProductPrice = 77.21m, ProductBarcode = "testbarcode", CategoryID = 4, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 15, ProductID = 15, ProductName = "Product 15", ProductPrice = 22.99m, ProductBarcode = "testbarcode", CategoryID = 2, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 1, ProductID = 16, ProductName = "Product 16", ProductPrice = 799.99m, ProductBarcode = "testbarcode", CategoryID = 3, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 2, ProductID = 17, ProductName = "Product 17", ProductPrice = 100.50m, ProductBarcode = "testbarcode", CategoryID = 3, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 3, ProductID = 18, ProductName = "Product 18", ProductPrice = 2000.50m, ProductBarcode = "testbarcode", CategoryID = 5, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 4, ProductID = 19, ProductName = "Product 19", ProductPrice = 1100.99m, ProductBarcode = "testbarcode", CategoryID = 4, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." },
                new Product { BrandID = 5, ProductID = 20, ProductName = "Product 20", ProductPrice = 9999.99m, ProductBarcode = "testbarcode", CategoryID = 5, ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular." }
                );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserRoleID = 1, UserRoleName = "Admin"},
                new UserRole { UserRoleID = 2, UserRoleName = "ShopOwner"},
                new UserRole { UserRoleID = 3, UserRoleName = "Customer" },
                new UserRole { UserRoleID = 4, UserRoleName = "Candidate"}
                );

            modelBuilder.Entity<WebUser>().HasData(
                new WebUser { WebUserID = 1, WebUserFullName = "admin", WebUserPassword = "deneme", WebUserRePassword = "deneme", WebUserEmail = "omeredk@gmail.com", UserRoleID = 1 },
                new WebUser { WebUserID = 2, WebUserFullName = "shopowner", WebUserPassword = "deneme", WebUserRePassword = "deneme", WebUserEmail = "demo@demo.com", UserRoleID = 2 },
                new WebUser { WebUserID = 3, WebUserFullName = "customer", WebUserPassword = "deneme", WebUserRePassword = "deneme", WebUserEmail = "omeredk@gmail.com", UserRoleID = 3 },
                new WebUser { WebUserID = 4, WebUserFullName = "demo", WebUserPassword = "deneme", WebUserRePassword = "deneme", WebUserEmail = "omeredk@gmail.com", UserRoleID = 4 }
                );
        }
    }
}
