using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using HotelskiSmjestaj.BazaHotela.Models;

namespace HotelskiSmjestajMigrations
{
    [ContextType(typeof(HotelDbContext))]
    partial class InitialMigration2
    {
        public override string Id
        {
            get { return "20160424214651_InitialMigration2"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("HotelskiSmjestaj.BazaHotela.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojSoba");

                    b.Property<float>("GeoDuzina");

                    b.Property<float>("GeoSirina");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<float>("Rating");

                    b.Key("HotelId");
                });
        }
    }
}
