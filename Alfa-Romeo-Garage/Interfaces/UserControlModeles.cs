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
    public partial class UserControlModeles : UserControl
    {
        string connexionBD;
        private DataTable dataTableClients;
        private BindingSource bindingSourcesClients;
        string id;

        public UserControlModeles()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewClients.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            textBoxModele.Enabled = !disponibilite;
            textBoxMotorisation.Enabled = !disponibilite;
            textBoxCarburant.Enabled = !disponibilite;
            textBoxCylindree.Enabled = !disponibilite;
            textBoxPuissanceMaximale.Enabled = !disponibilite;
            textBoxCoupleMaximal.Enabled = !disponibilite;
            textBoxVitesseMaximale.Enabled = !disponibilite;
            textBoxConsommation.Enabled = !disponibilite;
            textBoxMasse.Enabled = !disponibilite;
           
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("modele"));
            dataTableClients.Columns.Add(new DataColumn("motorisation"));
            dataTableClients.Columns.Add(new DataColumn("carburant"));
            dataTableClients.Columns.Add(new DataColumn("cylindree", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("puissanceMaximale" , System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("coupleMaximal" , System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("vitesseMaximale" , System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("consommation", System.Type.GetType("System.Double")));
            dataTableClients.Columns.Add(new DataColumn("masse", System.Type.GetType("System.Int32")));
          
            List<C_MODEL> listModeles = new G_MODEL(connexionBD).Lire("MODEL");

            foreach (C_MODEL modele in listModeles)
            {
                dataTableClients.Rows.Add
                (
                    modele.ID,
                    modele.MODEL,
                    modele.ENGINE,
                    modele.FUEL,
                    modele.DISPLACEMENT,
                    modele.POWER_MAX,
                    modele.TORQUE_MAX,
                    modele.SPEED_MAX,
                    String.Format("{0:0.#}", modele.CONSUPTION),
                    modele.WEIGHT
                );
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewClients.DataSource = bindingSourcesClients;
        }

        private void UserControlModeles_Load(object sender, EventArgs e)
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
            textBoxModele.Text = "";
            textBoxMotorisation.Text = "";
            textBoxCarburant.Text = "";
            textBoxCylindree.Text = "";
            textBoxPuissanceMaximale.Text = "";
            textBoxCoupleMaximal.Text = "";
            textBoxVitesseMaximale.Text = "";
            textBoxConsommation.Text = "";
            textBoxMasse.Text = "";

            ActiverBoutonsFormulaires(false);
            textBoxModele.Focus();
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                id = dataGridViewClients.SelectedRows[0].Cells["cID"].Value.ToString();
                C_MODEL modelModification = new G_MODEL(connexionBD).Lire_ID(int.Parse(id));

                textBoxModele.Text = modelModification.MODEL;
                textBoxMotorisation.Text = modelModification.ENGINE;
                textBoxCarburant.Text = modelModification.FUEL;
                textBoxCylindree.Text = modelModification.DISPLACEMENT.ToString();
                textBoxPuissanceMaximale.Text = modelModification.POWER_MAX.ToString();
                textBoxCoupleMaximal.Text = modelModification.TORQUE_MAX.ToString();
                textBoxVitesseMaximale.Text = modelModification.SPEED_MAX.ToString();
                textBoxConsommation.Text = String.Format("{0:0.#}", modelModification.CONSUPTION).ToString();
                textBoxMasse.Text = modelModification.WEIGHT.ToString();

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
                if (MessageBox.Show("Voullez-vous vraiment supprimer le modele ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridViewClients.SelectedRows[0].Cells["cID"].Value;
                    new G_MODEL(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesClients.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            if (textBoxModele.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le modele");
            }

            else if (id == null)
            //Ajout
            {
                int idClientAjout = new G_MODEL(connexionBD).Ajouter
                (
                    textBoxModele.Text,
                    textBoxMotorisation.Text,
                    textBoxCarburant.Text,
                    Convert.ToInt32(textBoxCylindree.Text),
                    Convert.ToInt32(textBoxPuissanceMaximale.Text),
                    Convert.ToInt32(textBoxCoupleMaximal.Text),
                    Convert.ToInt32(textBoxVitesseMaximale.Text),
                    Convert.ToSingle(textBoxConsommation.Text),
                    Convert.ToInt32(textBoxMasse.Text)
                );


                dataTableClients.Rows.Add
                (
                   idClientAjout.ToString(),
                   textBoxModele.Text,
                   textBoxMotorisation.Text,
                   textBoxCarburant.Text,
                   textBoxCylindree.Text,
                   textBoxPuissanceMaximale.Text,
                   textBoxCoupleMaximal.Text,
                   textBoxVitesseMaximale.Text,
                   textBoxConsommation.Text,
                   textBoxMasse.Text
                );

            }

            else
            //Modification
            {
                int idClientModification = new G_MODEL(connexionBD).Modifier
                (
                    int.Parse(id),
                    textBoxModele.Text,
                    textBoxMotorisation.Text,
                    textBoxCarburant.Text,
                    Convert.ToInt32(textBoxCylindree.Text),
                    Convert.ToInt32(textBoxPuissanceMaximale.Text),
                    Convert.ToInt32(textBoxCoupleMaximal.Text),
                    Convert.ToInt32(textBoxVitesseMaximale.Text),
                    Convert.ToSingle(textBoxConsommation.Text),
                    Convert.ToInt32(textBoxMasse.Text)
                 );

                dataGridViewClients.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewClients.SelectedRows[0].Cells["cModele"].Value = textBoxModele.Text;
                dataGridViewClients.SelectedRows[0].Cells["cMotorisation"].Value = textBoxMotorisation.Text;
                dataGridViewClients.SelectedRows[0].Cells["cCarburant"].Value = textBoxCarburant.Text;
                dataGridViewClients.SelectedRows[0].Cells["cCylindree"].Value = textBoxCylindree.Text;
                dataGridViewClients.SelectedRows[0].Cells["cPuissanceMaximale"].Value = textBoxPuissanceMaximale.Text;
                dataGridViewClients.SelectedRows[0].Cells["cCoupleMaximal"].Value = textBoxCoupleMaximal.Text;
                dataGridViewClients.SelectedRows[0].Cells["cVitesseMaximale"].Value = textBoxVitesseMaximale.Text;
                dataGridViewClients.SelectedRows[0].Cells["cConsommation"].Value = textBoxConsommation.Text;
                dataGridViewClients.SelectedRows[0].Cells["cMasse"].Value = textBoxMasse.Text;


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
