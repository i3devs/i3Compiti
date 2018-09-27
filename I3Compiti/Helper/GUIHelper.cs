using I3Compiti.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I3Compiti.Data;

namespace I3Compiti.Helper
{
    public static class GUIHelper
    {
        public static void AddCompitoToGUI(Compito compito)
        {
            GUI gui = ApplicationSettings.Gui;
            if (gui != null)
            {
                //new[] = get the array type autonomously
                var row = new ListViewItem(new[] { compito.Autore.ToString(), compito.Materia, compito.Descrizione.ToString(), compito.Data.ToString() });
                gui.listView1.Items.Add(row);
            }
            else
            {
                throw new NullReferenceException("First you have to start the GUI");
            }
        }

        public static void RefreshCompiti()
        {
            GUI gui = ApplicationSettings.Gui;
            if (gui != null)
            {
                //CLEAR ALL ROWS
                gui.listView1.Items.Clear();
                foreach (Compito compito in NetHelper.GetCompiti().ToArray<Compito>())
                {
                    AddCompitoToGUI(compito);
                }
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

        public static void RefreshButtonClicked(GUI gui, double animationDuration)
        {
            //START TIME
            DateTime start = DateTime.Now;
            gui.pictureBoxRefresh.Image = I3Compiti.Properties.Resources.Reload_Animated;
            RefreshCompiti();
            gui.pictureBoxRefresh.Image = I3Compiti.Properties.Resources.Reload;

            //FINISH TIME
            DateTime finish = DateTime.Now;

            MessageBox.Show(String.Format("The process took {0} milliseconds", ClientHelper.GetTimeDifference(start, finish).TotalMilliseconds), "I3Compiti - Refresh");
        }   
    }
}
