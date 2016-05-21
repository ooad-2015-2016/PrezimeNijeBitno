using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class HistorijaRezervacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<Rezervacija> Rezervacije { get; set; }
    }
}
