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
    public partial class FormMainOeuvre : Form
    {
        string connexionBD;
        private DataTable dataTableV;
        private BindingSource bindingSourcesV;
        string id;


        public FormMainOeuvre()
        {
            InitializeComponent();
        }
        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridviewV.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible = disponibilite;

            comboBoxEntretien.Enabled = !disponibilite;
            comboBoxIntervention.Enabled = !disponibilite;
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableV = new DataTable();
            dataTableV.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableV.Columns.Add(new DataColumn("description"));
            dataTableV.Columns.Add(new DataColumn("vehicule"));
            dataTableV.Columns.Add(new DataColumn("date"));



            dataTableV.Columns.Add(new DataColumn("prix"));
            dataTableV.Columns.Add(new DataColumn("tva"));
          
            List<C_INTERVENTION_INVOICE> list = new G_INTERVENTION_INVOICE(connexionBD).Lire("ID");

            foreach (C_INTERVENTION_INVOICE r in list)
            {
                int idT = Convert.ToInt32(r.ID_INTERVENTION);
                int idF = Convert.ToInt32(r.ID_INVOICE);

                C_INTERVENTION mainO = new G_INTERVENTION(connexionBD).Lire_ID(idT);
                C_INVOICE en = new G_INVOICE(connexionBD).Lire_ID(idF);

                C_VEHICLE v = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(en.ID_VEHICLE));


                dataTableV.Rows.Add
                (
                    r.ID,
                    mainO.DESCRIPTION,
                    v.REGISTRATION,
                    Convert.ToDateTime(en.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Year.ToString("D4"),

                    string.Format("{0:0.00}", mainO.PRIC).ToString()+" €",
                    string.Format("{0:0.0}", mainO.TVA).ToString() + " %"
                );
            }

            bindingSourcesV = new BindingSource();
            bindingSourcesV.DataSource = dataTableV;
            dataGridviewV.DataSource = bindingSourcesV;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {

            /*
            if (id == null)
            //Ajout
            {
                int idAjoutEntretien = new G_INVOICE(connexionBD).Ajouter
                (
                    Convert.ToInt32(comboBoxIntervention.SelectedItem.ToString()),
                    Convert.ToInt32(comboBoxEntretien.SelectedItem.ToString()),

                    
                )


                dataTableE.Rows.Add
                (
                   idAjoutEntretien.ToString(),
                   vehicule[1] + "-" + vehicule[2] + "-" + vehicule[3],

                   dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4")
                );
            


            }*/
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(false);
            
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                id = dataGridviewV.SelectedRows[0].Cells["cID"].Value.ToString();
                
                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'enregistrement?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridviewV.SelectedRows[0].Cells["cID"].Value;
                    new G_INTERVENTION_INVOICE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesV.RemoveCurrent();
                }
            }
        }

        private void FormMainOeuvre_Load(object sender, EventArgs e)
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

            List<C_INTERVENTION> listV = new G_INTERVENTION(connexionBD).Lire("ID");

            foreach (C_INTERVENTION v in listV)
            {
                comboBoxIntervention.Items.Add(v.ID);
            }

            List<C_INVOICE> listC = new G_INVOICE(connexionBD).Lire("ID");

            foreach (C_INVOICE v in listC)
            {
                comboBoxEntretien.Items.Add(v.ID);
            }
        }
    }
}
