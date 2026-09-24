using CinemaCritique.DLL;
using System;
using System.Collections.Generic;

namespace CinémaCritique.DLL
{
    public class Acteur
    {
        #region Champs Privées
        private string _nom = "inconnu";
        private string _prenom = "inconnu";
        private DateTime _dateNaissance = DateTime.Now;
        private Nationalite nationalite = Nationalite.inconnu;
        private Sexe sexe = Sexe.inconnu;
        private List<Film> lesFilms = new List<Film>();
        #endregion

        #region Propriétés

        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime dateNaissance
        {
            get { return _dateNaissance; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(dateNaissance), "La date de naissance ne peut pas être dans le futur.");
                _dateNaissance = value;
            }
        }


        #endregion

        #region Constructeurs

        public Acteur(string nom, string prenom, DateTime dateNaissance, Nationalite nationalite, Sexe sexe, List<Film> lesFilms)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._dateNaissance = dateNaissance;
            this.nationalite = nationalite;
            this.sexe = sexe;
            this.lesFilms = lesFilms;
            if (lesFilms != null)
            {
                foreach (Film unFilm in lesFilms)
                {
                    if (!unFilm.getLesActeurs().Contains(this))
                        unFilm.AddActeur(this);
                }
            }
        }

        
        #endregion

        #region Acceseurs (getteurs / setteurs)

        public string GetNom()
        {
            return _nom;
        }
        public string GetPrenom()
        {
            return _prenom;
        }
        public DateTime GetDateNaissance()
        {
            return _dateNaissance;
        }
        public Nationalite GetNationalite()
        {
            return nationalite;
        }
        public Sexe getSexe()
        {
            return sexe;
        }
        public List<Film> getLesFilms()
        {
            return lesFilms;
        }


        public void SetNom(string nom)
        {
            _nom = nom;
        }
        public void SetPrenom(string prenom)
        {
            _prenom = prenom;
        }
        public void SetDateNaissance(DateTime dateNaissance)
        {
            _dateNaissance = dateNaissance;
        }
        public void SetNationalite(Nationalite nationalite)
        {
            nationalite = nationalite;
        }
        public void SetSexe(Sexe sexe)
        {
            sexe = sexe;
        }

        #endregion

        #region Méthodes

        public void AddFilm(Film unFilm)
        {
            if (lesFilms != null && !lesFilms.Contains(unFilm))
                lesFilms.Add(unFilm);
            if (unFilm != null && !unFilm.getLesActeurs().Contains(this))
                unFilm.AddActeur(this);
        }

        #endregion
    }
}
