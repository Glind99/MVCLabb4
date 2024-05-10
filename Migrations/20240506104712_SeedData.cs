using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCLabb4.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", "To Kill a Mockingbird" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John", "Doe", "1234567890" },
                    { 2, "456 Elm St", "Jane", "Doe", "0987654321" }
                });

            migrationBuilder.InsertData(
                table: "BookLoans",
                columns: new[] { "BookLoanId", "FK_BookID", "FK_CustomerID", "IsLateOrNotReturned", "LoanDate", "ReturnDate", "ReturnedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2024, 4, 22, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 4, 29, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 4, 29, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4036) },
                    { 2, 2, 2, false, new DateTime(2024, 4, 15, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4039), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 12, 47, 11, 514, DateTimeKind.Local).AddTicks(4041) }
                });

            
        }

        /// <inheritdoc />
       
    }
}
