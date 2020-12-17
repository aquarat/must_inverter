// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.Ep2000Model
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
  public class Ep2000Model
  {
    public static readonly Dictionary<int, string> FaultDic = new Dictionary<int, string>()
    {
      {
        0,
        ""
      },
      {
        1,
        "Fan is locked when inverter is off"
      },
      {
        2,
        "Inverter transformer over temperature"
      },
      {
        3,
        "battery voltage is too high"
      },
      {
        4,
        "battery voltage is too low"
      },
      {
        5,
        "Output short circuited"
      },
      {
        6,
        "Inverter output voltage is high"
      },
      {
        7,
        "Overload time out"
      },
      {
        8,
        "Inverter bus voltage is too high"
      },
      {
        9,
        "Bus soft start failed"
      },
      {
        11,
        "Main relay failed"
      },
      {
        21,
        "Inverter output voltage sensor error"
      },
      {
        22,
        "Inverter grid voltage sensor error"
      },
      {
        23,
        "Inverter output current sensor error"
      },
      {
        24,
        "Inverter grid current sensor error"
      },
      {
        25,
        "Inverter load current sensor error"
      },
      {
        26,
        "Inverter grid over current error"
      },
      {
        27,
        "Inverter radiator over temperature"
      },
      {
        31,
        "Solar charger battery voltage class error"
      },
      {
        32,
        "Solar charger current sensor error"
      },
      {
        33,
        "Solar charger current is uncontrollable"
      },
      {
        41,
        "Inverter grid voltage is low"
      },
      {
        42,
        "Inverter grid voltage is high"
      },
      {
        43,
        "Inverter grid under frequency"
      },
      {
        44,
        "Inverter grid over frequency"
      },
      {
        51,
        "Inverter over current protection error"
      },
      {
        52,
        "Inverter bus voltage is too low"
      },
      {
        53,
        "Inverter soft start failed"
      },
      {
        54,
        "Over DC voltage in AC output"
      },
      {
        56,
        "Battery connection is open"
      },
      {
        57,
        "Inverter control current sensor error"
      },
      {
        58,
        "Inverter output voltage is too low"
      },
      {
        61,
        "Fan is locked when inverter is on."
      },
      {
        62,
        "Fan2 is locked when inverter is on."
      },
      {
        63,
        "Battery is over-charged."
      },
      {
        64,
        "Low battery"
      },
      {
        67,
        "Overload"
      },
      {
        70,
        "Output power Derating"
      },
      {
        72,
        "Solar charger stops due to low battery"
      },
      {
        73,
        "Solar charger stops due to high PV voltage"
      },
      {
        74,
        "Solar charger stops due to over load"
      },
      {
        75,
        "Solar charger over temperature"
      },
      {
        76,
        "PV charger communication error"
      },
      {
        77,
        "Parameter error"
      }
    };
    public static readonly Dictionary<int, string[]> BatteryLowVoltageDic = new Dictionary<int, string[]>();
    public static readonly Dictionary<int, string[]> ConstantChargeVoltageDic = new Dictionary<int, string[]>();
    public static readonly Dictionary<int, string[]> FloatChargeVoltageDic = new Dictionary<int, string[]>();
    public static readonly List<string> BulkChargeCurrentDic = new List<string>();

    static Ep2000Model()
    {
      Ep2000Model.BatteryLowVoltageDic.Add(0, new string[21]
      {
        "10.0V",
        "10.1V",
        "10.2V",
        "10.3V",
        "10.4V",
        "10.5V",
        "10.6V",
        "10.7V",
        "10.8V",
        "10.9V",
        "11.0V",
        "11.1V",
        "11.2V",
        "11.3V",
        "11.4V",
        "11.5V",
        "11.6V",
        "11.7V",
        "11.8V",
        "11.9V",
        "12.0V"
      });
      Ep2000Model.BatteryLowVoltageDic.Add(1, new string[21]
      {
        "20.0V",
        "20.2V",
        "20.4V",
        "20.6V",
        "20.8V",
        "21.0V",
        "21.2V",
        "21.4V",
        "21.6V",
        "21.8V",
        "22.0V",
        "22.2V",
        "22.4V",
        "22.6V",
        "22.8V",
        "23V",
        "23.2V",
        "23.4V",
        "23.6V",
        "23.8V",
        "24.0V"
      });
      Ep2000Model.ConstantChargeVoltageDic.Add(0, new string[8]
      {
        "13.8V",
        "13.9V",
        "14.0V",
        "14.1V",
        "14.2V",
        "14.3V",
        "14.4V",
        "14.5V"
      });
      Ep2000Model.ConstantChargeVoltageDic.Add(1, new string[8]
      {
        "27.6V",
        "27.8V",
        "28.0V",
        "28.2V",
        "28.4V",
        "28.6V",
        "28.8V",
        "29V"
      });
      Ep2000Model.FloatChargeVoltageDic.Add(0, new string[3]
      {
        "13.5V",
        "13.6V",
        "13.7V"
      });
      Ep2000Model.FloatChargeVoltageDic.Add(1, new string[3]
      {
        "27V",
        "27.2V",
        "27.4V"
      });
      Ep2000Model.BulkChargeCurrentDic.AddRange((IEnumerable<string>) new List<string>()
      {
        "5A",
        "10A",
        "15A",
        "20A",
        "25A",
        "30A"
      });
    }

    [Key]
    public long Id { get; set; }

    public string MachineType { get; set; }

    public string SoftwareVersion { get; set; }

    public string WorkState { get; set; }

    public string BatClass { get; set; }

    public string RatedPower { get; set; }

    public string GridVoltage { get; set; }

    public string GridFrequency { get; set; }

    public string OutputVoltage { get; set; }

    public string OutputFrequency { get; set; }

    public string LoadCurrent { get; set; }

    public string LoadPower { get; set; }

    public string LoadPercent { get; set; }

    public string LoadState { get; set; }

    public string BatteryVoltage { get; set; }

    public string BatteryCurrent { get; set; }

    public string BatterySoc { get; set; }

    public string TransformerTemp { get; set; }

    public string AvrState { get; set; }

    public string BuzzerState { get; set; }

    public string Fault { get; set; }

    public string Alarm { get; set; }

    public string ChargeState { get; set; }

    public string ChargeFlag { get; set; }

    public string MainSw { get; set; }

    public string DelayType { get; set; }

    public string GridFrequencyType { get; set; }

    public string GridVoltageType { get; set; }

    public string BatteryLowVoltage { get; set; }

    public string ConstantChargeVoltage { get; set; }

    public string FloatChargeVoltage { get; set; }

    public string BulkChargeCurrent { get; set; }

    public string BuzzerSilence { get; set; }

    public string EnableGridCharge { get; set; }

    public string EnableKeySound { get; set; }

    public string EnableBacklight { get; set; }

    public DateTime RecordTime { get; set; }
  }
}
