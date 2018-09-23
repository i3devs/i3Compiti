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

        //NEEDED FIELDS:
        //Tasks time delay
        //Notify enabled or not
        //Notify user x time before

        public static int TasksDelayTime
        {
            get { return Settings.Default.DelayTimeMinutes; }
            set
            {
                Settings.Default.DelayTimeMinutes = value;
                Settings.Default.Save();
            }
        }

        public static bool NotifyEnabled
        {
            get { return Settings.Default.NotifyEnabled; }
            set
            {
                Settings.Default.NotifyEnabled = value;
                Settings.Default.Save();
            }
        }

        public static int NotifyEventMinutesBefore
        {
            get { return Settings.Default.DelayTimeMinutes; }
            set
            {
                Settings.Default.DelayTimeMinutes = value;
                Settings.Default.Save();
            }
        }

        public static int NotifyTimeout
        {
            get { return Settings.Default.NotifyTimeout; }
            set
            {
                Settings.Default.NotifyTimeout = value;
                Settings.Default.Save();
            }
        }

    }
}
