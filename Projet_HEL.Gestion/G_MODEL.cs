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
 public class G_MODEL : G_Base
 {
  #region Constructeurs
  public G_MODEL()
   : base()
  { }
  public G_MODEL(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string MODEL, string ENGINE, string FUEL, int? DISPLACEMENT, int? POWER_MAX, int? TORQUE_MAX, int? SPEED_MAX, double? CONSUPTION, int? WEIGHT)
  { return new A_MODEL(ChaineConnexion).Ajouter(MODEL, ENGINE, FUEL, DISPLACEMENT, POWER_MAX, TORQUE_MAX, SPEED_MAX, CONSUPTION, WEIGHT); }
  public int Modifier(int ID, string MODEL, string ENGINE, string FUEL, int? DISPLACEMENT, int? POWER_MAX, int? TORQUE_MAX, int? SPEED_MAX, double? CONSUPTION, int? WEIGHT)
  { return new A_MODEL(ChaineConnexion).Modifier(ID, MODEL, ENGINE, FUEL, DISPLACEMENT, POWER_MAX, TORQUE_MAX, SPEED_MAX, CONSUPTION, WEIGHT); }
  public List<C_MODEL> Lire(string Index)
  { return new A_MODEL(ChaineConnexion).Lire(Index); }
  public C_MODEL Lire_ID(int ID)
  { return new A_MODEL(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_MODEL(ChaineConnexion).Supprimer(ID); }
 }
}
