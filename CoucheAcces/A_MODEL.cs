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
 public class A_MODEL : ADBase
 {
  #region Constructeurs
  public A_MODEL(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string MODEL, string ENGINE, string FUEL, int? DISPLACEMENT, int? POWER_MAX, int? TORQUE_MAX, int? SPEED_MAX, double? CONSUPTION, int? WEIGHT)
  {
   CreerCommande("AjouterMODEL");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   if(MODEL == null) Commande.Parameters.AddWithValue("@MODEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@MODEL", MODEL);
   if(ENGINE == null) Commande.Parameters.AddWithValue("@ENGINE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ENGINE", ENGINE);
   if(FUEL == null) Commande.Parameters.AddWithValue("@FUEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FUEL", FUEL);
   if(DISPLACEMENT == null) Commande.Parameters.AddWithValue("@DISPLACEMENT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DISPLACEMENT", DISPLACEMENT);
   if(POWER_MAX == null) Commande.Parameters.AddWithValue("@POWER_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@POWER_MAX", POWER_MAX);
   if(TORQUE_MAX == null) Commande.Parameters.AddWithValue("@TORQUE_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TORQUE_MAX", TORQUE_MAX);
   if(SPEED_MAX == null) Commande.Parameters.AddWithValue("@SPEED_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SPEED_MAX", SPEED_MAX);
   if(CONSUPTION == null) Commande.Parameters.AddWithValue("@CONSUPTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CONSUPTION", CONSUPTION);
   if(WEIGHT == null) Commande.Parameters.AddWithValue("@WEIGHT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@WEIGHT", WEIGHT);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string MODEL, string ENGINE, string FUEL, int? DISPLACEMENT, int? POWER_MAX, int? TORQUE_MAX, int? SPEED_MAX, double? CONSUPTION, int? WEIGHT)
  {
   CreerCommande("ModifierMODEL");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   if(MODEL == null) Commande.Parameters.AddWithValue("@MODEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@MODEL", MODEL);
   if(ENGINE == null) Commande.Parameters.AddWithValue("@ENGINE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ENGINE", ENGINE);
   if(FUEL == null) Commande.Parameters.AddWithValue("@FUEL", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@FUEL", FUEL);
   if(DISPLACEMENT == null) Commande.Parameters.AddWithValue("@DISPLACEMENT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DISPLACEMENT", DISPLACEMENT);
   if(POWER_MAX == null) Commande.Parameters.AddWithValue("@POWER_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@POWER_MAX", POWER_MAX);
   if(TORQUE_MAX == null) Commande.Parameters.AddWithValue("@TORQUE_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TORQUE_MAX", TORQUE_MAX);
   if(SPEED_MAX == null) Commande.Parameters.AddWithValue("@SPEED_MAX", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@SPEED_MAX", SPEED_MAX);
   if(CONSUPTION == null) Commande.Parameters.AddWithValue("@CONSUPTION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@CONSUPTION", CONSUPTION);
   if(WEIGHT == null) Commande.Parameters.AddWithValue("@WEIGHT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@WEIGHT", WEIGHT);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_MODEL> Lire(string Index)
  {
   CreerCommande("SelectionnerMODEL");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_MODEL> res = new List<C_MODEL>();
   while (dr.Read())
   {
    C_MODEL tmp = new C_MODEL();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.MODEL = dr["MODEL"].ToString();
    tmp.ENGINE = dr["ENGINE"].ToString();
    tmp.FUEL = dr["FUEL"].ToString();
   if(dr["DISPLACEMENT"] != DBNull.Value) tmp.DISPLACEMENT = int.Parse(dr["DISPLACEMENT"].ToString());
   if(dr["POWER_MAX"] != DBNull.Value) tmp.POWER_MAX = int.Parse(dr["POWER_MAX"].ToString());
   if(dr["TORQUE_MAX"] != DBNull.Value) tmp.TORQUE_MAX = int.Parse(dr["TORQUE_MAX"].ToString());
   if(dr["SPEED_MAX"] != DBNull.Value) tmp.SPEED_MAX = int.Parse(dr["SPEED_MAX"].ToString());
   if(dr["CONSUPTION"] != DBNull.Value) tmp.CONSUPTION = double.Parse(dr["CONSUPTION"].ToString());
   if(dr["WEIGHT"] != DBNull.Value) tmp.WEIGHT = int.Parse(dr["WEIGHT"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_MODEL Lire_ID(int ID)
  {
   CreerCommande("SelectionnerMODEL_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_MODEL res = new C_MODEL();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.MODEL = dr["MODEL"].ToString();
    res.ENGINE = dr["ENGINE"].ToString();
    res.FUEL = dr["FUEL"].ToString();
   if(dr["DISPLACEMENT"] != DBNull.Value) res.DISPLACEMENT = int.Parse(dr["DISPLACEMENT"].ToString());
   if(dr["POWER_MAX"] != DBNull.Value) res.POWER_MAX = int.Parse(dr["POWER_MAX"].ToString());
   if(dr["TORQUE_MAX"] != DBNull.Value) res.TORQUE_MAX = int.Parse(dr["TORQUE_MAX"].ToString());
   if(dr["SPEED_MAX"] != DBNull.Value) res.SPEED_MAX = int.Parse(dr["SPEED_MAX"].ToString());
   if(dr["CONSUPTION"] != DBNull.Value) res.CONSUPTION = double.Parse(dr["CONSUPTION"].ToString());
   if(dr["WEIGHT"] != DBNull.Value) res.WEIGHT = int.Parse(dr["WEIGHT"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerMODEL");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
