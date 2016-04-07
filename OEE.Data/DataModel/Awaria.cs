using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data.DataModel
{
    public class Awaria : Stan
    {
        public string OpisAwarii { get; set; }
        public virtual Maszyny Maszyna { get; set; }
    }
}
