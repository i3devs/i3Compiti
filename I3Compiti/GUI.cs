using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I3Compiti.Helper;
using I3Compiti.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace I3Compiti
{
    public partial class GUI : MaterialForm
    {
        public List<Compito> compiti;

        public GUI()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            compiti = NetHelper.GetCompiti();

            ClientHelper.NotifyEvents(this,compiti.ToArray<Compito>());

            //SORT DESCENDING BY DATETIME
            compiti = GUIHelper.SortDescending(compiti);

            foreach (Compito compito in compiti)
            {
                GUIHelper.AddCompitoToGUI(this, compito);
            }

            GUIHelper.NotifyUser(this,I3Compiti.Data.ApplicationSettings.NotifyTimeout, "I3Compiti", "Application Started!", ToolTipIcon.Info);

            //START TIMER CHECK!
        }

        //Form visualization methods
        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void materialListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = materialListView1.Columns[e.ColumnIndex].Width;
        }

        private void materialListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(materialListView1.SelectedIndices.Count > 0)
            {
                int index = materialListView1.SelectedIndices[0];
                
                CompitoGUI gui = new CompitoGUI(compiti[index]);
                gui.Text = "Compito n." + index + 1;
                gui.TopMost = true;
                gui.Show();
            }
           
        }
    }
}
