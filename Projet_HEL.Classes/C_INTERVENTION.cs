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
 public class C_INTERVENTION
 {
  #region Données membres
  private int _ID;
  private string _DESCRIPTION;
  private int? _NUMBER_HOURS;
  private double? _PRICE_HOUR;
  private double? _PRIC;
  private double? _TVA;
  #endregion
  #region Constructeurs
  public C_INTERVENTION()
  { }
  public C_INTERVENTION(string DESCRIPTION_, int? NUMBER_HOURS_, double? PRICE_HOUR_, double? PRIC_, double? TVA_)
  {
   DESCRIPTION = DESCRIPTION_;
   NUMBER_HOURS = NUMBER_HOURS_;
   PRICE_HOUR = PRICE_HOUR_;
   PRIC = PRIC_;
   TVA = TVA_;
  }
  public C_INTERVENTION(int ID_, string DESCRIPTION_, int? NUMBER_HOURS_, double? PRICE_HOUR_, double? PRIC_, double? TVA_)
   : this(DESCRIPTION_, NUMBER_HOURS_, PRICE_HOUR_, PRIC_, TVA_)
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
  public string DESCRIPTION
  {
   get { return _DESCRIPTION; }
   set { _DESCRIPTION = value; }
  }
  public int? NUMBER_HOURS
  {
   get { return _NUMBER_HOURS; }
   set { _NUMBER_HOURS = value; }
  }
  public double? PRICE_HOUR
  {
   get { return _PRICE_HOUR; }
   set { _PRICE_HOUR = value; }
  }
  public double? PRIC
  {
   get { return _PRIC; }
   set { _PRIC = value; }
  }
  public double? TVA
  {
   get { return _TVA; }
   set { _TVA = value; }
  }
  #endregion
 }
}
