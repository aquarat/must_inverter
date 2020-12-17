// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.EffectiveRange
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PH1800.Extra.Infrastructure.Models;

namespace Infrastructure.Models
{
  public class EffectiveRange
  {
    [Key]
    public long Erid { get; set; }

    public string Kind { get; set; }

    public string Name { get; set; }

    public int Id { get; set; }

    public string Value { get; set; }

    private static List<EffectiveRange> IniEr()
    {
      return new List<EffectiveRange>()
      {
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "GridFrequencyType",
          Id = 0,
          Value = "50Hz"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "GridFrequencyType",
          Id = 1,
          Value = "60Hz"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "GridVoltageType",
          Id = 0,
          Value = "220V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "GridVoltageType",
          Id = 1,
          Value = "120V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 0,
          Value = "10.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 1,
          Value = "10.1V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 2,
          Value = "10.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 3,
          Value = "10.3V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 4,
          Value = "10.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 5,
          Value = "10.5V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 6,
          Value = "10.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 7,
          Value = "10.7V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 8,
          Value = "10.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 9,
          Value = "10.9V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 10,
          Value = "11.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 11,
          Value = "11.1V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 12,
          Value = "11.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 13,
          Value = "11.3V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 14,
          Value = "11.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 15,
          Value = "11.5V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 16,
          Value = "11.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 17,
          Value = "11.7V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 18,
          Value = "11.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 19,
          Value = "11.9V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage12",
          Id = 20,
          Value = "12.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 0,
          Value = "20.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 11,
          Value = "20.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 2,
          Value = "20.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 3,
          Value = "20.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 4,
          Value = "20.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 5,
          Value = "21.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 6,
          Value = "21.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 7,
          Value = "21.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 8,
          Value = "21.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 9,
          Value = "21.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 10,
          Value = "22.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 11,
          Value = "22.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 12,
          Value = "22.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 13,
          Value = "22.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 14,
          Value = "22.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 15,
          Value = "23.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 16,
          Value = "23.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 17,
          Value = "23.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 18,
          Value = "23.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 19,
          Value = "23.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "ShutdownVoltage24",
          Id = 20,
          Value = "24.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 0,
          Value = "13.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 1,
          Value = "13.9V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 2,
          Value = "14.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 3,
          Value = "14.1V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 4,
          Value = "14.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 5,
          Value = "14.3V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 6,
          Value = "14.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage12",
          Id = 7,
          Value = "14.5V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 0,
          Value = "27.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 1,
          Value = "27.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 2,
          Value = "28.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 3,
          Value = "28.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 4,
          Value = "28.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 5,
          Value = "28.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 6,
          Value = "28.8V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "AbsorptionChargeVoltage24",
          Id = 7,
          Value = "29.0V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage12V",
          Id = 0,
          Value = "13.5V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage12V",
          Id = 1,
          Value = "13.6V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage12V",
          Id = 2,
          Value = "13.7V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage24V",
          Id = 0,
          Value = "27V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage24V",
          Id = 1,
          Value = "27.2V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "FloatChargeVoltage24V",
          Id = 2,
          Value = "27.4V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 0,
          Value = "5A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 1,
          Value = "10A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 2,
          Value = "15A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 3,
          Value = "20A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 4,
          Value = "25A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 5,
          Value = "30A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 6,
          Value = "2A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 7,
          Value = "35A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BulkChargeCurrent",
          Id = 8,
          Value = "40A"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BuzzerSilence",
          Id = 0,
          Value = "Normal"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BuzzerSilence",
          Id = 1,
          Value = "Silence"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BatClass",
          Id = 0,
          Value = "12V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "BatClass",
          Id = 1,
          Value = "24V"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "DelayType",
          Id = 0,
          Value = "Standard"
        },
        new EffectiveRange()
        {
          Kind = "Ep2000Pro",
          Name = "DelayType",
          Id = 1,
          Value = "Long delay"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 1,
          Value = "INIT"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 2,
          Value = "SELF_CHECK"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 3,
          Value = "BACKUP"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 4,
          Value = "LINE"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 5,
          Value = "STOP"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 6,
          Value = "POWER_OFF"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 7,
          Value = "CHARGER"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "WorkState",
          Id = 8,
          Value = "SOFT_START"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BatClass",
          Id = 1,
          Value = "12V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BatClass",
          Id = 2,
          Value = "24V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "LoadState",
          Id = 0,
          Value = "LOAD_NORMAL"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "LoadState",
          Id = 1,
          Value = "LOAD_ALARM"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "LoadState",
          Id = 2,
          Value = "OVER_LOAD"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AvrState",
          Id = 0,
          Value = "AVR_BYPASS"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AvrState",
          Id = 1,
          Value = "AVR_STEPDWON"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AvrState",
          Id = 2,
          Value = "AVR_BOOST"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AvrState",
          Id = 4,
          Value = "AVR_EBOOST"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BuzzerState",
          Id = 0,
          Value = "BUZZ_OFF"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BuzzerState",
          Id = 1,
          Value = "BUZZ_BLEW"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BuzzerState",
          Id = 2,
          Value = "BUZZ_ALARM"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChargeStage",
          Id = 0,
          Value = "CC"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChargeStage",
          Id = 1,
          Value = "CV"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChargeStage",
          Id = 2,
          Value = "FV"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridChargeFlag",
          Id = 0,
          Value = "Grid no charge"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridChargeFlag",
          Id = 1,
          Value = "Grid charge"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "MainSw",
          Id = 0,
          Value = "Off"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "MainSw",
          Id = 1,
          Value = "On"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "DelayType",
          Id = 0,
          Value = "Standard"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "DelayType",
          Id = 1,
          Value = "Long delay"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvStart",
          Id = 0,
          Value = "No PV selfstart"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvStart",
          Id = 1,
          Value = "PV selfstart"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvFlag",
          Id = 0,
          Value = "No PV"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvFlag",
          Id = 1,
          Value = "Have PV"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvChgFlag",
          Id = 0,
          Value = "No PV charge"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "PvChgFlag",
          Id = 1,
          Value = "PV charge"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgSource",
          Id = 0,
          Value = "None"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgSource",
          Id = 1,
          Value = "Solar"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgSource",
          Id = 2,
          Value = "Grid"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgSource",
          Id = 3,
          Value = "Solar&&Grid"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutSource",
          Id = 0,
          Value = "None"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutSource",
          Id = 1,
          Value = "Solar"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutSource",
          Id = 2,
          Value = "Grid"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutSource",
          Id = 3,
          Value = "Solar&&Grid"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridFrequencyType",
          Id = 0,
          Value = "50HZ"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridFrequencyType",
          Id = 1,
          Value = "60HZ"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridVoltageType",
          Id = 0,
          Value = "230V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "GridVoltageType",
          Id = 1,
          Value = "120V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 0,
          Value = "10.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 11,
          Value = "10.1V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 2,
          Value = "10.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 3,
          Value = "10.3V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 4,
          Value = "10.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 5,
          Value = "10.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 6,
          Value = "10.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 7,
          Value = "10.7V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 8,
          Value = "10.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 9,
          Value = "10.9V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 10,
          Value = "11.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 11,
          Value = "11.1V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 12,
          Value = "11.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 13,
          Value = "11.3V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 14,
          Value = "11.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 15,
          Value = "11.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 16,
          Value = "11.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 17,
          Value = "11.7V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 18,
          Value = "11.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 19,
          Value = "11.9V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage12",
          Id = 20,
          Value = "12.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 0,
          Value = "20.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 11,
          Value = "20.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 2,
          Value = "20.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 3,
          Value = "20.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 4,
          Value = "20.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 5,
          Value = "21.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 6,
          Value = "21.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 7,
          Value = "21.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 8,
          Value = "21.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 9,
          Value = "21.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 10,
          Value = "22.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 11,
          Value = "22.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 12,
          Value = "22.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 13,
          Value = "22.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 14,
          Value = "22.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 15,
          Value = "23.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 16,
          Value = "23.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 17,
          Value = "23.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 18,
          Value = "23.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 19,
          Value = "23.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ShutdownVoltage24",
          Id = 20,
          Value = "24.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 0,
          Value = "13.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 1,
          Value = "13.9V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 2,
          Value = "14.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 3,
          Value = "14.1V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 4,
          Value = "14.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 5,
          Value = "14.3V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 6,
          Value = "14.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage12",
          Id = 7,
          Value = "14.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 0,
          Value = "27.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 1,
          Value = "27.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 2,
          Value = "28.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 3,
          Value = "28.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 4,
          Value = "28.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 5,
          Value = "28.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 6,
          Value = "28.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "AbsorptionChargeVoltage24",
          Id = 7,
          Value = "29.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage12",
          Id = 0,
          Value = "13.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage12",
          Id = 1,
          Value = "13.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage12",
          Id = 2,
          Value = "13.7V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage24",
          Id = 0,
          Value = "27V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage24",
          Id = 1,
          Value = "27.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "FloatChargeVoltage24",
          Id = 2,
          Value = "27.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent12",
          Id = 0,
          Value = "10A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent12",
          Id = 1,
          Value = "20A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent12",
          Id = 2,
          Value = "30A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent24",
          Id = 0,
          Value = "5A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent24",
          Id = 1,
          Value = "10A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "BulkCurrent24",
          Id = 2,
          Value = "15A"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Buzzer",
          Id = 0,
          Value = "Normal"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Buzzer",
          Id = 1,
          Value = "Silence"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutPriority",
          Id = 0,
          Value = "Solar first"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutPriority",
          Id = 1,
          Value = "Grid first"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "OutPriority",
          Id = 2,
          Value = "SBU"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgPriority",
          Id = 0,
          Value = "Solar first"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgPriority",
          Id = 1,
          Value = "Grid first"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "ChgPriority",
          Id = 2,
          Value = "Union chg"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv12",
          Id = 0,
          Value = "13.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv12",
          Id = 1,
          Value = "13.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv12",
          Id = 2,
          Value = "13.3V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv12",
          Id = 3,
          Value = "13.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv12",
          Id = 4,
          Value = "12.8V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv24",
          Id = 0,
          Value = "27.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv24",
          Id = 1,
          Value = "27.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv24",
          Id = 2,
          Value = "26.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv24",
          Id = 3,
          Value = "26.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Inv24",
          Id = 4,
          Value = "25.6V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid12",
          Id = 0,
          Value = "11.7V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid12",
          Id = 1,
          Value = "12.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid12",
          Id = 2,
          Value = "12.2V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid12",
          Id = 3,
          Value = "12.5V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid12",
          Id = 4,
          Value = "12.7V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid24",
          Id = 0,
          Value = "23.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid24",
          Id = 1,
          Value = "24.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid24",
          Id = 2,
          Value = "24.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid24",
          Id = 3,
          Value = "25.0V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "Point2Grid24",
          Id = 4,
          Value = "25.4V"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "KeySound",
          Id = 0,
          Value = "Disable"
        },
        new EffectiveRange()
        {
          Kind = "Pv2000",
          Name = "KeySound",
          Id = 1,
          Value = "Enable"
        }
      };
    }

    public static void IniEffectiveRange()
    {
      using (PMEntity pmEntity = new PMEntity())
      {
        pmEntity.EffectiveRanges.AddRange((IEnumerable<EffectiveRange>) EffectiveRange.IniEr());
        pmEntity.SaveChanges();
      }
    }

    public static List<EffectiveRange> GetRangeList()
    {
      List<EffectiveRange> effectiveRangeList = new List<EffectiveRange>();
      using (PMEntity pmEntity = new PMEntity())
        effectiveRangeList.AddRange((IEnumerable<EffectiveRange>) pmEntity.EffectiveRanges.ToList<EffectiveRange>());
      return effectiveRangeList;
    }
  }
}
