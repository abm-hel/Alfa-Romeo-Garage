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
        private DataTable dataTableClients;
        private BindingSource bindingSourcesE;
        private BindingSource bindingSourcesClients;

        private DataTable dataTableV;
        private BindingSource bindingSourcesV;

        private DataTable dataTableP;
        private BindingSource bindingSourcesP;

        string id;

        public UserControleEntre()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulairesEntretien(bool disponibilite)
        {
            dataGridViewC.Enabled = dataGridviewV.Enabled = dataGridViewP.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible  = disponibilite;
            buttonAjouterIntervention.Enabled = buttonSupprimerIntervention.Enabled = buttonEditerIntervention.Enabled = buttonAjouterPiece.Enabled = buttonEditerPiece.Enabled = buttonSupprimerPiece.Enabled = disponibilite;
            comboBoxVehicule.Visible = !disponibilite;
            dateTimePickerDateEntretien.Visible = !disponibilite;
            labelVehicule.Visible = !disponibilite;
            labelDate.Visible = !disponibilite;
            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
            
        }

        private void ActiverBoutonsFormulairesInterventions(bool disponibilite)
        {
            dataGridViewC.Enabled = dataGridViewE.Enabled = dataGridViewP.Enabled = disponibilite;
            buttonAjouterIntervention.Visible = buttonEditerIntervention.Visible = buttonSupprimerIntervention.Visible = disponibilite;
            buttonAjouter.Enabled = buttonSupprimer.Enabled = buttonEditer.Enabled = buttonAjouterPiece.Enabled = buttonEditerPiece.Enabled = buttonSupprimerPiece.Enabled = disponibilite;
            comboBoxIntervention.Visible = comboBoxEntretien.Visible= !disponibilite;
            labelIntervention.Visible = !disponibilite;
            labelEntretien.Visible = !disponibilite;
            buttonConfirmerIntervention.Visible = buttonAnnulerIntervention.Visible = !disponibilite;
        }

        private void ActiverBoutonsFormulairesPieces(bool disponibilite)
        {
            dataGridViewC.Enabled = dataGridViewE.Enabled = dataGridviewV.Enabled = disponibilite;
            buttonAjouterPiece.Visible = buttonEditerPiece.Visible = buttonSupprimerPiece.Visible = disponibilite;
            buttonAjouterIntervention.Enabled = buttonSupprimerIntervention.Enabled = buttonEditerIntervention.Enabled = buttonAjouter.Enabled = buttonSupprimer.Enabled = buttonEditer.Enabled = disponibilite;
            
            comboBoxPiece.Visible = comboBoxEntretien2.Visible = textBoxQuantite.Visible = !disponibilite;
            labelEntretien2.Visible = labelPiece.Visible = labelQuantite.Visible = !disponibilite;
         
            
            buttonConfirmerPiece.Visible = buttonAnnulerPiece.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableE = new DataTable();
            dataTableE.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableE.Columns.Add(new DataColumn("vehicule"));
            dataTableE.Columns.Add(new DataColumn("date"));

            dataTableV = new DataTable();
            dataTableV.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableV.Columns.Add(new DataColumn("entretienId", System.Type.GetType("System.Int32")));
            dataTableV.Columns.Add(new DataColumn("description"));
            dataTableV.Columns.Add(new DataColumn("vehicule"));
            dataTableV.Columns.Add(new DataColumn("client"));
            dataTableV.Columns.Add(new DataColumn("date"));
            dataTableV.Columns.Add(new DataColumn("prix"));
            dataTableV.Columns.Add(new DataColumn("tva"));

            dataTableP = new DataTable();
            dataTableP.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableP.Columns.Add(new DataColumn("entretienId", System.Type.GetType("System.Int32")));
            dataTableP.Columns.Add(new DataColumn("piece"));
            dataTableP.Columns.Add(new DataColumn("vehicule"));
            dataTableP.Columns.Add(new DataColumn("client"));
            dataTableP.Columns.Add(new DataColumn("date"));
            dataTableP.Columns.Add(new DataColumn("prix"));
            dataTableP.Columns.Add(new DataColumn("tva"));
            dataTableP.Columns.Add(new DataColumn("quantite", System.Type.GetType("System.Int32")));


            List<C_INVOICE> listEntretiens = new G_INVOICE(connexionBD).Lire("DATE");

            foreach (C_INVOICE entretien in listEntretiens)
            {
                int idVeh = Convert.ToInt32(entretien.ID_VEHICLE);

                C_VEHICLE vehicule = new G_VEHICLE(connexionBD).Lire_ID(idVeh);

                dataTableE.Rows.Add
                (
                    entretien.ID,
                    vehicule.REGISTRATION,
                    Convert.ToDateTime(entretien.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Year.ToString("D4")
                );
            }

            List<C_INTERVENTION_INVOICE> list = new G_INTERVENTION_INVOICE(connexionBD).Lire("ID");

            foreach (C_INTERVENTION_INVOICE r in list)
            {
                int idT = Convert.ToInt32(r.ID_INTERVENTION);
                int idF = Convert.ToInt32(r.ID_INVOICE);

                C_INTERVENTION mainO = new G_INTERVENTION(connexionBD).Lire_ID(idT);
                C_INVOICE en = new G_INVOICE(connexionBD).Lire_ID(idF);

                C_VEHICLE v = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(en.ID_VEHICLE));
                C_CUSTOMER c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(v.ID_CUSTOMER));


                dataTableV.Rows.Add
                (
                    r.ID,
                    en.ID,
                    mainO.DESCRIPTION,
                    v.REGISTRATION,
                    c.FIRST_NAME+" "+c.LAST_NAME,
                    Convert.ToDateTime(en.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Year.ToString("D4"),

                    string.Format("{0:0.00}", mainO.PRIC).ToString() + " €",
                    string.Format("{0:0.0}", mainO.TVA).ToString() + " %"
                );
            }

            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("nomPrenom"));
            dataTableClients.Columns.Add(new DataColumn("dateNaissance"));
            dataTableClients.Columns.Add(new DataColumn("numeroNational"));
            dataTableClients.Columns.Add(new DataColumn("adresse"));
            dataTableClients.Columns.Add(new DataColumn("adresseEmail"));
            dataTableClients.Columns.Add(new DataColumn("numeroTelephone"));
            dataTableClients.Columns.Add(new DataColumn("dateEnregistrement"));

            List<C_PART_INVOICE> listPieces = new G_PART_INVOICE(connexionBD).Lire("ID");
            
            foreach (C_PART_INVOICE r in listPieces)
            {
                int idT = Convert.ToInt32(r.ID_PART);
                int idF = Convert.ToInt32(r.ID_INVOICE);

                C_PART pieceU = new G_PART(connexionBD).Lire_ID(idT);
                C_INVOICE en = new G_INVOICE(connexionBD).Lire_ID(idF);

                C_VEHICLE v = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(en.ID_VEHICLE));
                C_CUSTOMER c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(v.ID_CUSTOMER));


                dataTableP.Rows.Add
                (
                    r.ID,
                    en.ID,
                    pieceU.NAME,
                    v.REGISTRATION,
                    c.FIRST_NAME + " " + c.LAST_NAME,
                    Convert.ToDateTime(en.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Year.ToString("D4"),

                    string.Format("{0:0.00}", pieceU.PRICE*r.QUANTITY_USED).ToString() + " €",
                    string.Format("{0:0.0}", pieceU.TVA).ToString() + " %",
                    r.QUANTITY_USED
                );
            }

            List<C_CUSTOMER> listClients = new G_CUSTOMER(connexionBD).Lire("LAST_NAME");

            foreach (C_CUSTOMER client in listClients)
            {
                dataTableClients.Rows.Add
                (
                    client.ID,
                    client.LAST_NAME + " " + client.FIRST_NAME,
                    Convert.ToDateTime(client.BIRTH_DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(client.BIRTH_DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(client.BIRTH_DATE).Year.ToString("D4"),
                    client.NATIONAL_NUMBER,
                    client.ADDRESS + " " + client.NUMBER + ", " + client.POSTAL_CODE + " " + client.CITY + " " + client.COUNTRY,
                    client.EMAIL_ADDRESS,
                    client.PHONE_NUMBER,
                    Convert.ToDateTime(client.DATA_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Year.ToString("D4")
                );
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewC.DataSource = bindingSourcesClients;

            bindingSourcesE = new BindingSource();
            bindingSourcesE.DataSource = dataTableE;
            dataGridViewE.DataSource = bindingSourcesE;

            bindingSourcesV = new BindingSource();
            bindingSourcesV.DataSource = dataTableV;
            dataGridviewV.DataSource = bindingSourcesV;

            bindingSourcesP = new BindingSource();
            bindingSourcesP.DataSource = dataTableP;
            dataGridViewP.DataSource = bindingSourcesP;

            comboBoxEntretien.Items.Clear();
            comboBoxEntretien2.Items.Clear();
            comboBoxIntervention.Items.Clear();
            comboBoxVehicule.Items.Clear();
            comboBoxPiece.Items.Clear();

            List<C_VEHICLE> listV = new G_VEHICLE(connexionBD).Lire("ID");

            foreach (C_VEHICLE v in listV)
            {
                comboBoxVehicule.Items.Add(v.ID + " - " + v.REGISTRATION);
            }



            List<C_INTERVENTION> listB = new G_INTERVENTION(connexionBD).Lire("ID");

            foreach (C_INTERVENTION b in listB)
            {
                comboBoxIntervention.Items.Add(b.ID+" - "+b.DESCRIPTION);
            }

            List<C_PART> ListPieces = new G_PART(connexionBD).Lire("ID");

            foreach(C_PART p in ListPieces)
            {
                comboBoxPiece.Items.Add(p.ID + " - " + p.NAME);
            }

            List<C_INVOICE> listC = new G_INVOICE(connexionBD).Lire("ID");
            int idVehicule;
            foreach (C_INVOICE v in listC)
            {
                idVehicule = Convert.ToInt32(v.ID_VEHICLE);
                C_VEHICLE vehicule = new G_VEHICLE(connexionBD).Lire_ID(idVehicule);
                DateTime dateEntretien = Convert.ToDateTime(v.DATE);
                comboBoxEntretien.Items.Add(v.ID +" - " + vehicule.REGISTRATION +" ("+ dateEntretien.Day.ToString("D2") +"/"+dateEntretien.Month.ToString("D2") + "/"+dateEntretien.Year.ToString("D4") +")");
                comboBoxEntretien2.Items.Add(v.ID + " - " + vehicule.REGISTRATION + " (" + dateEntretien.Day.ToString("D2") + "/" + dateEntretien.Month.ToString("D2") + "/" + dateEntretien.Year.ToString("D4") + ")");
            }

        }

        private void UserControleEntre_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;
            RemplirDataGridView();
            ActiverBoutonsFormulairesEntretien(true);
            ActiverBoutonsFormulairesInterventions(true);
            ActiverBoutonsFormulairesPieces(true);
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            dateTimePickerDateEntretien.Value = DateTime.Today;
            ActiverBoutonsFormulairesEntretien(false);
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                id = dataGridViewE.SelectedRows[0].Cells["cID"].Value.ToString();
                C_INVOICE vehiculeModification = new G_INVOICE(connexionBD).Lire_ID(int.Parse(id));
                ActiverBoutonsFormulairesEntretien(false);
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
            else
            {
                MessageBox.Show("Aucun enregistrement sélectionné !");
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulairesEntretien(true);
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
                   vehicule[1]+"-"+vehicule[2]+"-" + vehicule[3],
                   
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
                dataGridViewE.SelectedRows[0].Cells["cVehicule"].Value = vehicule[1] +"-"+ vehicule[2]+ "-" + vehicule[3];
                dataGridViewE.SelectedRows[0].Cells["cDate"].Value = dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4");

                bindingSourcesE.EndEdit();
                id = null;
            }
            ActiverBoutonsFormulairesEntretien(true);
        }

    

        private void buttonAjouterIntervention_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulairesInterventions(false);
        }

        private void buttonEditerIntervention_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                id = dataGridviewV.SelectedRows[0].Cells["cID1"].Value.ToString();
                ActiverBoutonsFormulairesInterventions(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimerIntervention_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'enregistrement?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridviewV.SelectedRows[0].Cells["cID1"].Value;
                    new G_INTERVENTION_INVOICE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesV.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmerIntervention_Click(object sender, EventArgs e)
        {
            string[] interventionT = comboBoxIntervention.Text.Trim().Split('-');
            string[] entretienT = comboBoxEntretien.Text.Trim().Split('-');


            C_INTERVENTION IN = new G_INTERVENTION(connexionBD).Lire_ID(Convert.ToInt32(interventionT[0]));
            C_INVOICE INV = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(entretienT[0]));
            C_VEHICLE V = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(INV.ID_VEHICLE));
            C_CUSTOMER c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(V.ID_CUSTOMER));

            if (id==null)
            {

                int idAjouter = new G_INTERVENTION_INVOICE(connexionBD).Ajouter(Convert.ToInt32(interventionT[0]), Convert.ToInt32(entretienT[0]), IN.PRICE_HOUR, IN.PRIC, IN.TVA);
                MessageBox.Show(comboBoxIntervention.Text + "+" + comboBoxEntretien.Text);

                dataTableV.Rows.Add
                  (
                      idAjouter.ToString(),
                      INV.ID.ToString(),
                      IN.DESCRIPTION,
                      V.REGISTRATION,
                      c.FIRST_NAME + " " + c.LAST_NAME,
                      Convert.ToDateTime(INV.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Year.ToString("D4"),
                      string.Format("{0:0.00}", IN.PRIC).ToString() + " €",
                      string.Format("{0:0.0}", IN.TVA).ToString() + " %"
                  );
            }
            
            else
            //Modification
            {
                MessageBox.Show(interventionT[0]);
                MessageBox.Show(entretienT[0]);
                
                IN = new G_INTERVENTION(connexionBD).Lire_ID(Convert.ToInt32(interventionT[0]));
                INV = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(entretienT[0]));
                V = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(INV.ID_VEHICLE));
                c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(V.ID_CUSTOMER));

                int Modification = new G_INTERVENTION_INVOICE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    Convert.ToInt32(interventionT[0]),
                    Convert.ToInt32(entretienT[0]),
                    IN.PRICE_HOUR,
                    IN.PRIC,
                    IN.TVA
                   );

                dataGridviewV.SelectedRows[0].Cells["cID1"].Value = int.Parse(id).ToString();
                dataGridviewV.SelectedRows[0].Cells["cEntretienID1"].Value = INV.ID;
                dataGridviewV.SelectedRows[0].Cells["cDescription1"].Value = IN.DESCRIPTION;
                dataGridviewV.SelectedRows[0].Cells["cVehicule1"].Value = V.REGISTRATION;
                dataGridviewV.SelectedRows[0].Cells["cClient1"].Value = c.FIRST_NAME + " " + c.LAST_NAME;
                dataGridviewV.SelectedRows[0].Cells["cDate1"].Value = Convert.ToDateTime(INV.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Year.ToString("D4");
                dataGridviewV.SelectedRows[0].Cells["cPrix1"].Value = string.Format("{0:0.00}", IN.PRIC).ToString() + " €";
                dataGridviewV.SelectedRows[0].Cells["cTVA1"].Value = string.Format("{0:0.0}", IN.TVA).ToString() + " %";

                bindingSourcesV.EndEdit();
                id = null;
            }
            
            ActiverBoutonsFormulairesInterventions(true);
        }

        private void buttonAnnulerIntervention_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulairesInterventions(true);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }

        private void buttonAjouterPiece_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulairesPieces(false);
        }

        private void buttonEditerPiece_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                id = dataGridViewP.SelectedRows[0].Cells["cID2"].Value.ToString();
                ActiverBoutonsFormulairesPieces(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimerPiece_Click(object sender, EventArgs e)
        {
            if (dataGridViewP.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'enregistrement?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idSuppression = (int)dataGridViewP.SelectedRows[0].Cells["cID2"].Value;
                    new G_PART_INVOICE(connexionBD).Supprimer(idSuppression);
                    bindingSourcesP.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmerPiece_Click(object sender, EventArgs e)
        {
            string[] piece = comboBoxPiece.Text.Trim().Split('-');
            string[] entretien = comboBoxEntretien2.Text.Trim().Split('-');
            
            int quantite = Convert.ToInt32(textBoxQuantite.Text);


            C_PART pieceSelectionnee = new G_PART(connexionBD).Lire_ID(Convert.ToInt32(piece[0]));
            C_INVOICE entretienSelectionnee = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(entretien[0]));
            C_VEHICLE vehiculeSelectionne = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(entretienSelectionnee.ID_VEHICLE));
            C_CUSTOMER client = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(vehiculeSelectionne.ID_CUSTOMER));

            if (id == null)
            {

                int idAjouter = new G_PART_INVOICE(connexionBD).Ajouter(Convert.ToInt32(piece[0]), Convert.ToInt32(entretien[0]), quantite, pieceSelectionnee.PRICE, pieceSelectionnee.TVA);
               

                dataTableP.Rows.Add
                  (
                      idAjouter.ToString(),
                      entretienSelectionnee.ID.ToString(),
                      pieceSelectionnee.NAME.ToString(),
                      vehiculeSelectionne.REGISTRATION,
                      client.FIRST_NAME + " " + client.LAST_NAME,
                      Convert.ToDateTime(entretienSelectionnee.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(entretienSelectionnee.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(entretienSelectionnee.DATE).Year.ToString("D4"),
                      string.Format("{0:0.00}", pieceSelectionnee.PRICE*quantite).ToString() + " €",
                      string.Format("{0:0.0}", pieceSelectionnee.TVA).ToString() + " %",
                      quantite.ToString()
                  ) ;
            }

            else
            //Modification
            {
                pieceSelectionnee = new G_PART(connexionBD).Lire_ID(Convert.ToInt32(piece[0]));
                entretienSelectionnee = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(entretien[0]));
                vehiculeSelectionne = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(entretienSelectionnee.ID_VEHICLE));
                client = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(vehiculeSelectionne.ID_CUSTOMER));

               

                int Modification = new G_PART_INVOICE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    Convert.ToInt32(piece[0]),
                    Convert.ToInt32(entretien[0]),
                    Convert.ToInt32(textBoxQuantite.Text),
                    pieceSelectionnee.PRICE,
                    pieceSelectionnee.TVA
                   );

                dataGridViewP.SelectedRows[0].Cells["cID2"].Value = int.Parse(id).ToString();
                dataGridViewP.SelectedRows[0].Cells["cEntretien2"].Value = entretienSelectionnee.ID;
                dataGridViewP.SelectedRows[0].Cells["cPiece2"].Value = pieceSelectionnee.NAME;
                dataGridViewP.SelectedRows[0].Cells["cVehicule2"].Value = vehiculeSelectionne.REGISTRATION;
                dataGridViewP.SelectedRows[0].Cells["cClient2"].Value = client.FIRST_NAME + " " + client.LAST_NAME;
                dataGridViewP.SelectedRows[0].Cells["cDate2"].Value = Convert.ToDateTime(entretienSelectionnee.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(entretienSelectionnee.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(entretienSelectionnee.DATE).Year.ToString("D4");
                dataGridViewP.SelectedRows[0].Cells["cPrix2"].Value = string.Format("{0:0.00}",(pieceSelectionnee.PRICE*Convert.ToInt32(textBoxQuantite.Text)).ToString()) + " €";
                dataGridViewP.SelectedRows[0].Cells["cTVA2"].Value = string.Format("{0:0.0}", pieceSelectionnee.TVA).ToString() + " %";
                dataGridViewP.SelectedRows[0].Cells["cQuantite"].Value = textBoxQuantite.Text;

                bindingSourcesP.EndEdit();
                id = null;
            }
            ActiverBoutonsFormulairesPieces(true);
        }

        private void buttonAnnulerPiece_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulairesPieces(true);
        }
    }
}
