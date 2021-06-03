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

        private void ActiverBoutonsFormulaires(bool a)
        {
            dataGridViewClients.Enabled = a;
            buttonAjouterClient.Enabled = buttonEditerClient.Enabled = buttonSupprimerClient.Enabled = a;
            textBoxPrenom.Enabled = textBoxNom.Enabled = dateTimePickerDateNaissance.Enabled = textBoxNumeroNational.Enabled = textBoxNumeroNational.Enabled = textBoxRue.Enabled = textBoxNumero.Enabled = textBoxCodePostal.Enabled = textBoxVille.Enabled = textBox1.Enabled = textBoxNumeroTelephone.Enabled = textBoxAdresseEmail.Enabled = !a;
            buttonConfirmerClient.Enabled = buttonAnnulerClient.Enabled = !a;
        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;   
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
