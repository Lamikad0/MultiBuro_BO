using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_METIER
{
    public class Ressource
    {
        #region Attribus
        private int id;
        private string libelle;
        private int nbPlaces;
        private string type;
        private string etat;
        private string num_serie;
        #endregion

        #region Constructeur
        public Ressource(int unId, string unLib, int unNbPlace, string unType)
        {
            this.id = unId;
            this.libelle = unLib;
            this.type = unType;
            this.nbPlaces = unNbPlace;
            this.etat = "";
            this.num_serie = "";
        }

        public Ressource(int unId, string unLib, string unType, string unEtat, string unNumSerie)
        {
            this.id = unId;
            this.libelle = unLib;
            this.type = unType;
            this.nbPlaces = 0;
            this.etat = unEtat;
            this.num_serie = unNumSerie;
        }
        #endregion

        #region Accesseurs (get et set)
        public string GetEtat()
        {
            return this.etat;
        }

        public string GetNumSerie()
        {
            return this.num_serie;
        }

        public int GetIdRessource()
        {
            return this.id;
        }
        public string GetLib()
        {
            return this.libelle;
        }
        public string GetTypeRessource()
        {
            return this.type;
        }
        public int GetNbPlace()
        {
            return this.nbPlaces;
        }

        public void SetIdRessource(int unId)
        {
            this.id = unId;
        }

        public void SetEtat(string unEtat)
        {
            this.etat = unEtat;
        }

        public void SetNumSerie(string unNum)
        {
            this.num_serie = unNum;
        }

        public void SetLib(string unLib)
        {
            this.libelle = unLib;
        }

        public void SetTypeRessource(string unType)
        {
            this.type = unType;
        }

        public void SetNbPlace(int unNb)
        {
            this.nbPlaces = unNb;
        }
        #endregion

        #region Methodes
        #endregion
    }
}
