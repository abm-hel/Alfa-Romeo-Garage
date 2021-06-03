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
 public class C_VEHICLE
 {
  #region Données membres
  private int _ID;
  private int? _ID_MODEL;
  private int? _ID_CUSTOMER;
  private string _REGISTRATION;
  private DateTime? _FIRST_REGISTRATION;
  private DateTime? _LAST_REGISTRATION;
  private string _CLASS;
  private string _VIN_NUMBER;
  private string _COLOR;
  private DateTime? _DATE_REGISTRATION;
  #endregion
  #region Constructeurs
  public C_VEHICLE()
  { }
  public C_VEHICLE(int? ID_MODEL_, int? ID_CUSTOMER_, string REGISTRATION_, DateTime? FIRST_REGISTRATION_, DateTime? LAST_REGISTRATION_, string CLASS_, string VIN_NUMBER_, string COLOR_, DateTime? DATE_REGISTRATION_)
  {
   ID_MODEL = ID_MODEL_;
   ID_CUSTOMER = ID_CUSTOMER_;
   REGISTRATION = REGISTRATION_;
   FIRST_REGISTRATION = FIRST_REGISTRATION_;
   LAST_REGISTRATION = LAST_REGISTRATION_;
   CLASS = CLASS_;
   VIN_NUMBER = VIN_NUMBER_;
   COLOR = COLOR_;
   DATE_REGISTRATION = DATE_REGISTRATION_;
  }
  public C_VEHICLE(int ID_, int? ID_MODEL_, int? ID_CUSTOMER_, string REGISTRATION_, DateTime? FIRST_REGISTRATION_, DateTime? LAST_REGISTRATION_, string CLASS_, string VIN_NUMBER_, string COLOR_, DateTime? DATE_REGISTRATION_)
   : this(ID_MODEL_, ID_CUSTOMER_, REGISTRATION_, FIRST_REGISTRATION_, LAST_REGISTRATION_, CLASS_, VIN_NUMBER_, COLOR_, DATE_REGISTRATION_)
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
  public int? ID_MODEL
  {
   get { return _ID_MODEL; }
   set { _ID_MODEL = value; }
  }
  public int? ID_CUSTOMER
  {
   get { return _ID_CUSTOMER; }
   set { _ID_CUSTOMER = value; }
  }
  public string REGISTRATION
  {
   get { return _REGISTRATION; }
   set { _REGISTRATION = value; }
  }
  public DateTime? FIRST_REGISTRATION
  {
   get { return _FIRST_REGISTRATION; }
   set { _FIRST_REGISTRATION = value; }
  }
  public DateTime? LAST_REGISTRATION
  {
   get { return _LAST_REGISTRATION; }
   set { _LAST_REGISTRATION = value; }
  }
  public string CLASS
  {
   get { return _CLASS; }
   set { _CLASS = value; }
  }
  public string VIN_NUMBER
  {
   get { return _VIN_NUMBER; }
   set { _VIN_NUMBER = value; }
  }
  public string COLOR
  {
   get { return _COLOR; }
   set { _COLOR = value; }
  }
  public DateTime? DATE_REGISTRATION
  {
   get { return _DATE_REGISTRATION; }
   set { _DATE_REGISTRATION = value; }
  }
  #endregion
 }
}
