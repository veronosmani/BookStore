﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 1,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 2,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 3,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 4,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 5,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "CID",
                keyValue: 6,
                column: "ImageUrl",
                value: " ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
