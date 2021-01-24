using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Flyer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectorWindow());
        }
    }


    //
    // Statische Klasse für die Software-Version
    //
    public static class FlyerVersion
    {
        public const string Number = "1.00 RC1";
    }
}
