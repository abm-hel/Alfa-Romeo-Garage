using Alfa_Romeo_Garage.ChiffreAffaires;
using Projet_HEL.Classes;
using Projet_HEL.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Alfa_Romeo_Garage.Interfaces
{
    public partial class UserControlOptions : UserControl
    {
        private string connexionBaseDonnees = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;
        public RichTextBox richTextBoxFacture = new RichTextBox();

        public UserControlOptions()
        {
            InitializeComponent();
        }

        private void buttonGenererFacture_Click(object sender, EventArgs e)
        {
            double total=0;
            richTextBoxFacture.Clear();

            if (comboBoxEntretienFacture.SelectedItem==null)
            {
                MessageBox.Show("Veuillez sélectionner un entretien");
            }

            else
            {
                int idEntretien = Convert.ToInt32(comboBoxEntretienFacture.SelectedItem);
                C_INVOICE entretien = new G_INVOICE(connexionBaseDonnees).Lire_ID(idEntretien);
                C_VEHICLE vehicule = new G_VEHICLE(connexionBaseDonnees).Lire_ID(Convert.ToInt32(entretien.ID_VEHICLE));
                List<C_INTERVENTION_INVOICE> interventions = new G_INTERVENTION_INVOICE(connexionBaseDonnees).Lire("id");
                List<C_PART_INVOICE> pieces = new G_PART_INVOICE(connexionBaseDonnees).Lire("id");

                richTextBoxFacture.AppendText("ALFA ROMEO GARAGE - facture " + entretien.ID + " - " + Convert.ToDateTime(entretien.DATE).ToString("dd/MM/yyyy").ToString());
                richTextBoxFacture.AppendText(Environment.NewLine);
                richTextBoxFacture.AppendText(Environment.NewLine);
                richTextBoxFacture.AppendText("Interventions");
                richTextBoxFacture.AppendText(Environment.NewLine);
                richTextBoxFacture.AppendText(Environment.NewLine);

                foreach (C_INTERVENTION_INVOICE intervention in interventions)
                {
                    if (intervention.ID_INVOICE == idEntretien)
                    {
                        C_INTERVENTION i = new G_INTERVENTION(connexionBaseDonnees).Lire_ID(Convert.ToInt32(intervention.ID_INTERVENTION));

                        richTextBoxFacture.AppendText(i.DESCRIPTION);
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(string.Format("{0:0.00}", intervention.PRICE_HOUR) + " € / h" + "\t" + i.NUMBER_HOURS + " heure(s)" + "\t" + string.Format("{0:0.0}", intervention.TVA) + " % TVA" + "\t" + string.Format("{0:0.00}", intervention.PRICE + (intervention.PRICE * intervention.TVA / 100)) + " € TTC");
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(Environment.NewLine);

                        total += Convert.ToDouble(intervention.PRICE + (intervention.PRICE * intervention.TVA / 100));
                    }
                }

                richTextBoxFacture.AppendText(Environment.NewLine);
                richTextBoxFacture.AppendText("Pièces");
                richTextBoxFacture.AppendText(Environment.NewLine);
                richTextBoxFacture.AppendText(Environment.NewLine);


                foreach (C_PART_INVOICE piece in pieces)
                {
                    if (piece.ID_INVOICE == idEntretien)
                    {
                        C_PART p = new G_PART(connexionBaseDonnees).Lire_ID(Convert.ToInt32(piece.ID_PART));

                        richTextBoxFacture.AppendText(p.PRODUCER+" "+p.NAME);
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(string.Format("{0:0.00}", p.PRICE) + " € / pièce" + "\t" + " x " + piece.QUANTITY_USED + "\t" + string.Format("{0:0.0}", piece.TVA) + " % TVA" + "\t" + string.Format("{0:0.00}",piece.PRICE * piece.QUANTITY_USED + (piece.PRICE * piece.QUANTITY_USED * piece.PRICE / 100)) + " € TTC");
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(Environment.NewLine);

                        total += Convert.ToDouble(piece.PRICE * piece.QUANTITY_USED + (piece.PRICE * piece.QUANTITY_USED * piece.PRICE / 100));
                    }
                }

                richTextBoxFacture.AppendText("Prix total : "+string.Format("{0:0.00}", total) +" €");

                string cheminFichierRtf = @"C:\Users\adilb\Desktop\ProjectBD\Alfa-Romeo-Garage\Factures\Facture" + entretien.ID + ".rtf";
                richTextBoxFacture.SaveFile(cheminFichierRtf);
                MessageBox.Show("Facture créée !");

            }
            
        }

        private void UserControlOptions_Load(object sender, EventArgs e)
        {  
            comboBoxEntretienFacture.Items.Clear();
            List<C_INVOICE> listEntretiens = new G_INVOICE(connexionBaseDonnees).Lire("ID");

            foreach (C_INVOICE entretien in listEntretiens)
            {
                comboBoxEntretienFacture.Items.Add(entretien.ID);
                comboBoxEntretienFacture.SelectedIndex = 0;
            }
        }

        private void buttonCalculerChiffreAffaires_Click(object sender, EventArgs e)
        {
            double chiffreAffaires = 0;

            DateTime dateDebut = dateTimePickerDateChiffreAffaires.Value;
            DateTime dateFin = dateTimePickerDateChiffreAffaires.Value.AddDays(7);

            DateTime debut = new DateTime(dateDebut.Year, dateDebut.Month, dateDebut.Day);
            DateTime fin = new DateTime(dateFin.Year, dateFin.Month, dateFin.Day);

            List<C_ChiffreAffaires_Intervention> listeInterventions = new List<C_ChiffreAffaires_Intervention>();
            
            using (SqlConnection conn = new SqlConnection(connexionBaseDonnees))
            {
                conn.Open();
                SqlCommand commande = new SqlCommand("ChiffreAffairesIntervention", conn);
                commande.CommandType = CommandType.StoredProcedure;
                commande.Parameters.AddWithValue("@dateDebut", SqlDbType.DateTime).Value = debut;
                commande.Parameters.AddWithValue("@dateFin", SqlDbType.DateTime).Value = fin;
                SqlDataReader dr = commande.ExecuteReader();
                while (dr.Read())
                {
                    C_ChiffreAffaires_Intervention donnees = new C_ChiffreAffaires_Intervention();
                    donnees.PRICE = (double)dr["PRICE"];
                    listeInterventions.Add(donnees);
                }
                conn.Close();
            }

            foreach (C_ChiffreAffaires_Intervention intervention in listeInterventions)
            {
                chiffreAffaires = chiffreAffaires + Convert.ToDouble(intervention.PRICE);
            }

            List<C_ChiffreAffaires_Piece> listPiece = new List<C_ChiffreAffaires_Piece>();
            using (SqlConnection conn = new SqlConnection(connexionBaseDonnees))
            {
                conn.Open();
                SqlCommand commande = new SqlCommand("ChiffreAffairesPieces", conn);
                commande.CommandType = CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("@dateDebut", SqlDbType.DateTime).Value = debut;
                commande.Parameters.AddWithValue("@dateFin", SqlDbType.DateTime).Value = fin;
                MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.ToString());
                MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.AddDays(7).ToString());
                SqlDataReader dr = commande.ExecuteReader();
                while (dr.Read())
                {
                    C_ChiffreAffaires_Piece entity = new C_ChiffreAffaires_Piece();
                    entity.PRICE = (double)dr["PRICE"];
                    entity.QUANTITY_USED = (int)dr["QUANTITY_USED"];
                    listPiece.Add(entity);
                }
                conn.Close();
            }

            foreach (C_ChiffreAffaires_Piece piece in listPiece)
            {
                chiffreAffaires = chiffreAffaires + Convert.ToDouble(piece.PRICE) * Convert.ToInt32(piece.QUANTITY_USED);
            }



            labelChiffreAffaires.Text = string.Format("{0:0.00}", chiffreAffaires) + " €";
        }
    }
}
