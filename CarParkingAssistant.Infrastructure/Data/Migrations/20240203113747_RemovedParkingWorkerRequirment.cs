using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkingAssistant.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedParkingWorkerRequirment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Workers_WorkerId",
                table: "Parkings");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Workers_WorkerId",
                table: "Parkings",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Workers_WorkerId",
                table: "Parkings");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Workers_WorkerId",
                table: "Parkings",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
