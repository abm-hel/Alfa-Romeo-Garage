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
        string id;




        public UserControlClients()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewClients.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimerClient.Visible = disponibilite;
            
            textBoxPrenom.Enabled = !disponibilite;
            textBoxNom.Enabled = !disponibilite;
            dateTimePickerDateNaissance.Enabled = !disponibilite;
            textBoxNumeroNational.Enabled = !disponibilite;
            textBoxNumeroNational.Enabled = !disponibilite;
            textBoxRue.Enabled = !disponibilite;
            textBoxNumero.Enabled = !disponibilite;
            textBoxCodePostal.Enabled = !disponibilite;
            textBoxVille.Enabled = !disponibilite;
            textBoxPays.Enabled = !disponibilite;
            textBoxNumeroTelephone.Enabled = !disponibilite;
            textBoxAdresseEmail.Enabled = !disponibilite;
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("nomPrenom"));
            dataTableClients.Columns.Add(new DataColumn("dateNaissance"));
            dataTableClients.Columns.Add(new DataColumn("numeroNational"));
            dataTableClients.Columns.Add(new DataColumn("adresse"));
            dataTableClients.Columns.Add(new DataColumn("adresseEmail"));
            dataTableClients.Columns.Add(new DataColumn("numeroTelephone"));
            dataTableClients.Columns.Add(new DataColumn("dateEnregistrement"));

            List<C_CUSTOMER> listClients = new G_CUSTOMER(connexionBD).Lire("LAST_NAME");
            
           foreach (C_CUSTOMER client in listClients)
            {
                dataTableClients.Rows.Add
                (
                    client.ID,
                    client.LAST_NAME + " " + client.FIRST_NAME,
                    Convert.ToDateTime(client.BIRTH_DATE).Day.ToString("D2")+"/"+ Convert.ToDateTime(client.BIRTH_DATE).Month.ToString("D2") + "/"+ Convert.ToDateTime(client.BIRTH_DATE).Year.ToString("D4"),
                    client.NATIONAL_NUMBER,
                    client.ADDRESS + " " + client.NUMBER + ", " + client.POSTAL_CODE + " " + client.CITY + " " + client.COUNTRY,
                    client.EMAIL_ADDRESS,
                    client.PHONE_NUMBER,
                    Convert.ToDateTime(client.DATA_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Year.ToString("D4")
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
               
            }

            else
            {
                ActiverBoutonsFormulaires(false);
                
            }
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            
            textBoxPrenom.Text = "";
            textBoxNom.Text = "";
            textBoxNumeroNational.Text = "";
            textBoxNumeroNational.Text = "";
            textBoxRue.Text = "";
            textBoxNumero.Text = "";
            textBoxCodePostal.Text = "";
            textBoxVille.Text = "";
            textBoxPays.Text = "";
            textBoxNumeroTelephone.Text = "";
            textBoxAdresseEmail.Text = "";
            dateTimePickerDateNaissance.Value = DateTime.Today;

            ActiverBoutonsFormulaires(false);
            textBoxNom.Focus();
        }

        private void buttonEditerClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                id = dataGridViewClients.SelectedRows[0].Cells["cID"].Value.ToString();
                C_CUSTOMER clientModification = new G_CUSTOMER(connexionBD).Lire_ID(int.Parse(id));

                textBoxNom.Text = clientModification.LAST_NAME;
                textBoxPrenom.Text = clientModification.FIRST_NAME;
                textBoxNumeroNational.Text = clientModification.NATIONAL_NUMBER;
                dateTimePickerDateNaissance.Value = clientModification.BIRTH_DATE == null ? DateTime.Today : (DateTime)clientModification.BIRTH_DATE;
                textBoxRue.Text = clientModification.ADDRESS;
                textBoxNumero.Text = clientModification.NUMBER;
                textBoxCodePostal.Text = clientModification.POSTAL_CODE;
                textBoxVille.Text = clientModification.CITY;
                textBoxPays.Text = clientModification.COUNTRY;
                textBoxNumeroTelephone.Text = clientModification.PHONE_NUMBER;
                textBoxAdresseEmail.Text = clientModification.EMAIL_ADDRESS;
              
                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer le client ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridViewClients.SelectedRows[0].Cells["cID"].Value;
                    new G_CUSTOMER(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesClients.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmerClient_Click(object sender, EventArgs e)
        {
           

            if (textBoxNom.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le nom");
            }

            else if (id == null)
            //Ajout
            {
                int idClientAjout = new G_CUSTOMER(connexionBD).Ajouter
                (
                    textBoxPrenom.Text,
                    textBoxNom.Text,
                    dateTimePickerDateNaissance.Value,
                    textBoxRue.Text,
                    textBoxNumero.Text,
                    textBoxCodePostal.Text,
                    textBoxVille.Text,
                    textBoxPays.Text,
                    textBoxNumeroTelephone.Text,
                    textBoxAdresseEmail.Text,
                    textBoxNumeroNational.Text,
                    DateTime.Today
                );
                

                dataTableClients.Rows.Add
                (
                   idClientAjout.ToString(),
                   textBoxNom.Text + " " + textBoxPrenom.Text,
                   dateTimePickerDateNaissance.Value.Day.ToString("D2")+"/"+ dateTimePickerDateNaissance.Value.Month.ToString("D2") + "/" + dateTimePickerDateNaissance.Value.Year.ToString("D4"),
                   textBoxNumeroNational.Text,
                   textBoxRue.Text +" " + textBoxNumero.Text + ", " + textBoxCodePostal.Text + " " + textBoxVille.Text + " " + textBoxPays.Text,
                   textBoxAdresseEmail.Text,
                   textBoxNumeroTelephone.Text,
                   DateTime.Today.Day.ToString("D2") + "/" + DateTime.Today.Month.ToString("D2") + "/" + DateTime.Today.Year.ToString("D4")
                );

            }
            
            else
            //Modification
            {
               int idClientModification = new G_CUSTOMER(connexionBD).Modifier
                (
                   int.Parse(id),
                    textBoxPrenom.Text,
                    textBoxNom.Text,
                    dateTimePickerDateNaissance.Value,
                    textBoxRue.Text,
                    textBoxNumero.Text,
                    textBoxVille.Text,
                    textBoxCodePostal.Text,
                    textBoxPays.Text,
                    textBoxNumeroTelephone.Text,
                    textBoxAdresseEmail.Text,
                    textBoxNumeroNational.Text,
                    DateTime.Today
                );

                dataGridViewClients.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewClients.SelectedRows[0].Cells["cNomPrenom"].Value = textBoxNom.Text + " " + textBoxPrenom.Text;
                dataGridViewClients.SelectedRows[0].Cells["cDateNaissance"].Value = dateTimePickerDateNaissance.Value.Day.ToString("D2") + "/" + dateTimePickerDateNaissance.Value.Month.ToString("D2") + "/" + dateTimePickerDateNaissance.Value.Year.ToString("D4");
                dataGridViewClients.SelectedRows[0].Cells["cNumeroNational"].Value = textBoxNumeroNational.Text;
                dataGridViewClients.SelectedRows[0].Cells["cAdresse"].Value = textBoxRue.Text + " " + textBoxNumero.Text + ", " + textBoxCodePostal.Text + " " + textBoxVille.Text + " " + textBoxPays.Text;
                dataGridViewClients.SelectedRows[0].Cells["cAdresseEmail"].Value = textBoxAdresseEmail.Text;
                dataGridViewClients.SelectedRows[0].Cells["cNumeroTelephone"].Value = textBoxNumeroTelephone.Text;
                dataGridViewClients.SelectedRows[0].Cells["cDateEnregistrement"].Value = DateTime.Today.Day.ToString("D2") + "/" + DateTime.Today.Month.ToString("D2") + "/" + DateTime.Today.Year.ToString("D4");


                bindingSourcesClients.EndEdit();
                id = null;

            }
            ActiverBoutonsFormulaires(true);
        }

        private void buttonAnnulerClient_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }
    }
}
