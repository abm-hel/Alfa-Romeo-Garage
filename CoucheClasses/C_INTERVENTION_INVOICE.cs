#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_HEL.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_INTERVENTION_INVOICE
 {
  #region Données membres
  private int _ID;
  private int? _ID_INTERVENTION;
  private int? _ID_INVOICE;
  private double? _PRICE_HOUR;
  private double? _PRICE;
  private double? _TVA;
  #endregion
  #region Constructeurs
  public C_INTERVENTION_INVOICE()
  { }
  public C_INTERVENTION_INVOICE(int? ID_INTERVENTION_, int? ID_INVOICE_, double? PRICE_HOUR_, double? PRICE_, double? TVA_)
  {
   ID_INTERVENTION = ID_INTERVENTION_;
   ID_INVOICE = ID_INVOICE_;
   PRICE_HOUR = PRICE_HOUR_;
   PRICE = PRICE_;
   TVA = TVA_;
  }
  public C_INTERVENTION_INVOICE(int ID_, int? ID_INTERVENTION_, int? ID_INVOICE_, double? PRICE_HOUR_, double? PRICE_, double? TVA_)
   : this(ID_INTERVENTION_, ID_INVOICE_, PRICE_HOUR_, PRICE_, TVA_)
  {
   ID = ID_;
  }
  #endregion
  #region Accesseurs
  public int ID
  {
   get { return _ID; }
   set { _ID = value; }
  }
  public int? ID_INTERVENTION
  {
   get { return _ID_INTERVENTION; }
   set { _ID_INTERVENTION = value; }
  }
  public int? ID_INVOICE
  {
   get { return _ID_INVOICE; }
   set { _ID_INVOICE = value; }
  }
  public double? PRICE_HOUR
  {
   get { return _PRICE_HOUR; }
   set { _PRICE_HOUR = value; }
  }
  public double? PRICE
  {
   get { return _PRICE; }
   set { _PRICE = value; }
  }
  public double? TVA
  {
   get { return _TVA; }
   set { _TVA = value; }
  }
  #endregion
 }
}
