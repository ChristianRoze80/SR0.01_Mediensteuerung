using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SR0._01_Mediensteuerung
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        
        [STAThread]
        
        static void Main()
        {
            bool createdNew;
            ///Einen neuen Mutex erzeugen, damit die Anwendung nur einmal gestartet werden kann.
            System.Threading.Mutex appMutex = new System.Threading.Mutex(true, Application.ProductName, out createdNew);
            ///Wenn die Erzeugung erfolgreich war
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                ///Wenn die Anwendung schon ausgeführt wird -> Hinweis-Dialog
                string msg = String.Format("Das Programm \"{0}\" wurde bereits gestartet!", Application.ProductName);
                MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
