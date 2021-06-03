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
 public class C_MODEL
 {
  #region Données membres
  private int _ID;
  private string _MODEL;
  private string _ENGINE;
  private string _FUEL;
  private int? _DISPLACEMENT;
  private int? _POWER_MAX;
  private int? _TORQUE_MAX;
  private int? _SPEED_MAX;
  private double? _CONSUPTION;
  private int? _WEIGHT;
  #endregion
  #region Constructeurs
  public C_MODEL()
  { }
  public C_MODEL(string MODEL_, string ENGINE_, string FUEL_, int? DISPLACEMENT_, int? POWER_MAX_, int? TORQUE_MAX_, int? SPEED_MAX_, double? CONSUPTION_, int? WEIGHT_)
  {
   MODEL = MODEL_;
   ENGINE = ENGINE_;
   FUEL = FUEL_;
   DISPLACEMENT = DISPLACEMENT_;
   POWER_MAX = POWER_MAX_;
   TORQUE_MAX = TORQUE_MAX_;
   SPEED_MAX = SPEED_MAX_;
   CONSUPTION = CONSUPTION_;
   WEIGHT = WEIGHT_;
  }
  public C_MODEL(int ID_, string MODEL_, string ENGINE_, string FUEL_, int? DISPLACEMENT_, int? POWER_MAX_, int? TORQUE_MAX_, int? SPEED_MAX_, double? CONSUPTION_, int? WEIGHT_)
   : this(MODEL_, ENGINE_, FUEL_, DISPLACEMENT_, POWER_MAX_, TORQUE_MAX_, SPEED_MAX_, CONSUPTION_, WEIGHT_)
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
  public string MODEL
  {
   get { return _MODEL; }
   set { _MODEL = value; }
  }
  public string ENGINE
  {
   get { return _ENGINE; }
   set { _ENGINE = value; }
  }
  public string FUEL
  {
   get { return _FUEL; }
   set { _FUEL = value; }
  }
  public int? DISPLACEMENT
  {
   get { return _DISPLACEMENT; }
   set { _DISPLACEMENT = value; }
  }
  public int? POWER_MAX
  {
   get { return _POWER_MAX; }
   set { _POWER_MAX = value; }
  }
  public int? TORQUE_MAX
  {
   get { return _TORQUE_MAX; }
   set { _TORQUE_MAX = value; }
  }
  public int? SPEED_MAX
  {
   get { return _SPEED_MAX; }
   set { _SPEED_MAX = value; }
  }
  public double? CONSUPTION
  {
   get { return _CONSUPTION; }
   set { _CONSUPTION = value; }
  }
  public int? WEIGHT
  {
   get { return _WEIGHT; }
   set { _WEIGHT = value; }
  }
  #endregion
 }
}
