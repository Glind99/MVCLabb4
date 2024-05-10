using Microsoft.EntityFrameworkCore;
using MVCLabb4.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MVCLabb4.Data
{
    public class Labb4DbContext : DbContext
    {
        public Labb4DbContext(DbContextOptions<Labb4DbContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", PhoneNumber = "1234567890" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Doe", Address = "456 Elm St", PhoneNumber = "0987654321" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction" },
                new Book { BookId = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction" }
            );

            modelBuilder.Entity<BookLoan>().HasData(
            new BookLoan { BookLoanId = 1, FK_CustomerID = 1, FK_BookID = 1, LoanDate = DateTime.Now.AddDays(-14), ReturnDate = DateTime.Now.AddDays(-7), ReturnedAt = DateTime.Now.AddDays(-7), IsLateOrNotReturned = false },
            new BookLoan { BookLoanId = 2, FK_CustomerID = 2, FK_BookID = 2, LoanDate = DateTime.Now.AddDays(-21), ReturnDate = DateTime.MinValue, ReturnedAt = DateTime.Now.AddDays(-10), IsLateOrNotReturned = false }
            );

        }
    }
}
