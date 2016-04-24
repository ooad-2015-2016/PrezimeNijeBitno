using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace HotelskiSmjestajMigrations
{
    public partial class InitialMigration2 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    BrojSoba = table.Column(type: "INTEGER", nullable: false),
                    GeoDuzina = table.Column(type: "REAL", nullable: false),
                    GeoSirina = table.Column(type: "REAL", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    Opis = table.Column(type: "TEXT", nullable: true),
                    Rating = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Hotel");
        }
    }
}
