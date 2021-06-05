using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_HEL.Classes;
using Projet_HEL.Acces;
using Projet_HEL.Gestion;
using System.Configuration;

namespace Alfa_Romeo_Garage
{
    public partial class UserControlPieces : UserControl
    {
        string connexionBD;
        private DataTable dataTableClients;
        private BindingSource bindingSourcesClients;
        string id;

        public UserControlPieces()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewClients.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            textBoxPiece.Enabled = !disponibilite;
            textBoxMarque.Enabled = !disponibilite;
            textBoxPrix.Enabled = !disponibilite;
            textBoxTVA.Enabled = !disponibilite;
            textBoxTVA.Enabled = !disponibilite;
            
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("piece"));
            dataTableClients.Columns.Add(new DataColumn("marque"));
            dataTableClients.Columns.Add(new DataColumn("prix", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("tva", System.Type.GetType("System.Double")));
            dataTableClients.Columns.Add(new DataColumn("quantite", System.Type.GetType("System.Double")));

            List<C_PART> listPieces = new G_PART(connexionBD).Lire("NAME");

            foreach (C_PART piece in listPieces)
            {
                dataTableClients.Rows.Add
                (
                    piece.ID,
                    piece.NAME,
                    piece.PRODUCER,
                    String.Format("{0:0.##}", piece.PRICE),
                    String.Format("{0:0.#}", piece.TVA),
                    piece.QUANTITY 
                ); ;
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewClients.DataSource = bindingSourcesClients;
        }

        private void UserControlPieces_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;
            RemplirDataGridView();

            if (dataGridViewClients.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);
            }

            else
            {
                ActiverBoutonsFormulaires(false);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {

        }
    }
}
