using System;
using System.Collections.Generic;
using System.Text;

namespace CinémaCritique.DLL
{
    public class Film
    {
        #region Champs privés

        private string _nom = "inconnu";
        private DateTime _dateCreation = DateTime.Now;
        private string _nationalite = "inconnu";
        private GenreFilm genreFilm = GenreFilm.inconnu;
        private List<Acteur> lesActeurs = new List<Acteur>();
        private List<Realisateurs> lesRealisateurs = new List<Realisateurs>();
        private float _note = 0;
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

        public float note
        {
            get { return _note; }
            set { _note = value; }
        }

        #endregion
        #region Constructeurs

        public Film(string nom, DateTime dateCreation, string nationalite, List<Acteur> lesActeurs, List<Realisateurs> lesRealisateurs, float note)
        {
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.nationalite = nationalite;
            this.lesActeurs = lesActeurs;
            this.lesRealisateurs = lesRealisateurs;
            this.note = note;
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
        public float getNote()
        {
            return _note;
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
        public void setNote(float note)
        {
            this.note = note;
        }

        #endregion
        #region Méthodes

        public void AddActeur(Acteur monActeur)
        {
            if (!lesActeurs.Contains(monActeur)) 
                     lesActeurs.Add(monActeur);
        }
        public void AddRealisateur(Realisateurs monRealisateur)
        {
            if (!lesRealisateurs.Contains(monRealisateur))
                lesRealisateurs.Add(monRealisateur);
        }

        #endregion
    }
}
