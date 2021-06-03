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
 public class G_INVOICE : G_Base
 {
  #region Constructeurs
  public G_INVOICE()
   : base()
  { }
  public G_INVOICE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_VEHICLE, DateTime? DATE)
  { return new A_INVOICE(ChaineConnexion).Ajouter(ID_VEHICLE, DATE); }
  public int Modifier(int ID, int? ID_VEHICLE, DateTime? DATE)
  { return new A_INVOICE(ChaineConnexion).Modifier(ID, ID_VEHICLE, DATE); }
  public List<C_INVOICE> Lire(string Index)
  { return new A_INVOICE(ChaineConnexion).Lire(Index); }
  public C_INVOICE Lire_ID(int ID)
  { return new A_INVOICE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_INVOICE(ChaineConnexion).Supprimer(ID); }
 }
}
