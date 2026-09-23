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
        private string _realisateurnom = "inconnu";
        private string _realisateurprenom = "inconnu";
        private string _acteurnom = "inconnu";
        private string _acteurprenom = "inconnu";

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

        public Film(string nom, DateTime dateCreation, string nationalite)
        {
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.nationalite = nationalite;
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

        #endregion
        #region Méthodes

        #endregion
    }
}
