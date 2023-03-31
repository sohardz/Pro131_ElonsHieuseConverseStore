﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.DomainModels.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateofCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateofPayment")
                        .HasColumnType("datetime");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StaffId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.BillDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ShoesId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Shoes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("decimal");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageDirection")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("MaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Stock")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SizeId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("SizeNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ImageDirection")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Bill", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.Staff", "Staff")
                        .WithMany("Bills")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.BillDetail", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.Shoes", "Shoes")
                        .WithMany("BillDetails")
                        .HasForeignKey("ShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Shoes", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.Category", "Category")
                        .WithMany("Shoes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.Color", "Color")
                        .WithMany("Shoes")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.Material", "Material")
                        .WithMany("Shoes")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.Size", "Size")
                        .WithMany("Shoes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Material");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Category", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Color", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Customer", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Material", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Shoes", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Size", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Staff", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
