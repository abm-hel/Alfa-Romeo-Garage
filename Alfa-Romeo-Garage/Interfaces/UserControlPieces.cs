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
            textBoxQuantite.Enabled = !disponibilite;
            
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("piece"));
            dataTableClients.Columns.Add(new DataColumn("marque"));
            dataTableClients.Columns.Add(new DataColumn("prix", System.Type.GetType("System.Double")));
            dataTableClients.Columns.Add(new DataColumn("tva", System.Type.GetType("System.Double")));
            dataTableClients.Columns.Add(new DataColumn("quantite", System.Type.GetType("System.Int32")));

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
            textBoxPiece.Text = "";
            textBoxMarque.Text = "";
            textBoxPrix.Text = "";
            textBoxTVA.Text = "";
            textBoxTVA.Text = "";

            ActiverBoutonsFormulaires(false);
            textBoxPiece.Focus();
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                id = dataGridViewClients.SelectedRows[0].Cells["cID"].Value.ToString();
                C_PART pieceModification = new G_PART(connexionBD).Lire_ID(int.Parse(id));

                textBoxPiece.Text = pieceModification.NAME;
                textBoxMarque.Text = pieceModification.PRODUCER;
                textBoxPrix.Text = String.Format("{0:0.##}", pieceModification.PRICE).ToString();
                textBoxTVA.Text = String.Format("{0:0.#}", pieceModification.TVA).ToString();
                textBoxQuantite.Text = pieceModification.QUANTITY.ToString();

                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer la pièce ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idSuppression = (int)dataGridViewClients.SelectedRows[0].Cells["cID"].Value;
                    new G_PART(connexionBD).Supprimer(idSuppression);
                    bindingSourcesClients.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            if (textBoxPiece.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner la pièce");
            }

            else if (id == null)
            //Ajout
            {
                int idAjout = new G_PART(connexionBD).Ajouter
                (
                    textBoxPiece.Text,
                    textBoxMarque.Text,
                    Convert.ToDouble(textBoxPrix.Text),
                    Convert.ToDouble(textBoxTVA.Text),
                    Convert.ToInt32(textBoxQuantite.Text)
                );


                dataTableClients.Rows.Add
                (
                   idAjout.ToString(),
                   textBoxPiece.Text,
                   textBoxMarque.Text,
                   textBoxPrix.Text,
                   textBoxTVA.Text,
                   textBoxQuantite.Text
                ) ;

            }

            else
            //Modification
            {
                int idModification = new G_PART(connexionBD).Modifier
                (
                   int.Parse(id),
                   textBoxPiece.Text,
                   textBoxMarque.Text,
                   Convert.ToDouble(textBoxPrix.Text),
                   Convert.ToDouble(textBoxTVA.Text),
                   Convert.ToInt32(textBoxQuantite.Text)
                 );

                dataGridViewClients.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewClients.SelectedRows[0].Cells["cPiece"].Value = textBoxPiece.Text;
                dataGridViewClients.SelectedRows[0].Cells["cMarque"].Value = textBoxMarque.Text;
                dataGridViewClients.SelectedRows[0].Cells["cPrix"].Value = textBoxPrix.Text;
                dataGridViewClients.SelectedRows[0].Cells["cTva"].Value = textBoxTVA.Text;
                dataGridViewClients.SelectedRows[0].Cells["cQuantite"].Value = textBoxQuantite.Text;

                bindingSourcesClients.EndEdit();
                id = null;

            }
            ActiverBoutonsFormulaires(true);
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }
    }
}
