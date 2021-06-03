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
    public partial class UserControlClients : UserControl
    {
        string connexionBD;
        private DataTable dataTableClients;
        private BindingSource bindingSourcesClients;
      
        public UserControlClients()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewClients.Enabled = disponibilite;
            buttonAjouter.Enabled = buttonEditer.Enabled = buttonSupprimerClient.Enabled = disponibilite;
            textBoxPrenom.Enabled = textBoxNom.Enabled = dateTimePickerDateNaissance.Enabled = textBoxNumeroNational.Enabled = textBoxNumeroNational.Enabled = textBoxRue.Enabled = textBoxNumero.Enabled = textBoxCodePostal.Enabled = textBoxVille.Enabled = textBoxPays.Enabled = textBoxNumeroTelephone.Enabled = textBoxAdresseEmail.Enabled = !disponibilite;
            buttonConfirmer.Enabled = buttonAnnuler.Enabled = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("dateNaissance"));
            dataTableClients.Columns.Add(new DataColumn("nomPrenom"));
            dataTableClients.Columns.Add(new DataColumn("numeroNational"));
            dataTableClients.Columns.Add(new DataColumn("adresse"));
            dataTableClients.Columns.Add(new DataColumn("adresseEmail"));
            dataTableClients.Columns.Add(new DataColumn("numeroTelephone"));

            List<C_CUSTOMER> listClients = new G_CUSTOMER(connexionBD).Lire("nomPrenom");

            foreach (C_CUSTOMER client in listClients)
            {
                dataTableClients.Rows.Add
                (
                    client.ID,
                    client.FIRST_NAME + " " + client.LAST_NAME,
                    client.BIRTH_DATE.ToString(),
                    client.NATIONAL_NUMBER,
                    client.ADDRESS + " " + client.NUMBER + ", " + client.POSTAL_CODE + " " + client.CITY + " " + client.COUNTRY,
                    client.EMAIL_ADDRESS,
                    client.PHONE_NUMBER
                );
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewClients.DataSource = bindingSourcesClients;
        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;

            RemplirDataGridView();

            if (dataGridViewClients.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);
                return;
            }

            if (dataGridViewClients.Rows.Count == 0)
            {
                ActiverBoutonsFormulaires(false);
                return;
            }
        }

        private void buttonConfirmerClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnulerClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditerClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {

        }

      
    }
}
