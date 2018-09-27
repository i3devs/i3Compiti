using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using I3Compiti.Data;
using I3Compiti.Helper;
using I3Compiti.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace I3Compiti
{
    public partial class GUI : MaterialForm
    {
        public List<Compito> compiti;
        public System.Timers.Timer HomeworkTimer;
        
        public GUI()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue400, TextShade.WHITE);

            HomeworkTimer = new System.Timers.Timer();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            ApplicationSettings.Gui = this;

            compiti = NetHelper.GetCompiti();

            //SORT DESCENDING BY DATETIME
            compiti = GUIHelper.SortDescending(compiti);

            foreach (Compito compito in compiti)
            {
                Console.WriteLine("YOLO");
                GUIHelper.AddCompitoToGUI(compito);
            }

            GUIHelper.NotifyUser(this,I3Compiti.Data.ApplicationSettings.NotifyTimeout, "I3Compiti", "Application Started!", ToolTipIcon.Info);
            ClientHelper.NotifyEvents(this, compiti.ToArray<Compito>());
            
            //TODO: START TIMER CHECK!
            HomeworkTimer.Interval = 5000;
            HomeworkTimer.AutoReset = true;
            HomeworkTimer.Enabled = false;
            HomeworkTimer.Elapsed += RefreshCompiti;


            materialLabelBuild.ForeColor = Color.Red;
        }

        private void RefreshCompiti(object sender, ElapsedEventArgs e)
        {
            if (ApplicationSettings.Gui != null)
            {
                GUIHelper.RefreshCompiti();
                Console.WriteLine("REFRESHED " + DateTime.Now);
            }
        }

        //Form visualization methods
        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void materialListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                CompitoGUI gui = new CompitoGUI(compiti[index]);
                gui.Text = "Compito n." + index + 1;
                gui.TopMost = true;
                gui.Show();
            }
           
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            //REFRESH
            GUIHelper.RefreshButtonClicked(this,3000);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ApplicationSettings.SettingsGUI == null)
            {
                ApplicationSettings.SettingsGUI = new Settings();
                ApplicationSettings.SettingsGUI.Show();
            }
            else
            {
                ApplicationSettings.SettingsGUI.TopMost = true;
            }
        }
    }
}
