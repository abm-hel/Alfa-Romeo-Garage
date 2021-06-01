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
 public class C_PART
 {
  #region Données membres
  private int _ID;
  private string _NAME;
  private string _PRODUCER;
  private double? _PRICE;
  private double? _TVA;
  private int? _QUANTITY;
  #endregion
  #region Constructeurs
  public C_PART()
  { }
  public C_PART(string NAME_, string PRODUCER_, double? PRICE_, double? TVA_, int? QUANTITY_)
  {
   NAME = NAME_;
   PRODUCER = PRODUCER_;
   PRICE = PRICE_;
   TVA = TVA_;
   QUANTITY = QUANTITY_;
  }
  public C_PART(int ID_, string NAME_, string PRODUCER_, double? PRICE_, double? TVA_, int? QUANTITY_)
   : this(NAME_, PRODUCER_, PRICE_, TVA_, QUANTITY_)
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
  public string NAME
  {
   get { return _NAME; }
   set { _NAME = value; }
  }
  public string PRODUCER
  {
   get { return _PRODUCER; }
   set { _PRODUCER = value; }
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
  public int? QUANTITY
  {
   get { return _QUANTITY; }
   set { _QUANTITY = value; }
  }
  #endregion
 }
}
