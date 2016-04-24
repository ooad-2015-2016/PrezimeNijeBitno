using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskiSmjestaj.BazaHotela.Models
{
    class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId { get; set; }
        public string Naziv { get; set; }
        public int BrojSoba { get; set; }
        public string Opis { get; set; }
        public float GeoSirina { get; set; }
        public float GeoDuzina { get; set; }
        public float Rating { get; set; }
    }
}
