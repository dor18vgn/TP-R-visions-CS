namespace CinémaCritique.DLL
{
    public class Acteur
    {
        #region Champs Privées
        private string _nom = "inconnu";
        private string _prenom = "inconnu";
        private string _dateNaissance = "inconnu";
        private string _nationalite = "inconnu";
        private string _sexe = "inconnu";
        private string _roleCulte = "inconnu";
        #endregion

        #region Propriétés

        #endregion
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

        public string dateNaissance
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

        public string roleCulte
        {
            get { return _roleCulte; }
            set { _roleCulte = value; }
        }

        #region Constructeurs

        public Acteur(string nom, string prenom, string dateNaissance, string nationalite, string sexe, string roleCulte)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._dateNaissance = dateNaissance;
            this._nationalite = nationalite;
            this._sexe = sexe;
            this._roleCulte = roleCulte;
        }

        
        #endregion

        #region Acceseurs (getteurs / setteurs)

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string nom)
        {
            _nom = nom;
        }

        public string GetPrenom()
        {
            return _prenom;
        }

        public void SetPrenom(string prenom)
        {
            _prenom = prenom;
        }

        public string GetDateNaissance()
        {
            return _dateNaissance;
        }

        public void SetDateNaissance(string dateNaissance)
        {
            _dateNaissance = dateNaissance;
        }

        public string GetNationalite()
        {
            return _nationalite;
        }

        public void SetNationalite(string nationalite)
        {
            _nationalite = nationalite;
        }

        public string GetSexe()
        {
            return _sexe;
        }
        public void SetSexe(string sexe)
        {
            _sexe = sexe;
        }

        public string GetRoleCulte()
        {
            return _roleCulte;
        }

        public void SetRoleCulte(string roleCulte)
        {
            _roleCulte = roleCulte;
        }

        #endregion

        #region Méthodes

        #endregion
    }
}
