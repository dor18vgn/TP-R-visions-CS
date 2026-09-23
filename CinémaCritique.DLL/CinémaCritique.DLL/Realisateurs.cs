using System;
using System.Collections.Generic;
using System.Text;

namespace CinémaCritique.DLL
{
    internal class Realisateurs
    {
        #region Champs privés

        private string _nom = "inconnu";
        private string _prenom = "inconnu";
        private DateTime _dateNaissance = DateTime.Now;
        private string _nationalite = "inconnu";
        private string _sexe = "inconnu";
        private string _consecration = "inconnu";

        #endregion
        #region Propriétés

        public string nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime dateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public string nationalite
        {
            get { return _nationalite; }
            set { _nationalite = value; }
        }

        public string sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        public string consecration
        {
            get { return _consecration; }
            set { _consecration = value; }
        }

        #endregion
        #region Constructeurs

        #endregion
        #region Accesseurs (getteurs / setteurs)

        public string getNom()
        {
            return _nom;
        }

        public string getPrenom()
        {
            return _prenom;
        }

        public DateTime getDateNaissance()
        {
            return _dateNaissance;
        }

        public string getNationalite()
        {
            return _nationalite;
        }

        public string getSexe()
        {
            return _sexe;
        }

        public string getConsecration()
        {
            return _consecration;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void setDateNaissance(DateTime dateNaissance)
        {
            this.dateNaissance = dateNaissance;
        }

        public void setNationalite(string nationalite)
        {
            this.nationalite = nationalite;
        }

        public void setSexe(string sexe)
        {
            this.sexe = sexe;
        }

        public void setConsecration(string consecration)
        {
            this.consecration = consecration;
        }

        #endregion
        #region Méthodes

        public Realisateurs(string nom, string prenom, DateTime dateNaissance, string nationalite, string sexe, string consecration)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.nationalite = nationalite;
            this.sexe = sexe;
            this.consecration = consecration;

        }



        #endregion






    }
}
