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
 public class A_CUSTOMER : ADBase
 {
  #region Constructeurs
  public A_CUSTOMER(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string FIRST_NAME, string LAST_NAME, DateTime? BIRTH_DATE, string ADDRESS, string NUMBER, string POSTAL_CODE, string CITY, string COUNTRY, string PHONE_NUMBER, string EMAIL_ADDRESS, string NATIONAL_NUMBER, DateTime? DATA_REGISTRATION)
  {
   CreerCommande("AjouterCUSTOMER");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(FIRST_NAME == null) Commande.Parameters.AddWithValue("@FIRST_NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FIRST_NAME", FIRST_NAME);
   if(LAST_NAME == null) Commande.Parameters.AddWithValue("@LAST_NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@LAST_NAME", LAST_NAME);
   if(BIRTH_DATE == null) Commande.Parameters.AddWithValue("@BIRTH_DATE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@BIRTH_DATE", BIRTH_DATE);
   if(ADDRESS == null) Commande.Parameters.AddWithValue("@ADDRESS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ADDRESS", ADDRESS);
   if(NUMBER == null) Commande.Parameters.AddWithValue("@NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NUMBER", NUMBER);
   if(POSTAL_CODE == null) Commande.Parameters.AddWithValue("@POSTAL_CODE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@POSTAL_CODE", POSTAL_CODE);
   if(CITY == null) Commande.Parameters.AddWithValue("@CITY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CITY", CITY);
   if(COUNTRY == null) Commande.Parameters.AddWithValue("@COUNTRY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@COUNTRY", COUNTRY);
   if(PHONE_NUMBER == null) Commande.Parameters.AddWithValue("@PHONE_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PHONE_NUMBER", PHONE_NUMBER);
   if(EMAIL_ADDRESS == null) Commande.Parameters.AddWithValue("@EMAIL_ADDRESS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@EMAIL_ADDRESS", EMAIL_ADDRESS);
   if(NATIONAL_NUMBER == null) Commande.Parameters.AddWithValue("@NATIONAL_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NATIONAL_NUMBER", NATIONAL_NUMBER);
   if(DATA_REGISTRATION == null) Commande.Parameters.AddWithValue("@DATA_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATA_REGISTRATION", DATA_REGISTRATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string FIRST_NAME, string LAST_NAME, DateTime? BIRTH_DATE, string ADDRESS, string NUMBER, string POSTAL_CODE, string CITY, string COUNTRY, string PHONE_NUMBER, string EMAIL_ADDRESS, string NATIONAL_NUMBER, DateTime? DATA_REGISTRATION)
  {
   CreerCommande("ModifierCUSTOMER");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(FIRST_NAME == null) Commande.Parameters.AddWithValue("@FIRST_NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FIRST_NAME", FIRST_NAME);
   if(LAST_NAME == null) Commande.Parameters.AddWithValue("@LAST_NAME", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@LAST_NAME", LAST_NAME);
   if(BIRTH_DATE == null) Commande.Parameters.AddWithValue("@BIRTH_DATE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@BIRTH_DATE", BIRTH_DATE);
   if(ADDRESS == null) Commande.Parameters.AddWithValue("@ADDRESS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ADDRESS", ADDRESS);
   if(NUMBER == null) Commande.Parameters.AddWithValue("@NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NUMBER", NUMBER);
   if(POSTAL_CODE == null) Commande.Parameters.AddWithValue("@POSTAL_CODE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@POSTAL_CODE", POSTAL_CODE);
   if(CITY == null) Commande.Parameters.AddWithValue("@CITY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CITY", CITY);
   if(COUNTRY == null) Commande.Parameters.AddWithValue("@COUNTRY", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@COUNTRY", COUNTRY);
   if(PHONE_NUMBER == null) Commande.Parameters.AddWithValue("@PHONE_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PHONE_NUMBER", PHONE_NUMBER);
   if(EMAIL_ADDRESS == null) Commande.Parameters.AddWithValue("@EMAIL_ADDRESS", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@EMAIL_ADDRESS", EMAIL_ADDRESS);
   if(NATIONAL_NUMBER == null) Commande.Parameters.AddWithValue("@NATIONAL_NUMBER", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NATIONAL_NUMBER", NATIONAL_NUMBER);
   if(DATA_REGISTRATION == null) Commande.Parameters.AddWithValue("@DATA_REGISTRATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATA_REGISTRATION", DATA_REGISTRATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_CUSTOMER> Lire(string Index)
  {
   CreerCommande("SelectionnerCUSTOMER");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_CUSTOMER> res = new List<C_CUSTOMER>();
   while (dr.Read())
   {
    C_CUSTOMER tmp = new C_CUSTOMER();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.FIRST_NAME = dr["FIRST_NAME"].ToString();
    tmp.LAST_NAME = dr["LAST_NAME"].ToString();
   if(dr["BIRTH_DATE"] != DBNull.Value) tmp.BIRTH_DATE = DateTime.Parse(dr["BIRTH_DATE"].ToString());
    tmp.ADDRESS = dr["ADDRESS"].ToString();
    tmp.NUMBER = dr["NUMBER"].ToString();
    tmp.POSTAL_CODE = dr["POSTAL_CODE"].ToString();
    tmp.CITY = dr["CITY"].ToString();
    tmp.COUNTRY = dr["COUNTRY"].ToString();
    tmp.PHONE_NUMBER = dr["PHONE_NUMBER"].ToString();
    tmp.EMAIL_ADDRESS = dr["EMAIL_ADDRESS"].ToString();
    tmp.NATIONAL_NUMBER = dr["NATIONAL_NUMBER"].ToString();
   if(dr["DATA_REGISTRATION"] != DBNull.Value) tmp.DATA_REGISTRATION = DateTime.Parse(dr["DATA_REGISTRATION"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_CUSTOMER Lire_ID(int ID)
  {
   CreerCommande("SelectionnerCUSTOMER_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_CUSTOMER res = new C_CUSTOMER();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.FIRST_NAME = dr["FIRST_NAME"].ToString();
    res.LAST_NAME = dr["LAST_NAME"].ToString();
   if(dr["BIRTH_DATE"] != DBNull.Value) res.BIRTH_DATE = DateTime.Parse(dr["BIRTH_DATE"].ToString());
    res.ADDRESS = dr["ADDRESS"].ToString();
    res.NUMBER = dr["NUMBER"].ToString();
    res.POSTAL_CODE = dr["POSTAL_CODE"].ToString();
    res.CITY = dr["CITY"].ToString();
    res.COUNTRY = dr["COUNTRY"].ToString();
    res.PHONE_NUMBER = dr["PHONE_NUMBER"].ToString();
    res.EMAIL_ADDRESS = dr["EMAIL_ADDRESS"].ToString();
    res.NATIONAL_NUMBER = dr["NATIONAL_NUMBER"].ToString();
   if(dr["DATA_REGISTRATION"] != DBNull.Value) res.DATA_REGISTRATION = DateTime.Parse(dr["DATA_REGISTRATION"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerCUSTOMER");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
