using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskiSmjestaj.BazaHotela.Models
{
    class DefaultPodaci
    {
        public static void Initialize(HotelDbContext context)
        {
            if(!context.Hoteli.Any())
            {
                context.Hoteli.AddRange(
                new Hotel()
                {
                    HotelId = 1,
                    Naziv = "Prvi hotel",
                    BrojSoba = 0,
                    Opis="",
                    GeoSirina=0,
                    GeoDuzina=0,
                    Rating=5
                }
                );
                context.SaveChanges();
            }
        }
    }
}
