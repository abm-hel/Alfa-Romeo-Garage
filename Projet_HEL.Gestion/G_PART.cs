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
 public class G_PART : G_Base
 {
  #region Constructeurs
  public G_PART()
   : base()
  { }
  public G_PART(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NAME, string PRODUCER, double? PRICE, double? TVA, int? QUANTITY)
  { return new A_PART(ChaineConnexion).Ajouter(NAME, PRODUCER, PRICE, TVA, QUANTITY); }
  public int Modifier(int ID, string NAME, string PRODUCER, double? PRICE, double? TVA, int? QUANTITY)
  { return new A_PART(ChaineConnexion).Modifier(ID, NAME, PRODUCER, PRICE, TVA, QUANTITY); }
  public List<C_PART> Lire(string Index)
  { return new A_PART(ChaineConnexion).Lire(Index); }
  public C_PART Lire_ID(int ID)
  { return new A_PART(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_PART(ChaineConnexion).Supprimer(ID); }
 }
}
