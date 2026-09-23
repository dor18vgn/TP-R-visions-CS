using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinémaCritique.AppliWinForms
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

           Film Nightcrawler = new Film("Nightcrawler", 2014, "USA", new List<Acteur>(), new List<Realisateurs>(), 8.5f);
        }
    }
}
