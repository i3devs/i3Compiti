using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I3Compiti.Data;
using MaterialSkin;
using MaterialSkin.Controls;

namespace I3Compiti
{
    public partial class Settings : MaterialForm
    {
        public Settings()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            SetSettings();
        }

        public void SetSettings()
        {
            //SET SETTINGS
            materialCheckBoxNotifyWindows.Checked = ApplicationSettings.NotifyEnabled;
            materialSingleLineTextFieldPopupHide.Text = ApplicationSettings.NotifyTimeout.ToString();
            materialSingleLineTextFieldHomework.Text = ApplicationSettings.TasksDelayTime.ToString();
            materialSingleLineTextFieldNotifyEvents.Text = ApplicationSettings.NotifyEventMinutesBefore.ToString();
        }

        private void materialRaisedButtonApply_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            ApplicationSettings.NotifyEnabled = materialCheckBoxNotifyWindows.Checked;

            try
            {
                ApplicationSettings.NotifyTimeout = Convert.ToInt32(materialSingleLineTextFieldPopupHide.Text);
            }
            catch (FormatException ex)
            {
                errors.Add("Notify timeout");
                materialSingleLineTextFieldPopupHide.Text = ApplicationSettings.NotifyTimeout.ToString();
            }

            try
            {
                ApplicationSettings.TasksDelayTime = Convert.ToInt32(materialSingleLineTextFieldHomework.Text);
            }
            catch (FormatException ex)
            {
                errors.Add("Homework delay");
                materialSingleLineTextFieldHomework.Text = ApplicationSettings.TasksDelayTime.ToString();
            }

            try
            {
                ApplicationSettings.NotifyEventMinutesBefore = Convert.ToInt32(materialSingleLineTextFieldNotifyEvents.Text);
            }
            catch (FormatException ex)
            {
                errors.Add("Notify Events before delay");
                materialSingleLineTextFieldNotifyEvents.Text = ApplicationSettings.NotifyEventMinutesBefore.ToString();
            }

            if (errors.Count > 0)
            {
                //WRITE MESSAGEBOX
                string errorFormatted = "";
                foreach (string error in errors)
                {
                    errorFormatted += "-" + error + "\n";
                }

                MessageBox.Show("There are errors in your inputs.. \n " + errorFormatted, "I3Compiti - Settings");
            }
            else
            {
                this.Close();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApplicationSettings.SettingsGUI = null;
        }
    }
}
