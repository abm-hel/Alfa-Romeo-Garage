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
 public class A_PART : ADBase
 {
  #region Constructeurs
  public A_PART(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NAME, string PRODUCER, double? PRICE, double? TVA, int? QUANTITY)
  {
   CreerCommande("AjouterPART");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(NAME == null) Commande.Parameters.AddWithValue("@NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NAME", NAME);
   if(PRODUCER == null) Commande.Parameters.AddWithValue("@PRODUCER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRODUCER", PRODUCER);
   if(PRICE == null) Commande.Parameters.AddWithValue("@PRICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE", PRICE);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   if(QUANTITY == null) Commande.Parameters.AddWithValue("@QUANTITY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITY", QUANTITY);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string NAME, string PRODUCER, double? PRICE, double? TVA, int? QUANTITY)
  {
   CreerCommande("ModifierPART");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(NAME == null) Commande.Parameters.AddWithValue("@NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NAME", NAME);
   if(PRODUCER == null) Commande.Parameters.AddWithValue("@PRODUCER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRODUCER", PRODUCER);
   if(PRICE == null) Commande.Parameters.AddWithValue("@PRICE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRICE", PRICE);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   if(QUANTITY == null) Commande.Parameters.AddWithValue("@QUANTITY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITY", QUANTITY);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_PART> Lire(string Index)
  {
   CreerCommande("SelectionnerPART");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_PART> res = new List<C_PART>();
   while (dr.Read())
   {
    C_PART tmp = new C_PART();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.NAME = dr["NAME"].ToString();
    tmp.PRODUCER = dr["PRODUCER"].ToString();
   if(dr["PRICE"] != DBNull.Value) tmp.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) tmp.TVA = double.Parse(dr["TVA"].ToString());
   if(dr["QUANTITY"] != DBNull.Value) tmp.QUANTITY = int.Parse(dr["QUANTITY"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_PART Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPART_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_PART res = new C_PART();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.NAME = dr["NAME"].ToString();
    res.PRODUCER = dr["PRODUCER"].ToString();
   if(dr["PRICE"] != DBNull.Value) res.PRICE = double.Parse(dr["PRICE"].ToString());
   if(dr["TVA"] != DBNull.Value) res.TVA = double.Parse(dr["TVA"].ToString());
   if(dr["QUANTITY"] != DBNull.Value) res.QUANTITY = int.Parse(dr["QUANTITY"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPART");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
