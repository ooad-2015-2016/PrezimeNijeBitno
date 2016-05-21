using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Rezervacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public String IdSobe { get; set; }
        public String IdGosta { get; set; }
    }
}
