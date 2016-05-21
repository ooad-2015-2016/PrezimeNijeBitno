using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelskiSmjestaj.Smjestaj.Models
{
    class Soba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        public int Id { get; set; }
        public decimal Cijena { get; set; }
    }
}
