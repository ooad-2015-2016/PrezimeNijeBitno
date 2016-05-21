using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Apartman:Soba
    {        public int BrojSoba { get; set; }
        public int BrojKreveta { get; set; }
    }
}
