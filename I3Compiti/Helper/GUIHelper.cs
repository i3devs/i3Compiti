using I3Compiti.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I3Compiti.Helper
{
    public static class GUIHelper
    {
        public static void AddCompitoToGUI(GUI gui, Compito compito)
        {
            if (gui != null)
            {
                //new[] = get the array type autonomously
                var row = new ListViewItem(new[] { compito.Autore.ToString(), compito.Materia, compito.Descrizione.ToString(), compito.Data.ToString() });
                gui.materialListView1.Items.Add(row);
            }
            else
            {
                throw new NullReferenceException("First you have to start the GUI");
            }
        }

        public static void NotifyUser(GUI gui,int timeout,string title, string description,ToolTipIcon icon)
        {
            gui.notifyIcon1.ShowBalloonTip(timeout, title, description, icon);
        }

        public static List<Compito> SortDescending(List<Compito> compiti)
        {
            compiti.Sort((a, b) => a.Data.CompareTo(b.Data));
            return compiti;
        }

    }
}
