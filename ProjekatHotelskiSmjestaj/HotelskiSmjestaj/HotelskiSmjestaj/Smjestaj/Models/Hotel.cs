using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String NazivHotela { get; set; }
        public String Id { get; set; }
    }
}
