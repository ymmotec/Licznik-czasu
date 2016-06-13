using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    public class TypZdarzenia
    {
        
        [Key]
        public int TypZdarzeniaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string NazwaZdarzenia { get; set; }

        public virtual List<Linia> Linia { get; set; }
        public virtual List<Stan> Stany { get; set; }
    }
}
