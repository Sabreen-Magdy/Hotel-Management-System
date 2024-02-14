﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_System_Back.Migrations
{
    /// <inheritdoc />
    public partial class PaymentFixMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId_Date",
                table: "Payments",
                columns: new[] { "ClientId", "Date" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ClientId_Date",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Payments");
        }
    }
}
