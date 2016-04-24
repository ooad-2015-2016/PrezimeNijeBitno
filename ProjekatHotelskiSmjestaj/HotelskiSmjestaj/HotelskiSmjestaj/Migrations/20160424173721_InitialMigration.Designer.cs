using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using HotelskiSmjestaj.Hotel.Models;

namespace HotelskiSmjestajMigrations
{
    [ContextType(typeof(RezervacijaDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160424173721_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("HotelskiSmjestaj.Hotel.Models.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDolaska");

                    b.Property<DateTime>("DatumOdlaska");

                    b.Property<string>("idGost");

                    b.Property<string>("idSoba");

                    b.Key("RezervacijaId");
                });
        }
    }
}
