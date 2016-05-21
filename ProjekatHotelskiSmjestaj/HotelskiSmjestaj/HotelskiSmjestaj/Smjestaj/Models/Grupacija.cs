using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Grupacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String NazivGrupacije { get; set; }
        public List<Hotel> Hoteli { get; set; }
    }
}
