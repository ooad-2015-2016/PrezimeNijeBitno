using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace HotelskiSmjestajMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    DatumDolaska = table.Column(type: "TEXT", nullable: false),
                    DatumOdlaska = table.Column(type: "TEXT", nullable: false),
                    idGost = table.Column(type: "TEXT", nullable: true),
                    idSoba = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Rezervacija");
        }
    }
}
