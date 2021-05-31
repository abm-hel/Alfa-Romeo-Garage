#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_HEL.Classes;
#endregion

namespace Projet_HEL.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_INTERVENTION_INVOICE : ADBase
 {
  #region Constructeurs
  public A_INTERVENTION_INVOICE(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_INTERVENTION, int? ID_INVOICE, double? PRICE_HOUR, double? PRICE, double? TVA)
  {
   CreerCommande("AjouterINTERVENTION_INVOICE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(ID_INTERVENTION == null) Commande.Parameters.AddWithValue("@ID_INTERVENTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INTERVENTION", ID_INTERVENTION);
   if(ID_INVOICE == null) Commande.Parameters.AddWithValue("@ID_INVOICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INVOICE", ID_INVOICE);
   if(PRICE_HOUR == null) Commande.Parameters.AddWithValue("@PRICE_HOUR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE_HOUR", PRICE_HOUR);
   if(PRICE == null) Commande.Parameters.AddWithValue("@PRICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE", PRICE);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int? ID_INTERVENTION, int? ID_INVOICE, double? PRICE_HOUR, double? PRICE, double? TVA)
  {
   CreerCommande("ModifierINTERVENTION_INVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(ID_INTERVENTION == null) Commande.Parameters.AddWithValue("@ID_INTERVENTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INTERVENTION", ID_INTERVENTION);
   if(ID_INVOICE == null) Commande.Parameters.AddWithValue("@ID_INVOICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INVOICE", ID_INVOICE);
   if(PRICE_HOUR == null) Commande.Parameters.AddWithValue("@PRICE_HOUR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE_HOUR", PRICE_HOUR);
   if(PRICE == null) Commande.Parameters.AddWithValue("@PRICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE", PRICE);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_INTERVENTION_INVOICE> Lire(string Index)
  {
   CreerCommande("SelectionnerINTERVENTION_INVOICE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_INTERVENTION_INVOICE> res = new List<C_INTERVENTION_INVOICE>();
   while (dr.Read())
   {
    C_INTERVENTION_INVOICE tmp = new C_INTERVENTION_INVOICE();
    tmp.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_INTERVENTION"] != DBNull.Value) tmp.ID_INTERVENTION = int.Parse(dr["ID_INTERVENTION"].ToString());
   if(dr["ID_INVOICE"] != DBNull.Value) tmp.ID_INVOICE = int.Parse(dr["ID_INVOICE"].ToString());
   if(dr["PRICE_HOUR"] != DBNull.Value) tmp.PRICE_HOUR = double.Parse(dr["PRICE_HOUR"].ToString());
   if(dr["PRICE"] != DBNull.Value) tmp.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) tmp.TVA = double.Parse(dr["TVA"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_INTERVENTION_INVOICE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerINTERVENTION_INVOICE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_INTERVENTION_INVOICE res = new C_INTERVENTION_INVOICE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_INTERVENTION"] != DBNull.Value) res.ID_INTERVENTION = int.Parse(dr["ID_INTERVENTION"].ToString());
   if(dr["ID_INVOICE"] != DBNull.Value) res.ID_INVOICE = int.Parse(dr["ID_INVOICE"].ToString());
   if(dr["PRICE_HOUR"] != DBNull.Value) res.PRICE_HOUR = double.Parse(dr["PRICE_HOUR"].ToString());
   if(dr["PRICE"] != DBNull.Value) res.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) res.TVA = double.Parse(dr["TVA"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerINTERVENTION_INVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
