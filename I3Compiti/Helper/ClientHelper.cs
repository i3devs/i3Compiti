using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using I3Compiti.Model;
using I3Compiti.Data;
using System.Windows.Forms;

namespace I3Compiti.Helper
{
    public static class ClientHelper
    {
        public static TimeSpan GetTimeDifference(DateTime startTime, DateTime endTime)
        {
            return endTime - startTime;
        }

        public static void NotifyEvents(GUI gui,Compito[] compiti)
        {
            foreach (Compito compito in compiti)
            {
                TimeSpan diff = GetTimeDifference(DateTime.Now,compito.Data);
                Console.WriteLine(diff.TotalMinutes + " " + ApplicationSettings.NotifyEventMinutesBefore);

                if (diff.TotalMinutes <= ApplicationSettings.NotifyEventMinutesBefore)
                {
                    GUIHelper.NotifyUser(gui, ApplicationSettings.NotifyTimeout, "Mancano " + diff.Minutes+" minuti!", compito.Materia + " - " + compito.Descrizione, ToolTipIcon.Warning);
                }
            }
        }

    }
}
