using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    [Table("Linia")]
    public class Linia
    {
        
        [Key]
        public int LiniaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazwaLinii { get; set; }

        public virtual List<Maszyny> Maszyny { get; set; }
        public virtual List<TypZdarzenia> TypyZdarzen { get; set; }

    }
}
