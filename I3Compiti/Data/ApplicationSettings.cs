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
        public bool NotifyWindows
        {
            get {
                return Settings.Default.NotitfyWindows;
            }
            set {
                Settings.Default.DelayTimeMinutes = 10;
                Settings.Default.Save();
            }

        }

        public static void YOlo()
        {
            Settings.Default.DelayTimeMinutes = 10;
            Settings.Default.Save();
        }

    }
}
