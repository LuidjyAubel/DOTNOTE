using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTEPAD
{
    internal static class Program
    {
        static public Main MainForm;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             MainForm = new Main();
            //Application.Run(new Main());
            Application.Run(MainForm);
        }
    }
}
