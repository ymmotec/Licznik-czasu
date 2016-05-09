using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    [Table("Kolory")]
    public class Kolor
    {
        [Key]
        public int KolorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazwaKoloru { get; set; }
    }
}
