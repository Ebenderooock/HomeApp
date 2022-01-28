﻿// <auto-generated />
using System;
using HomeApp.Data.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeApp.Migrations
{
    [DbContext(typeof(HomeContentDbContext))]
    [Migration("20211222141311_202112221613")]
    partial class _202112221613
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Category", "Home");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AcquisitionType")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("InventoryItem", "Home");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItemAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InventoryItemId");

                    b.ToTable("InventoryItemAttachment", "Home");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItemPurchaseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchasedOn")
                        .HasColumnType("date");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InventoryItemId")
                        .IsUnique();

                    b.ToTable("InventoryItemPurchaseDetail", "Home");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItem", b =>
                {
                    b.HasOne("HomeApp.Models.Domain.Management.Home.Content.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItemAttachment", b =>
                {
                    b.HasOne("HomeApp.Models.Domain.Management.Home.Content.InventoryItem", "InventoryItem")
                        .WithMany("Attachments")
                        .HasForeignKey("InventoryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryItem");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItemPurchaseDetail", b =>
                {
                    b.HasOne("HomeApp.Models.Domain.Management.Home.Content.InventoryItem", "InventoryItem")
                        .WithOne("PurchaseDetail")
                        .HasForeignKey("HomeApp.Models.Domain.Management.Home.Content.InventoryItemPurchaseDetail", "InventoryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryItem");
                });

            modelBuilder.Entity("HomeApp.Models.Domain.Management.Home.Content.InventoryItem", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("PurchaseDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
