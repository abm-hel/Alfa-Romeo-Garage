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
    public partial class UserControlIntervetions : UserControl
    {
        string connexionBD;
        private DataTable dataTableClients;
        private BindingSource bindingSourcesClients;
        string id;

        public UserControlIntervetions()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewClients.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            textBoxIntervention.Enabled = !disponibilite;
            textBoxDuree.Enabled = !disponibilite;
            textBoxPrixHeure.Enabled = !disponibilite;
            textBoxTVA.Enabled = !disponibilite;

            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("intervention"));
            dataTableClients.Columns.Add(new DataColumn("duree"));
            dataTableClients.Columns.Add(new DataColumn("prix"));
            dataTableClients.Columns.Add(new DataColumn("tva"));
            dataTableClients.Columns.Add(new DataColumn("prixTotal"));

            List<C_INTERVENTION> listIntervetions = new G_INTERVENTION(connexionBD).Lire("NAME");

            foreach (C_INTERVENTION intervention in listIntervetions)
            {
                dataTableClients.Rows.Add
                (
                    intervention.ID,
                    intervention.DESCRIPTION,
                    intervention.NUMBER_HOURS.ToString()+" heure(s)",
                    String.Format("{0:0.00}", intervention.PRICE_HOUR).ToString()+" €",
                    String.Format("{0:0.0}", intervention.TVA).ToString()+ " %",
                    String.Format("{0:00.00}", intervention.PRIC).ToString()+ " €"
                ); ;
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewClients.DataSource = bindingSourcesClients;
        }

        private void UserControlIntervetions_Load(object sender, EventArgs e)
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
            textBoxIntervention.Text = "";
            textBoxDuree.Text = "";
            textBoxPrixHeure.Text = "";
            textBoxTVA.Text = "";

            ActiverBoutonsFormulaires(false);
            textBoxIntervention.Focus();
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                id = dataGridViewClients.SelectedRows[0].Cells["cID"].Value.ToString();
                C_INTERVENTION modification = new G_INTERVENTION(connexionBD).Lire_ID(int.Parse(id));

                textBoxIntervention.Text = modification.DESCRIPTION;
                textBoxDuree.Text = modification.NUMBER_HOURS.ToString();
                textBoxPrixHeure.Text =  modification.PRICE_HOUR.ToString();
                textBoxTVA.Text = modification.TVA.ToString();
               
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
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'intervention ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idSuppression = (int)dataGridViewClients.SelectedRows[0].Cells["cID"].Value;
                    new G_INTERVENTION(connexionBD).Supprimer(idSuppression);
                    bindingSourcesClients.RemoveCurrent();
                }
            }
        }


        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            if (textBoxIntervention.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner l'intervention");
            }

            else if (id == null)
            //Ajout
            {
                int d = Convert.ToInt32(textBoxDuree.Text);
                double ph = Convert.ToDouble(textBoxPrixHeure.Text);
                double tva = Convert.ToDouble(textBoxTVA.Text);
                double pt = ph * d + (ph * d * (tva / 100));

                int idAjout = new G_INTERVENTION(connexionBD).Ajouter
                (
                    textBoxIntervention.Text,
                    d,
                    ph,
                    (double)pt,
                    tva
                );

                dataTableClients.Rows.Add
                (
                   idAjout.ToString(),
                   textBoxIntervention.Text,
                   d.ToString()+" heure(s)",
                   String.Format("{0:0.00}", ph).ToString() + " €",
                   tva.ToString() + " %",
                   string.Format("{0:0.00}", pt).ToString() + " €"
                );

            }

            else

            //Modification
            {
                int d = Convert.ToInt32(textBoxDuree.Text);
                double ph = Convert.ToDouble(textBoxPrixHeure.Text);
                double tva = Convert.ToDouble(textBoxTVA.Text);
                double pt = ph * d + (ph * d * (tva / 100));

                int idModification = new G_INTERVENTION(connexionBD).Modifier
                (
                    int.Parse(id),
                    textBoxIntervention.Text,
                    d,
                    ph,
                    (double)pt,
                    tva
                 );

                dataGridViewClients.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewClients.SelectedRows[0].Cells["cIntervention"].Value = textBoxIntervention.Text;
                dataGridViewClients.SelectedRows[0].Cells["cDuree"].Value = d.ToString() + " heure(s)";
                dataGridViewClients.SelectedRows[0].Cells["cPrix"].Value = String.Format("{0:0.00}", ph).ToString() + " €";
                dataGridViewClients.SelectedRows[0].Cells["cTVA"].Value = tva.ToString() + " %";
                dataGridViewClients.SelectedRows[0].Cells["cPrixTotal"].Value = String.Format("{0:0.00}", pt).ToString() + " €";

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
