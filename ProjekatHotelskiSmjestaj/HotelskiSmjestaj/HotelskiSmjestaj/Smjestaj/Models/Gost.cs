using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Gost:Osoba
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Id { get; set; }
    }
}
