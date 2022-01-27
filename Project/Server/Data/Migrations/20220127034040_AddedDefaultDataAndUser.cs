using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "ItenaryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "ItenaryItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HLocation",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Hotels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Hotels",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryId",
                table: "Locations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_CountryId",
                table: "ItenaryItems",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItenaryItems_LocationId",
                table: "ItenaryItems",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_LocationId",
                table: "Hotels",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Locations_LocationId",
                table: "Hotels",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItenaryItems_Country_CountryId",
                table: "ItenaryItems",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItenaryItems_Locations_LocationId",
                table: "ItenaryItems",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Country_CountryId",
                table: "Locations",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Locations_LocationId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_ItenaryItems_Country_CountryId",
                table: "ItenaryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ItenaryItems_Locations_LocationId",
                table: "ItenaryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Country_CountryId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CountryId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_ItenaryItems_CountryId",
                table: "ItenaryItems");

            migrationBuilder.DropIndex(
                name: "IX_ItenaryItems_LocationId",
                table: "ItenaryItems");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_LocationId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "ItenaryItems");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "ItenaryItems");

            migrationBuilder.DropColumn(
                name: "HLocation",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Hotels");
        }
    }
}
