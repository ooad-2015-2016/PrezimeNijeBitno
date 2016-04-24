using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskiSmjestaj.Hotel.Models
{
    class Rezervacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RezervacijaId { get; set; }
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public string idGost { get; set; }
        public string idSoba { get; set; }
    }
}
