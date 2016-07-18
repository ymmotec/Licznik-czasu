using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OEE.Data.DataModel
{
    [Table("Produkty")]
    public class Produkt
    {
        public int ProduktId { get; set; }
        [Key]
        [Column(Order = 1)]
        public string NazwaProduktu { get; set; }
        [Key]
        [Column(Order = 2)]
        public String NazwaElementu { get; set; }

        public string PelnaNazwa
        {
            get
            {
                return NazwaProduktu + " " + NazwaElementu;
            }
        }
    }
}
