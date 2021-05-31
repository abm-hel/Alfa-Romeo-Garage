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
 public class C_INVOICE
 {
  #region Données membres
  private int _ID;
  private int? _ID_VEHICLE;
  private DateTime? _DATE;
  #endregion
  #region Constructeurs
  public C_INVOICE()
  { }
  public C_INVOICE(int? ID_VEHICLE_, DateTime? DATE_)
  {
   ID_VEHICLE = ID_VEHICLE_;
   DATE = DATE_;
  }
  public C_INVOICE(int ID_, int? ID_VEHICLE_, DateTime? DATE_)
   : this(ID_VEHICLE_, DATE_)
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
  public int? ID_VEHICLE
  {
   get { return _ID_VEHICLE; }
   set { _ID_VEHICLE = value; }
  }
  public DateTime? DATE
  {
   get { return _DATE; }
   set { _DATE = value; }
  }
  #endregion
 }
}
