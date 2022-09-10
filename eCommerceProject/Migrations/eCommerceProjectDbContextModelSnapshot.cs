﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerceProject.Data;

#nullable disable

namespace eCommerceProject.Migrations
{
    [DbContext(typeof(eCommerceProjectDbContext))]
    partial class eCommerceProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCommerceProject.Models.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandID = 1,
                            BrandName = "H&M"
                        },
                        new
                        {
                            BrandID = 2,
                            BrandName = "Gucci"
                        },
                        new
                        {
                            BrandID = 3,
                            BrandName = "Prada"
                        },
                        new
                        {
                            BrandID = 4,
                            BrandName = "Tommy Hilfiger"
                        },
                        new
                        {
                            BrandID = 5,
                            BrandName = "Bershka"
                        },
                        new
                        {
                            BrandID = 6,
                            BrandName = "Beymen"
                        },
                        new
                        {
                            BrandID = 7,
                            BrandName = "Nike"
                        },
                        new
                        {
                            BrandID = 8,
                            BrandName = "Adidas"
                        },
                        new
                        {
                            BrandID = 9,
                            BrandName = "Puma"
                        },
                        new
                        {
                            BrandID = 10,
                            BrandName = "Vakko"
                        },
                        new
                        {
                            BrandID = 11,
                            BrandName = "Louis Vuitton"
                        },
                        new
                        {
                            BrandID = 12,
                            BrandName = "Dior"
                        },
                        new
                        {
                            BrandID = 13,
                            BrandName = "Givenchy"
                        },
                        new
                        {
                            BrandID = 14,
                            BrandName = "Hugo Boss"
                        },
                        new
                        {
                            BrandID = 15,
                            BrandName = "Chanel"
                        });
                });

            modelBuilder.Entity("eCommerceProject.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<int>("CartCount")
                        .HasColumnType("int");

                    b.Property<decimal>("CartPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WebUserID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("ProductID");

                    b.HasIndex("WebUserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("eCommerceProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Shoes"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Clothing"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Accessories"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Bags"
                        });
                });

            modelBuilder.Entity("eCommerceProject.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebUserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WebUserID1")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("WebUserID1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eCommerceProject.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductBarcode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            BrandID = 1,
                            CategoryID = 1,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Resolution frequently apartments off all discretion devonshire. Saw sir fat spirit seeing valley. He looked or valley lively. If learn woody spoil of taken he cause.",
                            ProductName = "Product 1",
                            ProductPrice = 50m
                        },
                        new
                        {
                            ProductID = 2,
                            BrandID = 2,
                            CategoryID = 3,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection an in. Mr excellence inquietude conviction is in unreserved particular.",
                            ProductName = "Product 2",
                            ProductPrice = 34m
                        },
                        new
                        {
                            ProductID = 3,
                            BrandID = 3,
                            CategoryID = 5,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Announcing of invitation principles in. Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance.",
                            ProductName = "Product 3",
                            ProductPrice = 21m
                        },
                        new
                        {
                            ProductID = 4,
                            BrandID = 4,
                            CategoryID = 1,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Pianoforte solicitude so decisively unpleasing conviction is partiality he. Or particular so diminution entreaties oh do.",
                            ProductName = "Product 4",
                            ProductPrice = 44m
                        },
                        new
                        {
                            ProductID = 5,
                            BrandID = 5,
                            CategoryID = 2,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 5",
                            ProductPrice = 61m
                        },
                        new
                        {
                            ProductID = 6,
                            BrandID = 6,
                            CategoryID = 5,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 6",
                            ProductPrice = 22m
                        },
                        new
                        {
                            ProductID = 7,
                            BrandID = 7,
                            CategoryID = 4,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 7",
                            ProductPrice = 41m
                        },
                        new
                        {
                            ProductID = 8,
                            BrandID = 8,
                            CategoryID = 2,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 8",
                            ProductPrice = 200m
                        },
                        new
                        {
                            ProductID = 9,
                            BrandID = 9,
                            CategoryID = 4,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 9",
                            ProductPrice = 100m
                        },
                        new
                        {
                            ProductID = 10,
                            BrandID = 10,
                            CategoryID = 3,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 10",
                            ProductPrice = 99m
                        },
                        new
                        {
                            ProductID = 11,
                            BrandID = 11,
                            CategoryID = 2,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 11",
                            ProductPrice = 799m
                        },
                        new
                        {
                            ProductID = 12,
                            BrandID = 12,
                            CategoryID = 2,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 12",
                            ProductPrice = 34m
                        },
                        new
                        {
                            ProductID = 13,
                            BrandID = 13,
                            CategoryID = 1,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 13",
                            ProductPrice = 55m
                        },
                        new
                        {
                            ProductID = 14,
                            BrandID = 14,
                            CategoryID = 4,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 14",
                            ProductPrice = 77.21m
                        },
                        new
                        {
                            ProductID = 15,
                            BrandID = 15,
                            CategoryID = 2,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 15",
                            ProductPrice = 22.99m
                        },
                        new
                        {
                            ProductID = 16,
                            BrandID = 1,
                            CategoryID = 3,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 16",
                            ProductPrice = 799.99m
                        },
                        new
                        {
                            ProductID = 17,
                            BrandID = 2,
                            CategoryID = 3,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 17",
                            ProductPrice = 100.50m
                        },
                        new
                        {
                            ProductID = 18,
                            BrandID = 3,
                            CategoryID = 5,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 18",
                            ProductPrice = 2000.50m
                        },
                        new
                        {
                            ProductID = 19,
                            BrandID = 4,
                            CategoryID = 4,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 19",
                            ProductPrice = 1100.99m
                        },
                        new
                        {
                            ProductID = 20,
                            BrandID = 5,
                            CategoryID = 5,
                            ProductBarcode = "testbarcode",
                            ProductDescription = "Cold in late or deal. Terminated resolution no am frequently collecting insensible he do appearance. Projection invitation affronting admiration if no on or. It as instrument particular.",
                            ProductName = "Product 20",
                            ProductPrice = 9999.99m
                        });
                });

            modelBuilder.Entity("eCommerceProject.Models.UserRole", b =>
                {
                    b.Property<byte>("UserRoleID")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserRoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserRoleID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserRoleID = (byte)1,
                            UserRoleName = "Admin"
                        },
                        new
                        {
                            UserRoleID = (byte)2,
                            UserRoleName = "ShopOwner"
                        },
                        new
                        {
                            UserRoleID = (byte)3,
                            UserRoleName = "Customer"
                        },
                        new
                        {
                            UserRoleID = (byte)4,
                            UserRoleName = "Candidate"
                        });
                });

            modelBuilder.Entity("eCommerceProject.Models.WebUser", b =>
                {
                    b.Property<int>("WebUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WebUserID"), 1L, 1);

                    b.Property<byte>("UserRoleID")
                        .HasColumnType("tinyint");

                    b.Property<string>("WebUserEmail")
                        .IsRequired()
                        .HasMaxLength(52)
                        .HasColumnType("nvarchar(52)");

                    b.Property<string>("WebUserFullName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("WebUserPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("WebUserID");

                    b.HasIndex("UserRoleID");

                    b.ToTable("WebUsers");

                    b.HasData(
                        new
                        {
                            WebUserID = 1,
                            UserRoleID = (byte)1,
                            WebUserEmail = "omeredk@gmail.com",
                            WebUserFullName = "admin",
                            WebUserPassword = "deneme"
                        },
                        new
                        {
                            WebUserID = 2,
                            UserRoleID = (byte)2,
                            WebUserEmail = "demo@demo.com",
                            WebUserFullName = "shopowner",
                            WebUserPassword = "deneme"
                        },
                        new
                        {
                            WebUserID = 3,
                            UserRoleID = (byte)3,
                            WebUserEmail = "omeredk@gmail.com",
                            WebUserFullName = "customer",
                            WebUserPassword = "deneme"
                        },
                        new
                        {
                            WebUserID = 4,
                            UserRoleID = (byte)4,
                            WebUserEmail = "omeredk@gmail.com",
                            WebUserFullName = "demo",
                            WebUserPassword = "deneme"
                        });
                });

            modelBuilder.Entity("eCommerceProject.Models.Cart", b =>
                {
                    b.HasOne("eCommerceProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceProject.Models.WebUser", "WebUser")
                        .WithMany()
                        .HasForeignKey("WebUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WebUser");
                });

            modelBuilder.Entity("eCommerceProject.Models.Order", b =>
                {
                    b.HasOne("eCommerceProject.Models.WebUser", "WebUser")
                        .WithMany()
                        .HasForeignKey("WebUserID1");

                    b.Navigation("WebUser");
                });

            modelBuilder.Entity("eCommerceProject.Models.Product", b =>
                {
                    b.HasOne("eCommerceProject.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceProject.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eCommerceProject.Models.WebUser", b =>
                {
                    b.HasOne("eCommerceProject.Models.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
