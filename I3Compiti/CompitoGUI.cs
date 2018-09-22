using I3Compiti.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace I3Compiti
{
    public partial class CompitoGUI : MaterialForm
    {
        //Calcola il tempo rimasto
        System.Timers.Timer timer;

        public Compito Data { get; private set; }
        public TimeSpan remainingDaysForDelivery { get; set; }

        public CompitoGUI(Compito compito)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);


            materialSingleLineTextFieldAuthor.Text = compito.Autore;
            materialSingleLineTextFieldDataConsegna.Text = compito.Data.ToString();
            materialSingleLineTextFieldDescription.Text = compito.Descrizione;
            materialSingleLineTextFieldMateria.Text = compito.Materia;

            Data = compito; 
            timer = new System.Timers.Timer();

        }

        private void CompitoGUI_Load(object sender, EventArgs e)
        {
            SetupTimer(30000);
            
            //FIRST TICK 
            RefreshRemainingTime(timer, null);
        }

        private void SetupTimer(int intervall)
        {
            timer.Interval = intervall;
            timer.Elapsed += RefreshRemainingTime;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void RefreshRemainingTime(object sender, ElapsedEventArgs e)
        {
            DateTime deliverDate = Data.Data;
            DateTime nowDate = DateTime.Now;

            //(EndDate - StartDate).TotalDays
            remainingDaysForDelivery = deliverDate - nowDate;
            //For cross thread operations
            this.Invoke(new MethodInvoker(delegate { RefreshLabel(); }));
        }

        private void RefreshLabel()
        {
            Console.WriteLine(remainingDaysForDelivery.ToString());
            String text = String.Format("{0} Days {1} Hours {2} Minutes", remainingDaysForDelivery.Days, remainingDaysForDelivery.Hours, remainingDaysForDelivery.Minutes);
            materialSingleLineTextFieldTempoRimanente.Text = text;
        }

        private void CompitoGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy timer object
            timer.Dispose();
        }
    }
}
