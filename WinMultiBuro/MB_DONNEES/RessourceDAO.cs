using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MB_METIER;
using System.Windows.Forms;

namespace MB_DONNEES
{
    public static class RessourceDAO
    {
        /// <summary>
        /// Permet d'ajouter une ressource dans la table Ressource
        /// </summary>
        /// <param name=“uneRessource">Objet Ressource à ajouter</param>
        public static int InsertRessource(Ressource R)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO ressource(id_ress, lib_ress, nb_place_ress, num_serie_ress, etat_ress, code_type)"
                + "VALUES (@id, @libelle, @places, @num_serie, @etat, @type)";
                cmdInsert.Parameters.AddWithValue("@id", R.GetIdRessource());
                cmdInsert.Parameters.AddWithValue("@libelle", R.GetLib());
                cmdInsert.Parameters.AddWithValue("@places", Convert.ToInt32(R.GetNbPlace()));
                cmdInsert.Parameters.AddWithValue("@num_serie", R.GetNumSerie());
                cmdInsert.Parameters.AddWithValue("@etat", R.GetEtat());
                cmdInsert.Parameters.AddWithValue("@type", R.GetTypeRessource());
                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);
                return 0;
            }
        }
    }
}
