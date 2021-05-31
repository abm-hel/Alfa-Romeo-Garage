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
 public class C_PART_INVOICE
 {
  #region Données membres
  private int _ID;
  private int? _ID_PART;
  private int? _ID_INVOICE;
  private int? _QUANTITY_USED;
  private double? _PRICE;
  private double? _TVA;
  #endregion
  #region Constructeurs
  public C_PART_INVOICE()
  { }
  public C_PART_INVOICE(int? ID_PART_, int? ID_INVOICE_, int? QUANTITY_USED_, double? PRICE_, double? TVA_)
  {
   ID_PART = ID_PART_;
   ID_INVOICE = ID_INVOICE_;
   QUANTITY_USED = QUANTITY_USED_;
   PRICE = PRICE_;
   TVA = TVA_;
  }
  public C_PART_INVOICE(int ID_, int? ID_PART_, int? ID_INVOICE_, int? QUANTITY_USED_, double? PRICE_, double? TVA_)
   : this(ID_PART_, ID_INVOICE_, QUANTITY_USED_, PRICE_, TVA_)
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
  public int? ID_PART
  {
   get { return _ID_PART; }
   set { _ID_PART = value; }
  }
  public int? ID_INVOICE
  {
   get { return _ID_INVOICE; }
   set { _ID_INVOICE = value; }
  }
  public int? QUANTITY_USED
  {
   get { return _QUANTITY_USED; }
   set { _QUANTITY_USED = value; }
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
