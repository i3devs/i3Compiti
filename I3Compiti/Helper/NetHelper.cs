using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I3Compiti.Data;
using I3Compiti.Model;
using Newtonsoft.Json.Linq;

namespace I3Compiti.Helper
{
    public static class NetHelper
    {
        public static WebClient client = new WebClient();
        public static string GetCompitiJson()
        {
            try
            {
                return client.DownloadString("http://i3compiti.ml/@/API.php?table=y");
            }
            catch (WebException e)
            {
                if (ClientHelper.isProxyException(e.Message))
                {
                    //ASK PROXY
                    throw new Exception.ProcessInterruptedException("Proxy not setted.");
                }
                else
                {
                    MessageBox.Show(e.Message, e.Source);
                    throw new Exception.ProcessInterruptedException("Process interrupted.");
                }
            }
        }
        
        public static List<Compito> GetCompiti()
        {
            try
            {
                JArray compiti = JArray.Parse(GetCompitiJson());
                Console.WriteLine(compiti.ToString());
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
            catch (Exception.ProcessInterruptedException es)
            {
                GUI gui = ApplicationSettings.Gui;
                if (gui != null)
                {
                    GUIHelper.NotifyUser(gui,ApplicationSettings.NotifyTimeout,"ProcessInterruptedException",es.Message,ToolTipIcon.Warning);
                }
                else
                {
                    Console.WriteLine(gui);
                    MessageBox.Show(es.Message, "ProcessInterruptedException");
                }

                return new List<Compito>();
            }
        }
    }
}
