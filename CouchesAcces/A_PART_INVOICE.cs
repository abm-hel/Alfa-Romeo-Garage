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
 public class A_PART_INVOICE : ADBase
 {
  #region Constructeurs
  public A_PART_INVOICE(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_PART, int? ID_INVOICE, int? QUANTITY_USED, double? PRICE, double? TVA)
  {
   CreerCommande("AjouterPART_INVOICE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(ID_PART == null) Commande.Parameters.AddWithValue("@ID_PART", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_PART", ID_PART);
   if(ID_INVOICE == null) Commande.Parameters.AddWithValue("@ID_INVOICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INVOICE", ID_INVOICE);
   if(QUANTITY_USED == null) Commande.Parameters.AddWithValue("@QUANTITY_USED", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITY_USED", QUANTITY_USED);
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
  public int Modifier(int ID, int? ID_PART, int? ID_INVOICE, int? QUANTITY_USED, double? PRICE, double? TVA)
  {
   CreerCommande("ModifierPART_INVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(ID_PART == null) Commande.Parameters.AddWithValue("@ID_PART", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_PART", ID_PART);
   if(ID_INVOICE == null) Commande.Parameters.AddWithValue("@ID_INVOICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_INVOICE", ID_INVOICE);
   if(QUANTITY_USED == null) Commande.Parameters.AddWithValue("@QUANTITY_USED", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITY_USED", QUANTITY_USED);
   if(PRICE == null) Commande.Parameters.AddWithValue("@PRICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE", PRICE);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_PART_INVOICE> Lire(string Index)
  {
   CreerCommande("SelectionnerPART_INVOICE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_PART_INVOICE> res = new List<C_PART_INVOICE>();
   while (dr.Read())
   {
    C_PART_INVOICE tmp = new C_PART_INVOICE();
    tmp.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_PART"] != DBNull.Value) tmp.ID_PART = int.Parse(dr["ID_PART"].ToString());
   if(dr["ID_INVOICE"] != DBNull.Value) tmp.ID_INVOICE = int.Parse(dr["ID_INVOICE"].ToString());
   if(dr["QUANTITY_USED"] != DBNull.Value) tmp.QUANTITY_USED = int.Parse(dr["QUANTITY_USED"].ToString());
   if(dr["PRICE"] != DBNull.Value) tmp.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) tmp.TVA = double.Parse(dr["TVA"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_PART_INVOICE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPART_INVOICE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_PART_INVOICE res = new C_PART_INVOICE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_PART"] != DBNull.Value) res.ID_PART = int.Parse(dr["ID_PART"].ToString());
   if(dr["ID_INVOICE"] != DBNull.Value) res.ID_INVOICE = int.Parse(dr["ID_INVOICE"].ToString());
   if(dr["QUANTITY_USED"] != DBNull.Value) res.QUANTITY_USED = int.Parse(dr["QUANTITY_USED"].ToString());
   if(dr["PRICE"] != DBNull.Value) res.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) res.TVA = double.Parse(dr["TVA"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPART_INVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
