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
            dataGridView.Enabled = disponibilite;
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

            List<C_VEHICLE> listVehicules = new G_VEHICLE(connexionBD).Lire("REGISTRATION");

            

            foreach (C_VEHICLE vehicule in listVehicules)
            {
                int idM = Convert.ToInt32(vehicule.ID_MODEL);
                int idP = Convert.ToInt32(vehicule.ID_CUSTOMER);

                C_CUSTOMER proprio = new G_CUSTOMER(connexionBD).Lire_ID(idP);
                C_MODEL modele = new G_MODEL(connexionBD).Lire_ID(idM);

                dataTableV.Rows.Add
                (
                    vehicule.ID,
                    modele.MODEL,
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
            dataGridView.DataSource = bindingSourcesV;
        }

        private void UserControlVehicules_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;


            RemplirDataGridView();

            if (dataGridView.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);

            }

            else
            {
                ActiverBoutonsFormulaires(false);

            }
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
