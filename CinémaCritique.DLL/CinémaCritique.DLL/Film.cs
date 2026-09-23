using System;
using System.Collections.Generic;
using System.Text;

namespace CinémaCritique.DLL
{
    internal class Film
    {
        #region Champs privés

        private string _nom = "inconnu";
        private DateTime _dateCreation = DateTime.Now;
        private string _nationalite = "inconnu";
        private GenreFilm genreFilm = GenreFilm.inconnu;
        private List<Acteur> lesActeurs = new List<Acteur>();
        private List<Realisateurs> lesRealisateurs = new List<Realisateurs>();
        #endregion
        #region Propriétés

        public string nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }
        public DateTime dateCreation
        {
            get { return _dateCreation; }
            set { _dateCreation = value; }
        }
        public string nationalite
        {
            get { return _nationalite; }
            set { _nationalite = value; }
        }

        #endregion
        #region Constructeurs

        public Film(string nom, DateTime dateCreation, string nationalite, List<Acteur> lesActeurs, List<Realisateurs> lesRealisateurs)
        {
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.nationalite = nationalite;
            this.lesActeurs = lesActeurs;
            this.lesRealisateurs = lesRealisateurs;
        }

        #endregion
        #region Accesseurs (getteurs / setteurs)

        public string getNom()
        {
            return _nom;
        }
        public DateTime getDateCreation()
        {
            return _dateCreation;
        }

        public string getNationalite()
        {
            return _nationalite;
        }
        public List<Acteur> getLesActeurs()
        {
            return lesActeurs;
        }
        public List<Realisateurs> getLesRealisateurs()
        {
            return lesRealisateurs;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setDateCreation(DateTime dateCreation)
        {
            this.dateCreation = dateCreation;
        }
        public void setNationalite(string nationalite)
        {
            this.nationalite = nationalite;
        }
        public void setLesActeurs(List<Acteur> lesActeurs)
        {
            this.lesActeurs = lesActeurs;
        }
        public void setLesRealisateurs(List<Realisateurs> lesRealisateurs)
        {
            this.lesRealisateurs = lesRealisateurs;
        }


        #endregion
        #region Méthodes

        public void AddActeur(Acteur monActeur)
        {
            if (!lesActeurs.Contains(monActeur)) 
                     lesActeurs.Add(monActeur);
        }

        #endregion
    }
}
