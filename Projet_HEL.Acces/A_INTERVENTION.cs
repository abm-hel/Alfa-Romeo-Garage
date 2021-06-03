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
 public class A_INTERVENTION : ADBase
 {
  #region Constructeurs
  public A_INTERVENTION(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string DESCRIPTION, int? NUMBER_HOURS, double? PRICE_HOUR, double? PRIC, double? TVA)
  {
   CreerCommande("AjouterINTERVENTION");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(DESCRIPTION == null) Commande.Parameters.AddWithValue("@DESCRIPTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DESCRIPTION", DESCRIPTION);
   if(NUMBER_HOURS == null) Commande.Parameters.AddWithValue("@NUMBER_HOURS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NUMBER_HOURS", NUMBER_HOURS);
   if(PRICE_HOUR == null) Commande.Parameters.AddWithValue("@PRICE_HOUR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE_HOUR", PRICE_HOUR);
   if(PRIC == null) Commande.Parameters.AddWithValue("@PRIC", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRIC", PRIC);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string DESCRIPTION, int? NUMBER_HOURS, double? PRICE_HOUR, double? PRIC, double? TVA)
  {
   CreerCommande("ModifierINTERVENTION");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(DESCRIPTION == null) Commande.Parameters.AddWithValue("@DESCRIPTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DESCRIPTION", DESCRIPTION);
   if(NUMBER_HOURS == null) Commande.Parameters.AddWithValue("@NUMBER_HOURS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NUMBER_HOURS", NUMBER_HOURS);
   if(PRICE_HOUR == null) Commande.Parameters.AddWithValue("@PRICE_HOUR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE_HOUR", PRICE_HOUR);
   if(PRIC == null) Commande.Parameters.AddWithValue("@PRIC", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRIC", PRIC);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_INTERVENTION> Lire(string Index)
  {
   CreerCommande("SelectionnerINTERVENTION");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_INTERVENTION> res = new List<C_INTERVENTION>();
   while (dr.Read())
   {
    C_INTERVENTION tmp = new C_INTERVENTION();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.DESCRIPTION = dr["DESCRIPTION"].ToString();
   if(dr["NUMBER_HOURS"] != DBNull.Value) tmp.NUMBER_HOURS = int.Parse(dr["NUMBER_HOURS"].ToString());
   if(dr["PRICE_HOUR"] != DBNull.Value) tmp.PRICE_HOUR = double.Parse(dr["PRICE_HOUR"].ToString());
   if(dr["PRIC"] != DBNull.Value) tmp.PRIC = double.Parse(dr["PRIC"].ToString());
   if(dr["TVA"] != DBNull.Value) tmp.TVA = double.Parse(dr["TVA"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_INTERVENTION Lire_ID(int ID)
  {
   CreerCommande("SelectionnerINTERVENTION_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_INTERVENTION res = new C_INTERVENTION();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.DESCRIPTION = dr["DESCRIPTION"].ToString();
   if(dr["NUMBER_HOURS"] != DBNull.Value) res.NUMBER_HOURS = int.Parse(dr["NUMBER_HOURS"].ToString());
   if(dr["PRICE_HOUR"] != DBNull.Value) res.PRICE_HOUR = double.Parse(dr["PRICE_HOUR"].ToString());
   if(dr["PRIC"] != DBNull.Value) res.PRIC = double.Parse(dr["PRIC"].ToString());
   if(dr["TVA"] != DBNull.Value) res.TVA = double.Parse(dr["TVA"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerINTERVENTION");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
