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
    public partial class UserControlVehicules : UserControl
    {
        string connexionBD;
        private DataTable dataTableV;
        private BindingSource bindingSourcesV;
        string id;

        public UserControlVehicules()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridviewV.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            textBoxImmatriculation.Enabled = !disponibilite;
            textBoxClasse.Enabled = !disponibilite;
            textBoxCouleurVehicule.Enabled = !disponibilite;
            textBoxNumeroChassis.Enabled = !disponibilite;
            dateTimePickerDatePremiereImmatriculation.Enabled = !disponibilite;
            DateTimePickerDerniereImmatriculation.Enabled = !disponibilite;

            comboBoxModele.Enabled = !disponibilite;
            comboBoxProprietaire.Enabled = !disponibilite;

            

            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableV = new DataTable();
            dataTableV.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableV.Columns.Add(new DataColumn("modeleVehicule"));
            dataTableV.Columns.Add(new DataColumn("nomProprietaire"));
            
            dataTableV.Columns.Add(new DataColumn("numeroImmatriculation"));
            dataTableV.Columns.Add(new DataColumn("datePremiereImmatriculation"));
            dataTableV.Columns.Add(new DataColumn("dateDerniereImmatriculation"));
            dataTableV.Columns.Add(new DataColumn("classe"));
            dataTableV.Columns.Add(new DataColumn("numeroChassis"));
            dataTableV.Columns.Add(new DataColumn("couleurVehicule"));
            dataTableV.Columns.Add(new DataColumn("dateEnregistrement"));

            List<C_VEHICLE> listVehicules = new G_VEHICLE(connexionBD).Lire("LAST_NAME");
            
            foreach (C_VEHICLE vehicule in listVehicules)
            {
                int idM = Convert.ToInt32(vehicule.ID_MODEL);
                int idP = Convert.ToInt32(vehicule.ID_CUSTOMER);

                C_CUSTOMER proprio = new G_CUSTOMER(connexionBD).Lire_ID(idP);
                C_MODEL modele = new G_MODEL(connexionBD).Lire_ID(idM);

                dataTableV.Rows.Add
                (
                    vehicule.ID,
                    modele.MODEL + " " + modele.ENGINE,
                    proprio.FIRST_NAME + " "+proprio.LAST_NAME,
                    vehicule.REGISTRATION,
                    Convert.ToDateTime(vehicule.FIRST_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(vehicule.FIRST_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(vehicule.FIRST_REGISTRATION).Year.ToString("D4"),
                    Convert.ToDateTime(vehicule.LAST_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(vehicule.LAST_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(vehicule.LAST_REGISTRATION).Year.ToString("D4"),
                    vehicule.CLASS,
                    vehicule.VIN_NUMBER,
                    vehicule.COLOR,
                    Convert.ToDateTime(vehicule.DATE_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(vehicule.DATE_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(vehicule.DATE_REGISTRATION).Year.ToString("D4")
                ); 
            }

            bindingSourcesV = new BindingSource();
            bindingSourcesV.DataSource = dataTableV;
            dataGridviewV.DataSource = bindingSourcesV;
        }

        private void UserControlVehicules_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;


            RemplirDataGridView();

            if (dataGridviewV.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);
            }

            else
            {
                ActiverBoutonsFormulaires(false);
            }

            List<C_MODEL> listModels = new G_MODEL(connexionBD).Lire("ID");
            List<C_CUSTOMER> listClients = new G_CUSTOMER(connexionBD).Lire("ID");

            foreach (C_CUSTOMER client in listClients)
            {
                comboBoxProprietaire.Items.Add(client.ID+" - "+client.FIRST_NAME + " " + client.LAST_NAME);
            }

            foreach (C_MODEL model in listModels)
            {
                comboBoxModele.Items.Add(model.ID + " - " + model.MODEL + " " + model.ENGINE);
            }

            
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                id = dataGridviewV.SelectedRows[0].Cells["cID"].Value.ToString();
                C_VEHICLE vehiculeModification = new G_VEHICLE(connexionBD).Lire_ID(int.Parse(id));

                textBoxImmatriculation.Text = vehiculeModification.REGISTRATION;
                textBoxClasse.Text = vehiculeModification.CLASS;
                textBoxNumeroChassis.Text = vehiculeModification.VIN_NUMBER;
                
                dateTimePickerDatePremiereImmatriculation.Value = vehiculeModification.FIRST_REGISTRATION == null ? DateTime.Today : (DateTime)vehiculeModification.FIRST_REGISTRATION;
                DateTimePickerDerniereImmatriculation.Value = vehiculeModification.LAST_REGISTRATION == null ? DateTime.Today : (DateTime)vehiculeModification.LAST_REGISTRATION;

                textBoxCouleurVehicule.Text = vehiculeModification.COLOR;

                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            textBoxImmatriculation.Text = "";
            textBoxClasse.Text = "";
            textBoxNumeroChassis.Text = "";
            textBoxCouleurVehicule.Text = "";

            dateTimePickerDatePremiereImmatriculation.Value = DateTime.Today;
            dateTimePickerDatePremiereImmatriculation.Value = DateTime.Today;

            comboBoxModele.SelectedIndex = 0;
            comboBoxProprietaire.SelectedIndex = 0;

            ActiverBoutonsFormulaires(false);
            comboBoxModele.Focus();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer le  ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridviewV.SelectedRows[0].Cells["cID"].Value;
                    new G_VEHICLE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesV.RemoveCurrent();
                }
            }
        }


        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            string[] client = comboBoxProprietaire.SelectedItem.ToString().Trim().Split('-');
            string[] modele = comboBoxModele.SelectedItem.ToString().Trim().Split('-');

            if (textBoxImmatriculation.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le l'immatriculation");
            }

            else if (id == null)
            //Ajout
            {
                int idVehiculeAjout = new G_VEHICLE(connexionBD).Ajouter
                (
                    Convert.ToInt32(modele[0]),
                    Convert.ToInt32(client[0]),
                    textBoxImmatriculation.Text,
                    dateTimePickerDatePremiereImmatriculation.Value,
                    DateTimePickerDerniereImmatriculation.Value,
                    textBoxClasse.Text,
                    textBoxNumeroChassis.Text,
                    textBoxCouleurVehicule.Text,
                    DateTime.Today
                );


                dataTableV.Rows.Add
                (
                   idVehiculeAjout.ToString(),
                   modele[1],
                   client[1],
                   textBoxImmatriculation.Text,
                   dateTimePickerDatePremiereImmatriculation.Value.Day.ToString("D2") + "/" + dateTimePickerDatePremiereImmatriculation.Value.Month.ToString("D2") + "/" + dateTimePickerDatePremiereImmatriculation.Value.Year.ToString("D4"),
                   DateTimePickerDerniereImmatriculation.Value.Day.ToString("D2") + "/" + DateTimePickerDerniereImmatriculation.Value.Month.ToString("D2") + "/" + DateTimePickerDerniereImmatriculation.Value.Year.ToString("D4"),
                   textBoxClasse.Text,
                   textBoxNumeroChassis.Text,
                   textBoxCouleurVehicule.Text,
                   DateTime.Today.Day.ToString("D2") + "/" + DateTime.Today.Month.ToString("D2") + "/" + DateTime.Today.Year.ToString("D4")
                );

            }

            else
            //Modification
            {
                int idVehiculeModification = new G_VEHICLE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    Convert.ToInt32(modele[0]),
                    Convert.ToInt32(client[0]),
                    textBoxImmatriculation.Text,
                    dateTimePickerDatePremiereImmatriculation.Value,
                    DateTimePickerDerniereImmatriculation.Value,
                    textBoxClasse.Text,
                    textBoxNumeroChassis.Text,
                    textBoxCouleurVehicule.Text,
                    DateTime.Today
                   );

                dataGridviewV.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridviewV.SelectedRows[0].Cells["cModeleVehicule"].Value = modele[1];
                dataGridviewV.SelectedRows[0].Cells["cNomProprietaire"].Value = client[1];
                dataGridviewV.SelectedRows[0].Cells["cNumeroImmatriculation"].Value = textBoxImmatriculation.Text;
                
                dataGridviewV.SelectedRows[0].Cells["cDatePremiereImmatriculation"].Value = dateTimePickerDatePremiereImmatriculation.Value.Day.ToString("D2") + "/" + dateTimePickerDatePremiereImmatriculation.Value.Month.ToString("D2") + "/" + dateTimePickerDatePremiereImmatriculation.Value.Year.ToString("D4");
                dataGridviewV.SelectedRows[0].Cells["cDateDerniereImmatriculation"].Value = DateTimePickerDerniereImmatriculation.Value.Day.ToString("D2") + "/" + DateTimePickerDerniereImmatriculation.Value.Month.ToString("D2") + "/" + DateTimePickerDerniereImmatriculation.Value.Year.ToString("D4");

                dataGridviewV.SelectedRows[0].Cells["cClasse"].Value = textBoxClasse.Text;
                dataGridviewV.SelectedRows[0].Cells["cNumeroChassis"].Value = textBoxNumeroChassis.Text;
                dataGridviewV.SelectedRows[0].Cells["cCouleurVehicule"].Value = textBoxCouleurVehicule.Text;

                dataGridviewV.SelectedRows[0].Cells["cDateEnregistrement"].Value = DateTime.Today.Day.ToString("D2") + "/" + DateTime.Today.Month.ToString("D2") + "/" + DateTime.Today.Year.ToString("D4");

                bindingSourcesV.EndEdit();
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
