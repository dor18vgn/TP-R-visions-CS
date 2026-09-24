using CinemaCritique.DLL;
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
        private Nationalite nationalite = Nationalite.inconnu;
        private GenreFilm genreFilm = GenreFilm.inconnu;
        private List<Acteur> lesActeurs = new List<Acteur>();
        private List<Realisateur> lesRealisateurs = new List<Realisateur>();
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
      

        public float note
        {
            get { return _note; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException(nameof(note), "La note doit être comprise entre 0 et 10.");
                _note = value;
            }
        }

        #endregion

        #region Constructeurs

        public Film(string nom, DateTime dateCreation, Nationalite nationalite, GenreFilm genreFilm,List<Acteur> lesActeurs, List<Realisateur> lesRealisateurs, float note)
        {
            this.nom = nom;
            this.dateCreation = dateCreation;
            this.nationalite = nationalite;
            this.genreFilm = genreFilm;
            this.lesActeurs = lesActeurs;
            this.lesRealisateurs = lesRealisateurs;
            this.note = note;
            if (lesActeurs != null)
            {
                foreach (Acteur acteur in lesActeurs)
                {
                    if (!acteur.getLesFilms().Contains(this))
                        acteur.AddFilm(this);
                }
            }
            if (lesRealisateurs != null)
            {
                foreach (Realisateur realisateur in lesRealisateurs)
                {
                    if (!realisateur.getLesFilms().Contains(this))
                        realisateur.AddFilm(this);
                }
            }
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

        public Nationalite getNationalite()
        {
            return nationalite;
        }

        public GenreFilm getGenreFilm()
        {
            return genreFilm;
        }
        public List<Acteur> getLesActeurs()
        {
            return lesActeurs;
        }
        public List<Realisateur> getLesRealisateurs()
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
        public void setNationalite(Nationalite nationalite)
        {
            this.nationalite = nationalite;
        }

        public void setGenreFilm(GenreFilm genreFilm)
        {
            this.genreFilm = genreFilm;
        }
        public void setLesActeurs(List<Acteur> lesActeurs)
        {
            this.lesActeurs = lesActeurs;
        }
        public void setLesRealisateurs(List<Realisateur> lesRealisateurs)
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
            if (!monActeur.getLesFilms().Contains(this))
                monActeur.AddFilm(this);
        }
        public void AddRealisateur(Realisateur monRealisateur)
        {
            if (!lesRealisateurs.Contains(monRealisateur))
                lesRealisateurs.Add(monRealisateur);
            if (!monRealisateur.getLesFilms().Contains(this))
                monRealisateur.AddFilm(this);
        }

        public override String ToString()
        {
            string description = "Nom : " + nom + "\nDate de création : " + dateCreation.ToString("dd/MM/yyyy") + "\nNationalité : " + nationalite;
            description += "\nNote : " + note.ToString("0.0") + "/10\nActeurs : ";
            foreach (Acteur acteur in lesActeurs)
            {
                description += "\n- " + acteur.GetNom() + " " + acteur.GetPrenom();
            }
            return description;

        }
        #endregion
    }
}
