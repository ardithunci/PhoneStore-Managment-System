using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneStoreManagmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klientet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MjetIdentifikimi = table.Column<string>(type: "TEXT", nullable: false),
                    NumriBlerjeve = table.Column<int>(type: "INTEGER", nullable: false),
                    NumriPersonal = table.Column<string>(type: "TEXT", nullable: false),
                    Ditelindja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klientet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produktet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Prodhuesi = table.Column<string>(type: "TEXT", nullable: false),
                    QRcode = table.Column<string>(type: "TEXT", nullable: false),
                    Parametrat = table.Column<string>(type: "TEXT", nullable: false),
                    Kostoja = table.Column<double>(type: "REAL", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produktet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klientet");

            migrationBuilder.DropTable(
                name: "Produktet");
        }
    }
}
