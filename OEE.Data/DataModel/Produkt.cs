using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    [Table("Produkty")]
    public class Produkt
    {
        [Key]
        public int ProduktId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazwaProduktu { get; set; }

        public virtual List<Element> Elementy { get; set; }
    }
}
