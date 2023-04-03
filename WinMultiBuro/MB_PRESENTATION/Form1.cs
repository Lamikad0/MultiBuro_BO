using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MB_METIER;
using MB_DONNEES;

namespace MB_PRESENTATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEtat.Enabled = false;
            txtEtat.Visible = false;
            texteEtat.Visible = false;
            txtNumSerie.Enabled = false;
            num_serie.Visible = false;
            txtNumSerie.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string lib = txtLibelle.Text;
            int place = (int)nbPlacee.Value;
            string serie = txtNumSerie.Text;
            string etat = txtEtat.Text;
            string type = txtType.Text;

            Ressource r = new Ressource(id, lib, place, type);
            Ressource r1 = new Ressource(id, lib, type, etat, serie);

            if (txtType.Text == "PC")
                RessourceDAO.InsertRessource(r1);
            RessourceDAO.InsertRessource(r);

            if(RessourceDAO.InsertRessource(r) == 1 | RessourceDAO.InsertRessource(r1) == 0)
            {
                MessageBox.Show("La ressource à été crée");
            }
            else
            {
                MessageBox.Show("Echec de création de la ressource");
            }
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtType.Text == "PC")
            {
                txtEtat.Enabled = true;
                txtNumSerie.Enabled = true;
                nbPlacee.Enabled = false;
                nbPlacee.Text = null;
                num_serie.Visible = true;
                txtNumSerie.Visible = true;
                txtEtat.Visible = true;
                texteEtat.Visible = true;
                txtNumSerie.Enabled = true;
            }
            else if(txtType.Text == "BI" | txtType.Text == "SR" | txtType.Text == "OS")
            {
                nbPlacee.Enabled = true;
                nbPlacee.Text = "1";
                txtEtat.Enabled = false;
                txtNumSerie.Enabled = false;
                txtEtat.SelectedIndex = -1;
                txtNumSerie.Clear();
                txtEtat.Visible = false;
                texteEtat.Visible = false;
                num_serie.Visible = false;
                txtNumSerie.Visible = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtLibelle.Clear();
            txtNumSerie.Clear();
            txtType.SelectedIndex = -1;
            txtEtat.SelectedIndex = -1;
            nbPlacee = null;
        }
    }
}
