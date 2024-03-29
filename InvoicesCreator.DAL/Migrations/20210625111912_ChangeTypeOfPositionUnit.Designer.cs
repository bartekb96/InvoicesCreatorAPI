﻿// <auto-generated />
using System;
using InvoicesCreator.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoicesCreator.DAL.Migrations
{
    [DbContext(typeof(InvoicesCreatorContext))]
    [Migration("20210625111912_ChangeTypeOfPositionUnit")]
    partial class ChangeTypeOfPositionUnit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.ContractorAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LocalNumber")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId")
                        .IsUnique();

                    b.ToTable("ContractorAddresses");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractorID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalBrutto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalNetto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractorID")
                        .IsUnique();

                    b.HasIndex("SellerID")
                        .IsUnique();

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.InvoicePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BruttoPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("NettoPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalBrutto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalNetto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoicePositions");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.SellerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LocalNumber")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SellerId")
                        .IsUnique();

                    b.ToTable("SellerAddresses");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEditedById")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("SellerID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerID")
                        .IsUnique()
                        .HasFilter("[SellerID] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.ContractorAddress", b =>
                {
                    b.HasOne("InvoicesCreator.Domain.Models.Contractor", "Contractor")
                        .WithOne("Address")
                        .HasForeignKey("InvoicesCreator.Domain.Models.ContractorAddress", "ContractorId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Contractor");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Invoice", b =>
                {
                    b.HasOne("InvoicesCreator.Domain.Models.Contractor", "Contractor")
                        .WithOne("Invoice")
                        .HasForeignKey("InvoicesCreator.Domain.Models.Invoice", "ContractorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoicesCreator.Domain.Models.Seller", "Seller")
                        .WithOne("Invoice")
                        .HasForeignKey("InvoicesCreator.Domain.Models.Invoice", "SellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contractor");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.InvoicePosition", b =>
                {
                    b.HasOne("InvoicesCreator.Domain.Models.Invoice", "Invoice")
                        .WithMany("Positions")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.SellerAddress", b =>
                {
                    b.HasOne("InvoicesCreator.Domain.Models.Seller", "Seller")
                        .WithOne("Address")
                        .HasForeignKey("InvoicesCreator.Domain.Models.SellerAddress", "SellerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.User", b =>
                {
                    b.HasOne("InvoicesCreator.Domain.Models.Seller", "Seller")
                        .WithOne("User")
                        .HasForeignKey("InvoicesCreator.Domain.Models.User", "SellerID");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Contractor", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Invoice", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("InvoicesCreator.Domain.Models.Seller", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
