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
 public class G_INTERVENTION : G_Base
 {
  #region Constructeurs
  public G_INTERVENTION()
   : base()
  { }
  public G_INTERVENTION(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string DESCRIPTION, int? NUMBER_HOURS, double? PRICE_HOUR, double? PRIC, double? TVA)
  { return new A_INTERVENTION(ChaineConnexion).Ajouter(DESCRIPTION, NUMBER_HOURS, PRICE_HOUR, PRIC, TVA); }
  public int Modifier(int ID, string DESCRIPTION, int? NUMBER_HOURS, double? PRICE_HOUR, double? PRIC, double? TVA)
  { return new A_INTERVENTION(ChaineConnexion).Modifier(ID, DESCRIPTION, NUMBER_HOURS, PRICE_HOUR, PRIC, TVA); }
  public List<C_INTERVENTION> Lire(string Index)
  { return new A_INTERVENTION(ChaineConnexion).Lire(Index); }
  public C_INTERVENTION Lire_ID(int ID)
  { return new A_INTERVENTION(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_INTERVENTION(ChaineConnexion).Supprimer(ID); }
 }
}
