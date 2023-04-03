using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MB_DONNEES
{
    public class Connexion
    {
        /// <summary>
        /// Méthode qui établit une connexion à la base de données MySQL BDD_MULTIBURO
        /// </summary>
        /// <returns>Un objet MySQLConnexion fermé</returns>
        public static MySqlConnection SeConnecter()
        {
            MySqlConnection connex = null;
            string chaineConnex = "server=localhost; user id=root; password=; database=bdd_multiburo;";
            try
            {
                connex = new MySqlConnection(chaineConnex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données." + e.Message);
            }
            return connex;
        }
    }
}
