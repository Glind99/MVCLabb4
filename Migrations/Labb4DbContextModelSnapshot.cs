﻿// <auto-generated />
using System;
using MVCLabb4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCLabb4.Migrations
{
    [DbContext(typeof(Labb4DbContext))]
    partial class Labb4DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCLabb4.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Fiction",
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Harper Lee",
                            Genre = "Fiction",
                            Title = "To Kill a Mockingbird"
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.BookLoan", b =>
                {
                    b.Property<int>("BookLoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookLoanId"));

                    b.Property<int>("FK_BookID")
                        .HasColumnType("int");

                    b.Property<int>("FK_CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsLateOrNotReturned")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BookLoanId");

                    b.HasIndex("FK_BookID");

                    b.HasIndex("FK_CustomerID");

                    b.ToTable("BookLoans");

                    b.HasData(
                        new
                        {
                            BookLoanId = 1,
                            FK_BookID = 1,
                            FK_CustomerID = 1,
                            IsLateOrNotReturned = false,
                            LoanDate = new DateTime(2024, 4, 22, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(3993),
                            ReturnDate = new DateTime(2024, 4, 29, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4033),
                            ReturnedAt = new DateTime(2024, 4, 29, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4036)
                        },
                        new
                        {
                            BookLoanId = 2,
                            FK_BookID = 2,
                            FK_CustomerID = 2,
                            IsLateOrNotReturned = false,
                            LoanDate = new DateTime(2024, 4, 15, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4039),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnedAt = new DateTime(2024, 4, 26, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4041)
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Main St",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "456 Elm St",
                            FirstName = "Jane",
                            LastName = "Doe",
                            PhoneNumber = "0987654321"
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.BookLoan", b =>
                {
                    b.HasOne("MVCLabb4.Models.Book", "Book")
                        .WithMany("BookLoans")
                        .HasForeignKey("FK_BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCLabb4.Models.Customer", "Customer")
                        .WithMany("BookLoans")
                        .HasForeignKey("FK_CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MVCLabb4.Models.Book", b =>
                {
                    b.Navigation("BookLoans");
                });

            modelBuilder.Entity("MVCLabb4.Models.Customer", b =>
                {
                    b.Navigation("BookLoans");
                });
#pragma warning restore 612, 618
        }
    }
}
