﻿// <auto-generated />
using System;
using BookstoreApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace dotnet_api_for_angular_bookstore_app.Migrations
{
    [DbContext(typeof(BookstoreApiContext))]
    partial class BookstoreApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.AuthorModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookModelId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookModelId");

                    b.ToTable("AuthorModel");
                });

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.BookModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int?>("PriceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalPages")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("BookModel");
                });

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.PriceModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PriceModel");
                });

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.AuthorModel", b =>
                {
                    b.HasOne("dotnet_api_for_angular_bookstore_app.Models.BookModel", null)
                        .WithMany("Authors")
                        .HasForeignKey("BookModelId");
                });

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.BookModel", b =>
                {
                    b.HasOne("dotnet_api_for_angular_bookstore_app.Models.PriceModel", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("dotnet_api_for_angular_bookstore_app.Models.BookModel", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
