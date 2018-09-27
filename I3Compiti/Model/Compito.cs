using I3Compiti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3Compiti.Model
{
    public class Compito
    {
        public string Autore { get; set; }
        public string Materia { get; set; }
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }

        public Compito(string autore, string materia, string descrizione, DateTime data)
        {
            Autore = autore;
            Materia = materia;
            Descrizione = descrizione;
            Data = data;
        }

        public TimeSpan GetRemainingTime()
        {
            return ClientHelper.GetTimeDifference(DateTime.Now, Data);
        }

        public override string ToString()
        {
            return String.Format("Autore: {0}, Materia: {1}, Descrizione: {2}, Data: {3}", Autore,Materia,Descrizione,Data);
        }
    }
}
