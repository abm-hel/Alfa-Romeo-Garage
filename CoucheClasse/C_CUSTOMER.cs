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
 public class C_CUSTOMER
 {
  #region Données membres
  private int _ID;
  private string _FIRST_NAME;
  private string _LAST_NAME;
  private DateTime? _BIRTH_DATE;
  private string _ADDRESS;
  private string _NUMBER;
  private string _POSTAL_CODE;
  private string _CITY;
  private string _COUNTRY;
  private string _PHONE_NUMBER;
  private string _EMAIL_ADDRESS;
  private string _NATIONAL_NUMBER;
  private DateTime? _DATA_REGISTRATION;
  #endregion
  #region Constructeurs
  public C_CUSTOMER()
  { }
  public C_CUSTOMER(string FIRST_NAME_, string LAST_NAME_, DateTime? BIRTH_DATE_, string ADDRESS_, string NUMBER_, string POSTAL_CODE_, string CITY_, string COUNTRY_, string PHONE_NUMBER_, string EMAIL_ADDRESS_, string NATIONAL_NUMBER_, DateTime? DATA_REGISTRATION_)
  {
   FIRST_NAME = FIRST_NAME_;
   LAST_NAME = LAST_NAME_;
   BIRTH_DATE = BIRTH_DATE_;
   ADDRESS = ADDRESS_;
   NUMBER = NUMBER_;
   POSTAL_CODE = POSTAL_CODE_;
   CITY = CITY_;
   COUNTRY = COUNTRY_;
   PHONE_NUMBER = PHONE_NUMBER_;
   EMAIL_ADDRESS = EMAIL_ADDRESS_;
   NATIONAL_NUMBER = NATIONAL_NUMBER_;
   DATA_REGISTRATION = DATA_REGISTRATION_;
  }
  public C_CUSTOMER(int ID_, string FIRST_NAME_, string LAST_NAME_, DateTime? BIRTH_DATE_, string ADDRESS_, string NUMBER_, string POSTAL_CODE_, string CITY_, string COUNTRY_, string PHONE_NUMBER_, string EMAIL_ADDRESS_, string NATIONAL_NUMBER_, DateTime? DATA_REGISTRATION_)
   : this(FIRST_NAME_, LAST_NAME_, BIRTH_DATE_, ADDRESS_, NUMBER_, POSTAL_CODE_, CITY_, COUNTRY_, PHONE_NUMBER_, EMAIL_ADDRESS_, NATIONAL_NUMBER_, DATA_REGISTRATION_)
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
  public string FIRST_NAME
  {
   get { return _FIRST_NAME; }
   set { _FIRST_NAME = value; }
  }
  public string LAST_NAME
  {
   get { return _LAST_NAME; }
   set { _LAST_NAME = value; }
  }
  public DateTime? BIRTH_DATE
  {
   get { return _BIRTH_DATE; }
   set { _BIRTH_DATE = value; }
  }
  public string ADDRESS
  {
   get { return _ADDRESS; }
   set { _ADDRESS = value; }
  }
  public string NUMBER
  {
   get { return _NUMBER; }
   set { _NUMBER = value; }
  }
  public string POSTAL_CODE
  {
   get { return _POSTAL_CODE; }
   set { _POSTAL_CODE = value; }
  }
  public string CITY
  {
   get { return _CITY; }
   set { _CITY = value; }
  }
  public string COUNTRY
  {
   get { return _COUNTRY; }
   set { _COUNTRY = value; }
  }
  public string PHONE_NUMBER
  {
   get { return _PHONE_NUMBER; }
   set { _PHONE_NUMBER = value; }
  }
  public string EMAIL_ADDRESS
  {
   get { return _EMAIL_ADDRESS; }
   set { _EMAIL_ADDRESS = value; }
  }
  public string NATIONAL_NUMBER
  {
   get { return _NATIONAL_NUMBER; }
   set { _NATIONAL_NUMBER = value; }
  }
  public DateTime? DATA_REGISTRATION
  {
   get { return _DATA_REGISTRATION; }
   set { _DATA_REGISTRATION = value; }
  }
  #endregion
 }
}
