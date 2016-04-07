using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace OEE.Data.DataModel
{
    

    [Table("Stan")]
    public partial class Stan
    {
        public int StanId { get; set; }

        [Required]
        public DateTime GodzinaUruchomienia { get; set; }

        [Required]
        public int CzasTrwania { get; set; }

        [Required]
        public int Brygada { get; set; }

        [Required]
        public string LiniaProdukcyjna { get; set; }

        [Required]
        public virtual TypZdarzenia TypZdarzenia { get; set; }

    }
}
