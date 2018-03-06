﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Shop.Data;
using System;

namespace Shop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20180306165214_AddedProductTable")]
    partial class AddedProductTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Model.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Region");

                    b.Property<string>("Street");

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Shop.Model.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shop.Model.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderID");

                    b.Property<float>("Price");

                    b.Property<int?>("ProductCategoryID");

                    b.Property<string>("ProductName");

                    b.Property<int>("Stock");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Shop.Model.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("SubCategory");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Shop.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressID");

                    b.Property<string>("Email");

                    b.Property<string>("Fullname");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Shop.Model.Product", b =>
                {
                    b.HasOne("Shop.Model.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderID");

                    b.HasOne("Shop.Model.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryID");
                });

            modelBuilder.Entity("Shop.Model.User", b =>
                {
                    b.HasOne("Shop.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");
                });
#pragma warning restore 612, 618
        }
    }
}
