using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Wedding_Planner.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weddingid",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    user_id = table.Column<int>(nullable: false),
                    wedding_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    address = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    plannerid = table.Column<int>(nullable: true),
                    wedder_1 = table.Column<string>(nullable: true),
                    wedder_2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Weddings_Users_plannerid",
                        column: x => x.plannerid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Weddingid",
                table: "Users",
                column: "Weddingid");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_plannerid",
                table: "Weddings",
                column: "plannerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Weddings_Weddingid",
                table: "Users",
                column: "Weddingid",
                principalTable: "Weddings",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Weddings_Weddingid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropIndex(
                name: "IX_Users_Weddingid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Weddingid",
                table: "Users");
        }
    }
}
