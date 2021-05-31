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
 public class G_INTERVENTION_INVOICE : G_Base
 {
  #region Constructeurs
  public G_INTERVENTION_INVOICE()
   : base()
  { }
  public G_INTERVENTION_INVOICE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_INTERVENTION, int? ID_INVOICE, double? PRICE_HOUR, double? PRICE, double? TVA)
  { return new A_INTERVENTION_INVOICE(ChaineConnexion).Ajouter(ID_INTERVENTION, ID_INVOICE, PRICE_HOUR, PRICE, TVA); }
  public int Modifier(int ID, int? ID_INTERVENTION, int? ID_INVOICE, double? PRICE_HOUR, double? PRICE, double? TVA)
  { return new A_INTERVENTION_INVOICE(ChaineConnexion).Modifier(ID, ID_INTERVENTION, ID_INVOICE, PRICE_HOUR, PRICE, TVA); }
  public List<C_INTERVENTION_INVOICE> Lire(string Index)
  { return new A_INTERVENTION_INVOICE(ChaineConnexion).Lire(Index); }
  public C_INTERVENTION_INVOICE Lire_ID(int ID)
  { return new A_INTERVENTION_INVOICE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_INTERVENTION_INVOICE(ChaineConnexion).Supprimer(ID); }
 }
}
