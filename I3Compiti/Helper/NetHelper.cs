using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using I3Compiti.Model;
using Newtonsoft.Json.Linq;

namespace I3Compiti.Helper
{
    public static class NetHelper
    {
        public static WebClient client = new WebClient();

        public static string GetCompitiJson()
        {
            return client.DownloadString("http://i3compiti.ml/@/API.php?table=y");
        }
        
        public static List<Compito> GetCompiti()
        {
            JArray compiti = JArray.Parse(GetCompitiJson());

            Compito[] tasks = new Compito[compiti.Count];
            for (int i = 0; i < compiti.Count; i++)
            {
                string autore = compiti[i]["1"].ToString();
                string materia = compiti[i]["2"].ToString();
                string descrizione = compiti[i]["3"].ToString();
                string data = compiti[i]["4"].ToString();

                //locale information
                CultureInfo provider = CultureInfo.InvariantCulture;

                //the new format
                string format = "yyyy-MM-dd HH:mm:ss";

                DateTime parsedData = DateTime.ParseExact(data, format, provider);

                tasks[i] = new Compito(autore, materia, descrizione, parsedData);
            }

            return tasks.ToList();
        }
    }
}
