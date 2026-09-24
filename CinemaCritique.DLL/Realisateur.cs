using CinemaCritique.DLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinémaCritique.DLL
{
    public class Realisateur
    {
        #region Champs privés

        private string _nom = "inconnu";
        private string _prenom = "inconnu";
        private DateTime _dateNaissance = DateTime.Now;
        private Nationalite nationalite = Nationalite.inconnu;
        private string _sexe = "inconnu";
        private string _consecration = "inconnu";
        private List<Film> lesFilms = new List<Film>();

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
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(dateNaissance), "La date de naissance ne peut pas être dans le futur.");
                _dateNaissance = value;
            }
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

        public List<Film> LesFilms
        {
            get { return lesFilms; }
            set { lesFilms = value; }
        }
        #endregion

        #region Constructeurs

        public Realisateur(string nom, string prenom, DateTime dateNaissance, Nationalite nationalite, string sexe, string consecration, List<Film> lesFilms)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.nationalite = nationalite;
            this.sexe = sexe;
            this.consecration = consecration;
            this.lesFilms = lesFilms;
            if (lesFilms != null)
            {
                foreach (Film film in lesFilms)
                {
                    if (!film.getLesRealisateurs().Contains(this))
                        film.AddRealisateur(this);
                }
            }
        }

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

        public Nationalite getNationalite()
        {
            return nationalite;
        }

        public string getSexe()
        {
            return _sexe;
        }

        public string getConsecration()
        {
            return _consecration;
        }

        public List<Film> getLesFilms()
        {
            return lesFilms;
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

        public void setNationalite(Nationalite nationalite)
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

        public void setLesFilms(List<Film> lesFilms)
        {
            this.lesFilms = lesFilms;
        }

        #endregion

        #region Méthodes

        public void AddFilm(Film monFilm)
        {
            if (!lesFilms.Contains(monFilm))
                lesFilms.Add(monFilm);
            if (!monFilm.getLesRealisateurs().Contains(this))
                monFilm.AddRealisateur(this);
        }





        #endregion






    }
}
