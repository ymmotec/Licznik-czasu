using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    [Table("Maszyny")]
    public class Maszyny
    {
       
        [Key]
        public int MaszynaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazwaMaszyny { get; set; }

        public virtual Linia Linia { get; set; }
        
        public virtual List<Awaria> Awarie { get; set; }
    }
}
