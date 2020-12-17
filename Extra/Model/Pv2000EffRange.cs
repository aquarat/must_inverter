// Decompiled with JetBrains decompiler
// Type: Model.Pv2000EffRange
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System.Collections.Generic;

namespace Model
{
  public static class Pv2000EffRange
  {
    public static Dictionary<int, string> WorkState = new Dictionary<int, string>()
    {
      [1] = "INIT",
      [2] = "SELF_CHECK",
      [3] = "BACKUP",
      [4] = "LINE",
      [5] = "STOP",
      [6] = "POWER_OFF",
      [7] = "CHARGER",
      [8] = "SOFT_START"
    };
    public static Dictionary<int, string> BatClass = new Dictionary<int, string>()
    {
      [1] = "12V",
      [1] = "24V"
    };
    public static Dictionary<int, string> LoadState = new Dictionary<int, string>()
    {
      [0] = "LOAD_NORMAL",
      [1] = "LOAD_ALARM",
      [2] = "OVER_LOAD"
    };
    public static Dictionary<int, string> AvrState = new Dictionary<int, string>()
    {
      [0] = "AVR_BYPASS",
      [1] = "AVR_STEPDWON",
      [2] = "AVR_BOOST",
      [4] = "AVR_EBOOST"
    };
    public static Dictionary<int, string> BuzzerState = new Dictionary<int, string>()
    {
      [0] = "BUZZ_OFF",
      [1] = "BUZZ_BLEW",
      [2] = "BUZZ_ALARM"
    };
    public static Dictionary<int, string> ChargeStage = new Dictionary<int, string>()
    {
      [0] = "CC",
      [1] = "CV",
      [2] = "FV"
    };
    public static Dictionary<int, string> GridChargeFlag = new Dictionary<int, string>()
    {
      [1] = "Grid charge",
      [0] = "Grid no charge"
    };
    public static Dictionary<int, string> MainSW = new Dictionary<int, string>()
    {
      [0] = "Off",
      [1] = "On"
    };
    public static Dictionary<int, string> DelayType = new Dictionary<int, string>()
    {
      [0] = "Standard",
      [1] = "Long delay"
    };
    public static Dictionary<int, string> PvStart = new Dictionary<int, string>()
    {
      [0] = "No pv selfstart",
      [1] = "Pv selfstart"
    };
    public static Dictionary<int, string> PvFlag = new Dictionary<int, string>()
    {
      [0] = "No PV",
      [1] = "have PV"
    };
    public static Dictionary<int, string> PvChgFlag = new Dictionary<int, string>()
    {
      [0] = "No pv charge",
      [1] = "Pv charge"
    };
    public static Dictionary<int, string> ChgSource = new Dictionary<int, string>()
    {
      [0] = "None",
      [1] = "Solar",
      [2] = "Grid",
      [3] = "Solar&&Grid"
    };
    public static Dictionary<int, string> InvSource = new Dictionary<int, string>()
    {
      [0] = "Battery",
      [1] = "PV",
      [2] = "Bat && PV",
      [3] = "grid"
    };
    public static Dictionary<int, string> GridFrequencyType = new Dictionary<int, string>()
    {
      [0] = "50HZ",
      [1] = "60HZ"
    };
    public static Dictionary<int, string> GridVoltageType = new Dictionary<int, string>()
    {
      [0] = "230V",
      [1] = "120V"
    };
    public static Dictionary<int, string> ShutdownVoltage12 = new Dictionary<int, string>()
    {
      [0] = "11V",
      [1] = "10.9V",
      [2] = "10.8V",
      [3] = "10.7V",
      [4] = "10.6V",
      [5] = "10.5V"
    };
    public static Dictionary<int, string> ShutdownVoltage24 = new Dictionary<int, string>()
    {
      [0] = "22V",
      [1] = "21.8V",
      [2] = "21.6V",
      [3] = "21.4V",
      [4] = "21.2V",
      [5] = "21V"
    };
    public static Dictionary<int, string> AbsorptionChargeVoltage12 = new Dictionary<int, string>()
    {
      [0] = "14V",
      [1] = "14.2V",
      [2] = "14.4V"
    };
    public static Dictionary<int, string> AbsorptionChargeVoltage24 = new Dictionary<int, string>()
    {
      [0] = "28V",
      [1] = "28.4V",
      [2] = "28.8V"
    };
    public static Dictionary<int, string> FloatChargeVoltage12 = new Dictionary<int, string>()
    {
      [0] = "13.5V",
      [1] = "13.6V",
      [2] = "13.7V"
    };
    public static Dictionary<int, string> FloatChargeVoltage24 = new Dictionary<int, string>()
    {
      [0] = "27V",
      [1] = "27.2V",
      [2] = "27.4V"
    };
    public static Dictionary<int, string> BulkCurrent12 = new Dictionary<int, string>()
    {
      [0] = "10A",
      [1] = "20A",
      [2] = "30A"
    };
    public static Dictionary<int, string> BulkCurrent24 = new Dictionary<int, string>()
    {
      [0] = "5A",
      [1] = "10A",
      [2] = "15A"
    };
    public static Dictionary<int, string> Buzzer = new Dictionary<int, string>()
    {
      [0] = "Normal",
      [1] = "Silence"
    };
    public static Dictionary<int, string> OutPriority = new Dictionary<int, string>()
    {
      [0] = "Solar first",
      [1] = "Grid first",
      [2] = "SBU"
    };
    public static Dictionary<int, string> ChgPriority = new Dictionary<int, string>()
    {
      [0] = "Solar first",
      [1] = "Only solar",
      [2] = "Union charge"
    };
    public static Dictionary<int, string> Point2Inv12 = new Dictionary<int, string>()
    {
      [0] = "13.8V",
      [1] = "13.5V",
      [2] = "13.3V",
      [3] = "13.0V",
      [4] = "12.8V"
    };
    public static Dictionary<int, string> Point2Inv24 = new Dictionary<int, string>()
    {
      [0] = "27.6V",
      [1] = "27.0V",
      [2] = "26.6V",
      [3] = "26.0V",
      [4] = "25.6V"
    };
    public static Dictionary<int, string> Point2Grid12 = new Dictionary<int, string>()
    {
      [0] = "11.7V",
      [1] = "12.0V",
      [2] = "12.2V",
      [3] = "12.5V",
      [4] = "12.7V"
    };
    public static Dictionary<int, string> Point2Grid24 = new Dictionary<int, string>()
    {
      [0] = "23.4V",
      [1] = "24.0V",
      [2] = "24.4V",
      [3] = "25.0V",
      [4] = "25.4V"
    };
    public static Dictionary<int, string> KeySound = new Dictionary<int, string>()
    {
      [0] = "Disable",
      [1] = "Enable"
    };
  }
}
