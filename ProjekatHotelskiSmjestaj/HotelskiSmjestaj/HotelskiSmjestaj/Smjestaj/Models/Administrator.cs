using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Administrator:Osoba
    {        public String Id { get; set; }
        public String Password { get; set; }
    }
}
