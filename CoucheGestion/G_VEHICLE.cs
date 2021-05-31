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
 public class G_VEHICLE : G_Base
 {
  #region Constructeurs
  public G_VEHICLE()
   : base()
  { }
  public G_VEHICLE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_MODEL, int? ID_CUSTOMER, string REGISTRATION, DateTime? FIRST_REGISTRATION, DateTime? LAST_REGISTRATION, string CLASS, string VIN_NUMBER, string COLOR, DateTime? DATE_REGISTRATION)
  { return new A_VEHICLE(ChaineConnexion).Ajouter(ID_MODEL, ID_CUSTOMER, REGISTRATION, FIRST_REGISTRATION, LAST_REGISTRATION, CLASS, VIN_NUMBER, COLOR, DATE_REGISTRATION); }
  public int Modifier(int ID, int? ID_MODEL, int? ID_CUSTOMER, string REGISTRATION, DateTime? FIRST_REGISTRATION, DateTime? LAST_REGISTRATION, string CLASS, string VIN_NUMBER, string COLOR, DateTime? DATE_REGISTRATION)
  { return new A_VEHICLE(ChaineConnexion).Modifier(ID, ID_MODEL, ID_CUSTOMER, REGISTRATION, FIRST_REGISTRATION, LAST_REGISTRATION, CLASS, VIN_NUMBER, COLOR, DATE_REGISTRATION); }
  public List<C_VEHICLE> Lire(string Index)
  { return new A_VEHICLE(ChaineConnexion).Lire(Index); }
  public C_VEHICLE Lire_ID(int ID)
  { return new A_VEHICLE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_VEHICLE(ChaineConnexion).Supprimer(ID); }
 }
}
