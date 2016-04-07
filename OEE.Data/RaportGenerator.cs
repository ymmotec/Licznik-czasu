using OEE.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEE.Data
{
    public class RaportGenerator
    {
        public List<Stan> Raport { get; set; }


        public RaportGenerator(List<Stan> raport)
        {
            Raport = raport;
        }

        public StringBuilder getCSVData()
        {
            StringBuilder data = new StringBuilder();

            data.Append("Linia produkcyjna;");
            data.Append("Typ Zdarzenia;");
            data.Append("Godzina uruchomienia;");
            data.Append("Czas trwania;");
            data.Append("Brygada;");
            data.Append("Opis Awarii;");
            data.Append("Maszyna;");
            data.Append("Opis przezbrojenia;");
            data.Append("\n");

            foreach (var item in Raport)
            {
                data.Append(item.LiniaProdukcyjna);
                data.Append(";");
                data.Append(item.TypZdarzenia.NazwaZdarzenia);
                data.Append(";");
                data.Append(item.GodzinaUruchomienia.ToString());
                data.Append(";");
                data.Append(item.CzasTrwania.ToString());
                data.Append(";");
                data.Append(item.Brygada.ToString());
                data.Append(";");
                if (item.TypZdarzenia.NazwaZdarzenia == "Awaria")
                {
                    Awaria aw = (Awaria)item;
                    if (aw.OpisAwarii != null)
                    {
                        data.Append(aw.OpisAwarii.Replace("\n", " ").Replace("\r", string.Empty));
                    }
                    else
                    {
                        data.Append("Brak opisu awarii.");
                    }

                    data.Append(";");
                    if (aw.Maszyna != null)
                    {
                        data.Append(aw.Maszyna.NazwaMaszyny);
                    }
                    else
                    {
                        data.Append("Nie określono miejsca awarii");
                    }

                    data.Append(";");
                }
                else if (item.TypZdarzenia.NazwaZdarzenia == "Przezbrojenie")
                {
                    Przezbrojenie pr = (Przezbrojenie)item;
                    data.Append(";;");
                    if (pr.OpisPrzezbrojenia != null)
                    {
                        data.Append(pr.OpisPrzezbrojenia.Replace("\n", " ").Replace("\r", string.Empty));
                    }
                    else
                    {
                        data.Append("Brak opisu przezbrojenia.");
                    }

                    data.Append(";");
                }



                data.Append("\n");

            }

            return data;


        }
    }
}
