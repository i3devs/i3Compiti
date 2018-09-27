using I3Compiti.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3Compiti.Data
{
    public static class ApplicationSettings
    {

        //GUI OBJECT
        private static GUI gui;

        public static GUI Gui
        {
            get { return gui; }
            set
            {
                if (value == gui)
                    return;
                gui = value;
            }
        }

        //SETTINGS OBJECT
        private static Settings settingsGUI;

        public static Settings SettingsGUI
        {
            get { return settingsGUI; }
            set
            {
                if (value == settingsGUI)
                    return;
                settingsGUI = value;
            }
        }

        //NEEDED FIELDS:
        //Tasks time delay
        //Notify enabled or not
        //Notify user x time before

        public static int TasksDelayTime
        {
            get { return Properties.Settings.Default.DelayTimeMinutes; }
            set
            {
                Properties.Settings.Default.DelayTimeMinutes = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool NotifyEnabled
        {
            get { return Properties.Settings.Default.NotifyEnabled; }
            set
            {
                Properties.Settings.Default.NotifyEnabled = value;
                Properties.Settings.Default.Save();
            }
        }

        public static int NotifyEventMinutesBefore
        {
            get { return Properties.Settings.Default.NotifyEventMinutesBefore; }
            set
            {
                Properties.Settings.Default.NotifyEventMinutesBefore = value;
                Properties.Settings.Default.Save();
            }
        }

        public static int NotifyTimeout
        {
            get { return Properties.Settings.Default.NotifyTimeout; }
            set
            {
                Properties.Settings.Default.NotifyTimeout = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool HideToTray
        {
            get { return Properties.Settings.Default.HideToTray; }
            set
            {
                Properties.Settings.Default.HideToTray = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
