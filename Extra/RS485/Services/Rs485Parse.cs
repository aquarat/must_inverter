// Decompiled with JetBrains decompiler
// Type: Rs485.Services.Rs485Parse
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

using Infrastructure.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rs485.Services
{
  public static class Rs485Parse
  {
    public static readonly string[] ChargerWorkEnable = new string[2]
    {
      "OFF",
      "ON"
    };
    public static readonly string[] BatteryType = new string[7]
    {
      "",
      "Use defined battery",
      "Lithium battery ",
      "SEALED_LEAD  battery",
      "AGM  battery",
      "GEL  battery",
      "FLOODED  battery"
    };
    public static readonly string[] ChargerWorkstate = new string[4]
    {
      "Initialization mode ",
      "Selftest Mode",
      "Work Mode",
      "Stop Mode"
    };
    public static readonly string[] MpptState = new string[3]
    {
      "Stop",
      "MPPT",
      "Current limiting"
    };
    public static readonly string[] ChargingState = new string[3]
    {
      "Stop",
      "Absorb charge",
      " Float charge"
    };
    public static readonly string[] ConnectStates = new string[2]
    {
      "Disconnect",
      "Connect"
    };
    public static readonly string[] EnergyUseMode = new string[5]
    {
      "",
      "SBU",
      "SUB",
      "UTI",
      "SOL"
    };
    public static readonly string[] GridProtectStandard = new string[4]
    {
      "VDE4105",
      "UPS",
      "Home",
      "GEN"
    };
    public static readonly string[] SolarUseAim = new string[2]
    {
      "LBU",
      "BLU"
    };
    public static readonly string[] SystemSettingBit = new string[16]
    {
      "OverLoadRestartForbid",
      "OverTempRestartForbid",
      "OverLoadBypassForbid",
      "AutoTurnPageFlagForbid",
      "GridBuzzEnable(only use by PV1800)",
      "BuzzForbide(only use by PV1800)",
      "LcdLightEnable",
      "RecordFaultForbid",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      ""
    };
    public static readonly string[] ChargerSourcePriority = new string[4]
    {
      "Soalr first",
      "",
      "Solar and Utility(default)",
      "Only Solar"
    };
    public static readonly string[] WorkState = new string[7]
    {
      "PowerOn",
      "SelfTest",
      "OffGrid",
      "Grid-Tie",
      "ByPass",
      "Stop",
      "Grid charging"
    };
    public static readonly string[] InverterError1 = new string[16]
    {
      "Fan is locked when inverter is off",
      "Inverter transformer over temperature",
      "battery voltage is too high",
      "battery voltage is too low",
      "Output short circuited",
      "Inverter output voltage is high",
      "Overload time out",
      "Inverter bus voltage is too high",
      "Bus soft start failed",
      "Main relay failed",
      "Inverter output voltage sensor error",
      "Inverter grid voltage sensor error",
      "Inverter output current sensor error",
      "Inverter grid current sensor error",
      "Inverter load current sensor error",
      "Inverter grid over current error"
    };
    public static readonly string[] InverterError2 = new string[16]
    {
      "Inverter radiator over temperature",
      "Solar charger battery voltage class error",
      "Solar charger current sensor error",
      "Solar charger current is uncontrollable",
      "Inverter grid voltage is low",
      "Inverter grid voltage is high",
      "Inverter grid under frequency",
      "Inverter grid over frequency",
      "Inverter over current protection error",
      "Inverter bus voltage is too low",
      "Inverter soft start failed",
      "Over DC voltage in AC output",
      "Battery connection is open",
      "Inverter control current sensor error",
      "Inverter output voltage is too low",
      ""
    };
    public static readonly string[] InverterWarning = new string[16]
    {
      "Fan is locked when inverter is on.",
      "Fan2 is locked when inverter is on.",
      "Battery is over-charged.",
      "Low battery",
      "Overload",
      "Output power derating",
      "Solar charger stops due to low battery.",
      "Solar charger stops due to high PV voltage.",
      "Solar charger stops due to over load.",
      "Solar charger over temperature",
      "PV charger communication error ",
      "",
      "",
      "",
      "",
      ""
    };
    public static readonly string[] ChargerError = new string[16]
    {
      "Hardware protection",
      "Over current",
      "Current sensor error",
      "Over temperature",
      "PV voltage is too high",
      "",
      "Battery voltage is too high",
      "Battery voltage is too Low",
      "Current is uncontrollable",
      "Parameter error",
      "",
      "",
      "",
      "",
      "",
      ""
    };
    public static readonly string[] ChargerWarning = new string[16]
    {
      "Fan Error",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      ""
    };

    public enum CurOrited
    {
      WLtoR,
      NTtoB,
      NBtoT,
      ELtoR,
      STtoB,
      SBtoT,
    }
    
    public static DeviceStates AnalysisData(Rs485ModelForParal rs485ModelForParal)
    {
      string[] strArray1 = new string[4];
      States[] partStates = new States[5];
      int num1 = ((IEnumerable<string>) Rs485Parse.WorkState).ToList<string>().IndexOf(rs485ModelForParal.WorkState);
      CurOrited curOrited;
      switch (num1)
      {
        case 2:
        case 3:
        case 4:
        case 6:
          string[] strArray2 = strArray1;
          curOrited = CurOrited.ELtoR;
          string str1 = curOrited.ToString();
          strArray2[2] = str1;
          break;
      }
      int result1;
      double numFromString;
      if (int.TryParse(Regex.Match(rs485ModelForParal.PGrid, "\\d+").Value, out result1))
      {
        numFromString = StringParse.GetNumFromString(rs485ModelForParal.RatedPower);
        double result2;
        int num2 = double.TryParse(numFromString.ToString((IFormatProvider) CultureInfo.InvariantCulture), out result2) ? 1 : 0;
        numFromString = StringParse.GetNumFromString(rs485ModelForParal.InverterSoftwareVersion.Replace(".", ""));
        double result3;
        bool flag = double.TryParse(numFromString.ToString((IFormatProvider) CultureInfo.InvariantCulture), out result3);
        int num3 = (int) result2;
        int num4 = (int) result3;
        int num5 = flag ? 1 : 0;
        if ((num2 & num5) != 0 && num4 > 20000 && (num3 == 20000 || num3 == 3000) && (num1 == 3 || num1 == 4 || num1 == 6))
        {
          string[] strArray3 = strArray1;
          curOrited = CurOrited.NTtoB;
          string str2 = curOrited.ToString();
          strArray3[1] = str2;
        }
        else if (num1 == 6)
        {
          string[] strArray3 = strArray1;
          curOrited = CurOrited.NTtoB;
          string str2 = curOrited.ToString();
          strArray3[1] = str2;
        }
        else
        {
          if (result1 > 0)
          {
            string[] strArray3 = strArray1;
            curOrited = CurOrited.NBtoT;
            string str2 = curOrited.ToString();
            strArray3[1] = str2;
          }
          if (result1 < 0)
          {
            string[] strArray3 = strArray1;
            curOrited = CurOrited.NTtoB;
            string str2 = curOrited.ToString();
            strArray3[1] = str2;
          }
        }
      }
      numFromString = StringParse.GetNumFromString(rs485ModelForParal.BattCurrent);
      double result4;
      if (double.TryParse(numFromString.ToString((IFormatProvider) CultureInfo.InvariantCulture), out result4))
      {
        if (num1 == 6)
        {
          string[] strArray3 = strArray1;
          curOrited = CurOrited.SBtoT;
          string str2 = curOrited.ToString();
          strArray3[3] = str2;
        }
        else
        {
          if (result4 > 0.0)
          {
            string[] strArray3 = strArray1;
            curOrited = CurOrited.SBtoT;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
          if (result4 < 0.0)
          {
            string[] strArray3 = strArray1;
            curOrited = CurOrited.STtoB;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
          if (result1 == 0 && Math.Abs(result4) < 0.1)
          {
            string[] strArray3 = strArray1;
            curOrited = CurOrited.SBtoT;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
        }
      }
      numFromString = StringParse.GetNumFromString(rs485ModelForParal.ChargerPower);
      double result5;
      if (double.TryParse(numFromString.ToString((IFormatProvider) CultureInfo.InvariantCulture), out result5) && (int) result5 != 0)
      {
        string[] strArray3 = strArray1;
        curOrited = CurOrited.WLtoR;
        string str2 = curOrited.ToString();
        strArray3[0] = str2;
      }
      double? soc = new double?(100.0);
      string[] curOrient = strArray1;
      return new DeviceStates(partStates, soc, curOrient);
    }
  }
  
  
  
  public class DeviceStates
  {
    public static readonly string[] Oriented = new string[6]
    {
      "WLtoR",
      "NTtoB",
      "NBtoT",
      "ELtoR",
      "STtoB",
      "SBtoT"
    };

    public DeviceStates()
    {
      this.AcState = States.NotHave;
      this.PvState = States.NotHave;
      this.LoadState = States.NotHave;
      this.BatState = States.NotHave;
      this.CoreState = States.NotHave;
      this.Soc = new double?(0.0);
      this.CurOrient = (string[]) null;
    }

    public DeviceStates(
      States pvStates,
      States acStates,
      States loadStates,
      States batStates,
      double? soc,
      string[] curOrient = null)
    {
      this.PvState = pvStates;
      this.AcState = acStates;
      this.LoadState = loadStates;
      this.BatState = batStates;
      this.Soc = soc;
      this.CurOrient = curOrient;
    }

    public DeviceStates(States[] partStates, double? soc, string[] curOrient = null)
    {
      if (partStates == null)
        throw new Exception("States parameters can not be null");
      if (partStates.Length != 5)
        throw new Exception(string.Format("States parameters demand 5,provide {0}", (object) partStates.Length));
      this.PvState = partStates[0];
      this.AcState = partStates[1];
      this.LoadState = partStates[2];
      this.BatState = partStates[3];
      this.CoreState = partStates[4];
      this.Soc = soc;
      this.CurOrient = curOrient;
    }

    public States AcState { get; set; }

    public States PvState { get; set; }

    public States LoadState { get; set; }

    public States BatState { get; set; }

    public States CoreState { get; set; }

    public double? Soc { get; set; }

    public string[] CurOrient { get; set; }
  }
  
  public enum States
  {
    Have,
    NotHave,
    Warning,
  }
}

