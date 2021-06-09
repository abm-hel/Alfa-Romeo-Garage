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


namespace Alfa_Romeo_Garage.Interfaces
{
    public partial class UserControleEntre : UserControl
    {
        string connexionBD;
        private DataTable dataTableE;
        private BindingSource bindingSourcesE;
        string id;

        public UserControleEntre()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewE.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            comboBoxVehicule.Enabled = !disponibilite;
            dateTimePickerDateEntretien.Enabled = !disponibilite;

            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableE = new DataTable();
            dataTableE.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableE.Columns.Add(new DataColumn("vehicule"));
            dataTableE.Columns.Add(new DataColumn("date"));



            List<C_INVOICE> listEntretiens = new G_INVOICE(connexionBD).Lire("DATE");

            foreach (C_INVOICE entretien in listEntretiens)
            {
                int idVehicule = Convert.ToInt32(entretien.ID_VEHICLE);

                C_VEHICLE vehicule = new G_VEHICLE(connexionBD).Lire_ID(idVehicule);

                dataTableE.Rows.Add
                (
                    entretien.ID,
                    vehicule.REGISTRATION,
                    Convert.ToDateTime(entretien.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Year.ToString("D4")
                );
            }

            bindingSourcesE = new BindingSource();
            bindingSourcesE.DataSource = dataTableE;
            dataGridViewE.DataSource = bindingSourcesE;
        }

        private void UserControleEntre_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;


            RemplirDataGridView();

            if (dataGridViewE.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);
            }

            else
            {
                ActiverBoutonsFormulaires(false);
            }


            List<C_VEHICLE> listV = new G_VEHICLE(connexionBD).Lire("ID");

            foreach (C_VEHICLE v in listV)
            {
                comboBoxVehicule.Items.Add(v.ID + " - " + v.REGISTRATION);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            dateTimePickerDateEntretien.Value = DateTime.Today;
            ActiverBoutonsFormulaires(false);
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                id = dataGridViewE.SelectedRows[0].Cells["cID"].Value.ToString();
                C_INVOICE vehiculeModification = new G_INVOICE(connexionBD).Lire_ID(int.Parse(id));
                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
                
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'entretien ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridViewE.SelectedRows[0].Cells["cID"].Value;
                    new G_INVOICE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesE.RemoveCurrent();
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            string[] vehicule = comboBoxVehicule.SelectedItem.ToString().Trim().Split('-');
 

            if (id == null)
            //Ajout
            {
                int idAjoutEntretien = new G_INVOICE(connexionBD).Ajouter
                (
                    Convert.ToInt32(vehicule[0]),
                    dateTimePickerDateEntretien.Value
                );


                dataTableE.Rows.Add
                (
                   idAjoutEntretien.ToString(),
                   vehicule[1]+"-"+vehicule[2],
                   
                   dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4")
                ) ;

                

            }

            else
            //Modification
            {
                int idVehiculeModification = new G_INVOICE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    int.Parse(vehicule[0]),
                    dateTimePickerDateEntretien.Value
                   );

                dataGridViewE.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewE.SelectedRows[0].Cells["cVehicule"].Value = vehicule[1] +"-"+ vehicule[2];
                dataGridViewE.SelectedRows[0].Cells["cDate"].Value = dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4");

                bindingSourcesE.EndEdit();
                id = null;
            }
            ActiverBoutonsFormulaires(true);
        }

       
    }
}
