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
 public class A_VEHICLE : ADBase
 {
  #region Constructeurs
  public A_VEHICLE(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_MODEL, int? ID_CUSTOMER, string REGISTRATION, DateTime? FIRST_REGISTRATION, DateTime? LAST_REGISTRATION, string CLASS, string VIN_NUMBER, string COLOR, DateTime? DATE_REGISTRATION)
  {
   CreerCommande("AjouterVEHICLE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(ID_MODEL == null) Commande.Parameters.AddWithValue("@ID_MODEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_MODEL", ID_MODEL);
   if(ID_CUSTOMER == null) Commande.Parameters.AddWithValue("@ID_CUSTOMER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
   if(REGISTRATION == null) Commande.Parameters.AddWithValue("@REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@REGISTRATION", REGISTRATION);
   if(FIRST_REGISTRATION == null) Commande.Parameters.AddWithValue("@FIRST_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FIRST_REGISTRATION", FIRST_REGISTRATION);
   if(LAST_REGISTRATION == null) Commande.Parameters.AddWithValue("@LAST_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@LAST_REGISTRATION", LAST_REGISTRATION);
   if(CLASS == null) Commande.Parameters.AddWithValue("@CLASS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CLASS", CLASS);
   if(VIN_NUMBER == null) Commande.Parameters.AddWithValue("@VIN_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@VIN_NUMBER", VIN_NUMBER);
   if(COLOR == null) Commande.Parameters.AddWithValue("@COLOR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@COLOR", COLOR);
   if(DATE_REGISTRATION == null) Commande.Parameters.AddWithValue("@DATE_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE_REGISTRATION", DATE_REGISTRATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int? ID_MODEL, int? ID_CUSTOMER, string REGISTRATION, DateTime? FIRST_REGISTRATION, DateTime? LAST_REGISTRATION, string CLASS, string VIN_NUMBER, string COLOR, DateTime? DATE_REGISTRATION)
  {
   CreerCommande("ModifierVEHICLE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(ID_MODEL == null) Commande.Parameters.AddWithValue("@ID_MODEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_MODEL", ID_MODEL);
   if(ID_CUSTOMER == null) Commande.Parameters.AddWithValue("@ID_CUSTOMER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
   if(REGISTRATION == null) Commande.Parameters.AddWithValue("@REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@REGISTRATION", REGISTRATION);
   if(FIRST_REGISTRATION == null) Commande.Parameters.AddWithValue("@FIRST_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FIRST_REGISTRATION", FIRST_REGISTRATION);
   if(LAST_REGISTRATION == null) Commande.Parameters.AddWithValue("@LAST_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@LAST_REGISTRATION", LAST_REGISTRATION);
   if(CLASS == null) Commande.Parameters.AddWithValue("@CLASS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CLASS", CLASS);
   if(VIN_NUMBER == null) Commande.Parameters.AddWithValue("@VIN_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@VIN_NUMBER", VIN_NUMBER);
   if(COLOR == null) Commande.Parameters.AddWithValue("@COLOR", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@COLOR", COLOR);
   if(DATE_REGISTRATION == null) Commande.Parameters.AddWithValue("@DATE_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE_REGISTRATION", DATE_REGISTRATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_VEHICLE> Lire(string Index)
  {
   CreerCommande("SelectionnerVEHICLE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_VEHICLE> res = new List<C_VEHICLE>();
   while (dr.Read())
   {
    C_VEHICLE tmp = new C_VEHICLE();
    tmp.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_MODEL"] != DBNull.Value) tmp.ID_MODEL = int.Parse(dr["ID_MODEL"].ToString());
   if(dr["ID_CUSTOMER"] != DBNull.Value) tmp.ID_CUSTOMER = int.Parse(dr["ID_CUSTOMER"].ToString());
    tmp.REGISTRATION = dr["REGISTRATION"].ToString();
   if(dr["FIRST_REGISTRATION"] != DBNull.Value) tmp.FIRST_REGISTRATION = DateTime.Parse(dr["FIRST_REGISTRATION"].ToString());
   if(dr["LAST_REGISTRATION"] != DBNull.Value) tmp.LAST_REGISTRATION = DateTime.Parse(dr["LAST_REGISTRATION"].ToString());
    tmp.CLASS = dr["CLASS"].ToString();
    tmp.VIN_NUMBER = dr["VIN_NUMBER"].ToString();
    tmp.COLOR = dr["COLOR"].ToString();
   if(dr["DATE_REGISTRATION"] != DBNull.Value) tmp.DATE_REGISTRATION = DateTime.Parse(dr["DATE_REGISTRATION"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_VEHICLE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerVEHICLE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_VEHICLE res = new C_VEHICLE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
   if(dr["ID_MODEL"] != DBNull.Value) res.ID_MODEL = int.Parse(dr["ID_MODEL"].ToString());
   if(dr["ID_CUSTOMER"] != DBNull.Value) res.ID_CUSTOMER = int.Parse(dr["ID_CUSTOMER"].ToString());
    res.REGISTRATION = dr["REGISTRATION"].ToString();
   if(dr["FIRST_REGISTRATION"] != DBNull.Value) res.FIRST_REGISTRATION = DateTime.Parse(dr["FIRST_REGISTRATION"].ToString());
   if(dr["LAST_REGISTRATION"] != DBNull.Value) res.LAST_REGISTRATION = DateTime.Parse(dr["LAST_REGISTRATION"].ToString());
    res.CLASS = dr["CLASS"].ToString();
    res.VIN_NUMBER = dr["VIN_NUMBER"].ToString();
    res.COLOR = dr["COLOR"].ToString();
   if(dr["DATE_REGISTRATION"] != DBNull.Value) res.DATE_REGISTRATION = DateTime.Parse(dr["DATE_REGISTRATION"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerVEHICLE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
