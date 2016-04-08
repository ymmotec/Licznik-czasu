using OEE.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licznik_czasu
{
    public class StanManager
    {
        public TypZdarzenia ObecnyStan { get; set; }
        
        public TypZdarzenia NowyStan { get; set; }

        public void zmienStan (TypZdarzenia nowyStan)
        {
            if (nowyStan.NazwaZdarzenia == "Awaria")
            {

            }

        }

    }
}
