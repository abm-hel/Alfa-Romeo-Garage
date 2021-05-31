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
 public class G_PART_INVOICE : G_Base
 {
  #region Constructeurs
  public G_PART_INVOICE()
   : base()
  { }
  public G_PART_INVOICE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_PART, int? ID_INVOICE, int? QUANTITY_USED, double? PRICE, double? TVA)
  { return new A_PART_INVOICE(ChaineConnexion).Ajouter(ID_PART, ID_INVOICE, QUANTITY_USED, PRICE, TVA); }
  public int Modifier(int ID, int? ID_PART, int? ID_INVOICE, int? QUANTITY_USED, double? PRICE, double? TVA)
  { return new A_PART_INVOICE(ChaineConnexion).Modifier(ID, ID_PART, ID_INVOICE, QUANTITY_USED, PRICE, TVA); }
  public List<C_PART_INVOICE> Lire(string Index)
  { return new A_PART_INVOICE(ChaineConnexion).Lire(Index); }
  public C_PART_INVOICE Lire_ID(int ID)
  { return new A_PART_INVOICE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_PART_INVOICE(ChaineConnexion).Supprimer(ID); }
 }
}
