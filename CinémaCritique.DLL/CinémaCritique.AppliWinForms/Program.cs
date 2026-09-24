using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CinémaCritique.DLL;

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

          Acteur JakeGyllenhaal = new Acteur("Gyllenhaal", "Jake", new DateTime(1980, 12, 19), "Américain", "Homme", new List<Film>());
            Acteur RyanGosling = new Acteur("Gosling", "Ryan", new DateTime(1980, 11, 12), "Américain", "Homme", new List<Film>());
            Realisateur RichardKelly = new Realisateur("Kelly", "Richard", new DateTime(1970, 03, 24), "Américain", "Homme", "Récompensé aux Oscars", new List<Film>());
          Film DonnieDarko = new Film("Donnie Darko", new DateTime(2001, 10, 26), "Américain", new List<Acteur> { JakeGyllenhaal }, new List<Realisateur> { RichardKelly }, 8.0f);

           

        }
    }
}
