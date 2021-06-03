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
 public class A_INVOICE : ADBase
 {
  #region Constructeurs
  public A_INVOICE(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_VEHICLE, DateTime? DATE)
  {
   CreerCommande("AjouterINVOICE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(ID_VEHICLE == null) Commande.Parameters.AddWithValue("@ID_VEHICLE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_VEHICLE", ID_VEHICLE);
   if(DATE == null) Commande.Parameters.AddWithValue("@DATE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE", DATE);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int? ID_VEHICLE, DateTime? DATE)
  {
   CreerCommande("ModifierINVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(ID_VEHICLE == null) Commande.Parameters.AddWithValue("@ID_VEHICLE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_VEHICLE", ID_VEHICLE);
   if(DATE == null) Commande.Parameters.AddWithValue("@DATE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE", DATE);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_INVOICE> Lire(string Index)
  {
   CreerCommande("SelectionnerINVOICE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_INVOICE> res = new List<C_INVOICE>();
   while (dr.Read())
   {
    C_INVOICE tmp = new C_INVOICE();
    tmp.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_VEHICLE"] != DBNull.Value) tmp.ID_VEHICLE = int.Parse(dr["ID_VEHICLE"].ToString());
   if(dr["DATE"] != DBNull.Value) tmp.DATE = DateTime.Parse(dr["DATE"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_INVOICE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerINVOICE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_INVOICE res = new C_INVOICE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_VEHICLE"] != DBNull.Value) res.ID_VEHICLE = int.Parse(dr["ID_VEHICLE"].ToString());
   if(dr["DATE"] != DBNull.Value) res.DATE = DateTime.Parse(dr["DATE"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerINVOICE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
