using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        public String ime { get; set; }
        public String prezime { get; set; }
        public String brojLicne { get; set; }
    }
}
