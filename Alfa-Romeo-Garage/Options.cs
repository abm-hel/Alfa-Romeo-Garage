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
using System.Windows.Forms;

namespace Alfa_Romeo_Garage
{
    public partial class Options : Form
    {
        private string connexionBaseDonnees = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;
        private RichTextBox richTextBoxFacture = new RichTextBox();
        private DataTable dataTableEntretiens;
        private BindingSource bindingSourceEntretiens;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            comboBoxEntretienFacture.Items.Clear();
            List<C_INVOICE> listEntretiens = new G_INVOICE(connexionBaseDonnees).Lire("ID");

            foreach (C_INVOICE entretien in listEntretiens)
            {
                comboBoxEntretienFacture.Items.Add(entretien.ID);
                
            }
            comboBoxEntretienFacture.SelectedIndex = 0;
            webBrowserReleve.Navigate(@"C:\Users\adilb\Desktop\ProjectBD\Alfa-Romeo-Garage\releveSemaine.html");
        }

        private void buttonGenererFacture_Click(object sender, EventArgs e)
        {
            double total = 0;
            richTextBoxFacture.Clear();

            if (comboBoxEntretienFacture.SelectedItem == null)
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

                        richTextBoxFacture.AppendText(p.PRODUCER + " " + p.NAME);
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(string.Format("{0:0.00}", p.PRICE) + " € / pièce" + "\t" + " x " + piece.QUANTITY_USED + "\t" + string.Format("{0:0.0}", piece.TVA) + " % TVA" + "\t" + string.Format("{0:0.00}", piece.PRICE * piece.QUANTITY_USED + (piece.PRICE * piece.QUANTITY_USED * piece.PRICE / 100)) + " € TTC");
                        richTextBoxFacture.AppendText(Environment.NewLine);
                        richTextBoxFacture.AppendText(Environment.NewLine);

                        total += Convert.ToDouble(piece.PRICE * piece.QUANTITY_USED + (piece.PRICE * piece.QUANTITY_USED * piece.PRICE / 100));
                    }
                }

                richTextBoxFacture.AppendText("Prix total : " + string.Format("{0:0.00}", total) + " €");

                string cheminFichierRtf = @"C:\Users\adilb\Desktop\ProjectBD\Alfa-Romeo-Garage\Factures\Facture" + entretien.ID + ".rtf";
                richTextBoxFacture.SaveFile(cheminFichierRtf);
                MessageBox.Show("Facture créée !");
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

            using (SqlConnection connexion = new SqlConnection(connexionBaseDonnees))
            {
                connexion.Open();
                SqlCommand commande = new SqlCommand("ChiffreAffairesIntervention", connexion);
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
                connexion.Close();
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
                //MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.ToString());
                //MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.AddDays(7).ToString());
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

        private void buttonStock_Click(object sender, EventArgs e)
        {
            string rupture = "Pièce(s) en rupture :\n";


            List<C_PART> listePieces = new List<C_PART>();

            using (SqlConnection connexion = new SqlConnection(connexionBaseDonnees))
            {
                connexion.Open();
                SqlCommand commande = new SqlCommand("Select * from PART where QUANTITY=0", connexion);

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        C_PART piece = new C_PART();
                        piece.ID = (int)reader["ID"];
                        piece.NAME = (string)reader["NAME"];
                        piece.PRODUCER = (string)reader["PRODUCER"];
                        piece.PRICE = (double)reader["PRICE"];
                        piece.TVA = (double)reader["TVA"];
                        piece.QUANTITY = (int)reader["QUANTITY"];
                        listePieces.Add(piece);
                    }
                }
            }
            if(listePieces.Count==0)
            {
                MessageBox.Show("Toutes les pièces sont disponnibles");
            }

            else
            {
                foreach (C_PART p in listePieces)
                {
                    rupture +="\n - "+p.PRODUCER + " " + p.NAME; 
                }  
            }

            MessageBox.Show(rupture);

        }

        private void buttonGenererHTML_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays(-7);

            DateTime debut = new DateTime(d1.Year, d1.Month, d1.Day);
            DateTime fin = new DateTime(d2.Year, d2.Month, d2.Day);

            dataTableEntretiens = new DataTable();
            dataTableEntretiens.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableEntretiens.Columns.Add(new DataColumn("Véhicule"));
            dataTableEntretiens.Columns.Add(new DataColumn("Modèle"));
            dataTableEntretiens.Columns.Add(new DataColumn("Nom du client"));
            dataTableEntretiens.Columns.Add(new DataColumn("Date"));

            List<C_INVOICE> listeEntretiens = new List<C_INVOICE>();

            using (SqlConnection connexion = new SqlConnection(connexionBaseDonnees))
            {
                connexion.Open();
                SqlCommand commande = new SqlCommand("ReleveSemaine", connexion);
                commande.CommandType = CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("@d1", SqlDbType.DateTime).Value = debut;
                commande.Parameters.AddWithValue("@d2", SqlDbType.DateTime).Value = fin;
                //MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.ToString());
                //MessageBox.Show(dateTimePickerDateChiffreAffaires.Value.AddDays(7).ToString());
                //MessageBox.Show(debut.ToString());
                //MessageBox.Show(fin.ToString());

                SqlDataReader reader = commande.ExecuteReader();
                while (reader.Read())
                {
                    C_INVOICE entity = new C_INVOICE();
                    entity.ID = (int)reader["ID"];
                    entity.ID_VEHICLE = (int)reader["ID_VEHICLE"];
                    entity.DATE = (DateTime)reader["DATE"];
                    listeEntretiens.Add(entity);
                    //MessageBox.Show(entity.DATE.ToString());
                }
                connexion.Close();

                foreach(C_INVOICE en in listeEntretiens)
                {
                    C_VEHICLE vehicule = new G_VEHICLE(connexionBaseDonnees).Lire_ID(Convert.ToInt32(en.ID_VEHICLE));
                    C_CUSTOMER client = new G_CUSTOMER(connexionBaseDonnees).Lire_ID(Convert.ToInt32(vehicule.ID_CUSTOMER));
                    C_MODEL modele = new G_MODEL(connexionBaseDonnees).Lire_ID(Convert.ToInt32(vehicule.ID_MODEL));

                    dataTableEntretiens.Rows.Add(en.ID, vehicule.REGISTRATION, modele.MODEL, client.FIRST_NAME + " " + client.LAST_NAME,Convert.ToDateTime(en.DATE).Day.ToString("D2") + "/"+ Convert.ToDateTime(en.DATE).Month.ToString("D2") + "/"+ Convert.ToDateTime(en.DATE).Year.ToString("D4"));
                }

                bindingSourceEntretiens = new BindingSource();
                bindingSourceEntretiens.DataSource = dataTableEntretiens;

                StringBuilder strHTMLBuilder = new StringBuilder();
                strHTMLBuilder.Append("<html>");
                strHTMLBuilder.Append("<head>");
                strHTMLBuilder.Append("<meta charset=\"utf-8\">");
                strHTMLBuilder.Append("</head>");
                strHTMLBuilder.Append("<body>");
                strHTMLBuilder.Append("<h2 style='text-align:center ;f '>Relevé des prestations effectuées pour la semaine écoulée </h2>");
                //strHTMLBuilder.Append("<h1 style='text-align:center ; style='color: blue';font-family:arial; '>voiture </h1>");
                strHTMLBuilder.Append("<table align='center' border='2px' cellpadding='2' cellspacing='1'style=' border: 1px solid #ccc;font-size: 12pt;font-family:arial'>");
                strHTMLBuilder.Append("<tr>");

                foreach (DataColumn colonne in dataTableEntretiens.Columns)
                {
                    strHTMLBuilder.Append("<td >");
                    strHTMLBuilder.Append(colonne.ColumnName);
                    strHTMLBuilder.Append("</td>");
                }
                strHTMLBuilder.Append("</tr>");
                foreach (DataRow ligne in dataTableEntretiens.Rows)
                {
                    strHTMLBuilder.Append("<tr >");
                    foreach (DataColumn colonne in dataTableEntretiens.Columns)
                    {
                        strHTMLBuilder.Append("<td >");
                        strHTMLBuilder.Append(ligne[colonne.ColumnName].ToString());
                        strHTMLBuilder.Append("</td>");

                    }
                    strHTMLBuilder.Append("</tr>");
                }
                strHTMLBuilder.Append("</table>");
                strHTMLBuilder.Append("</body>");
                strHTMLBuilder.Append("</html>");
                string Htmltext = strHTMLBuilder.ToString();
                File.WriteAllText(@"C:\Users\adilb\Desktop\ProjectBD\Alfa-Romeo-Garage\releveSemaine.html", Htmltext);
                webBrowserReleve.Navigate(@"C:\Users\adilb\Desktop\ProjectBD\Alfa-Romeo-Garage\releveSemaine.html");
            }

        } 

        
    }
}
