using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    public class Element
    {
        [Key]
        public int ElementId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazwaElementu { get; set; }

        public virtual Produkt Produkt { get; set; }
    }
}
