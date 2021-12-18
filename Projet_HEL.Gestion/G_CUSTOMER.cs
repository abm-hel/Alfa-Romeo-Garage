#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_HEL.Classes;
using Projet_HEL.Acces;
#endregion

namespace Projet_HEL.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_CUSTOMER : G_Base
 {
  #region Constructeurs
  public G_CUSTOMER()
   : base()
  { }
  public G_CUSTOMER(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string FIRST_NAME, string LAST_NAME, DateTime? BIRTH_DATE, string ADDRESS, string NUMBER, string POSTAL_CODE, string CITY, string COUNTRY, string PHONE_NUMBER, string EMAIL_ADDRESS, string NATIONAL_NUMBER, DateTime? DATA_REGISTRATION)
  { return new A_CUSTOMER(ChaineConnexion).Ajouter(FIRST_NAME, LAST_NAME, BIRTH_DATE, ADDRESS, NUMBER, POSTAL_CODE, CITY, COUNTRY, PHONE_NUMBER, EMAIL_ADDRESS, NATIONAL_NUMBER, DATA_REGISTRATION); }
  public int Modifier(int ID, string FIRST_NAME, string LAST_NAME, DateTime? BIRTH_DATE, string ADDRESS, string NUMBER, string POSTAL_CODE, string CITY, string COUNTRY, string PHONE_NUMBER, string EMAIL_ADDRESS, string NATIONAL_NUMBER, DateTime? DATA_REGISTRATION)
  { return new A_CUSTOMER(ChaineConnexion).Modifier(ID, FIRST_NAME, LAST_NAME, BIRTH_DATE, ADDRESS, NUMBER, POSTAL_CODE, CITY, COUNTRY, PHONE_NUMBER, EMAIL_ADDRESS, NATIONAL_NUMBER, DATA_REGISTRATION); }
  public List<C_CUSTOMER> Lire(string Index)
  { return new A_CUSTOMER(ChaineConnexion).Lire(Index); }
  public C_CUSTOMER Lire_ID(int ID)
  { return new A_CUSTOMER(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_CUSTOMER(ChaineConnexion).Supprimer(ID); }
 }
}
