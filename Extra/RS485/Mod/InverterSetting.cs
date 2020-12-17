// Decompiled with JetBrains decompiler
// Type: Rs485.Mod.InverterSetting
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

namespace PH1800.Extra.RS485.Mod
{
  public class InverterSetting
  {
    public int InverterId { get; set; }

    public string InverterMachineType { get; set; }

    public string InverterSerialNumber { get; set; }

    public string InverterHardwareVersion { get; set; }

    public string InverterSoftwareVersion { get; set; }

    public string InverterBatteryVoltageC { get; set; }

    public string InverterVoltageC { get; set; }

    public string GridVoltageC { get; set; }

    public string BusVoltageC { get; set; }

    public string ControlCurrentC { get; set; }

    public string InverterCurrentC { get; set; }

    public string GridCurrentC { get; set; }

    public string LoadCurrentC { get; set; }

    public string InverterOffgridWorkEnable { get; set; }

    public string InverterOutputVoltageSet { get; set; }

    public string InverterOutputFrequencySet { get; set; }

    public string InverterSearchModeEnable { get; set; }

    public string InverterDischargerToGridEnable { get; set; }

    public string EnergyUseMode { get; set; }

    public string GridProtectStandard { get; set; }

    public string SolarUseAim { get; set; }

    public string InverterMaxDischargerCurrent { get; set; }

    public string NormalVoltagePoint { get; set; }

    public string StartSellVoltagePoint { get; set; }

    public string GridMaxChargerCurrentSet { get; set; }

    public string InverterBatteryLowVoltage { get; set; }

    public string InverterBatteryHighVoltage { get; set; }

    public string MaxCombineChargerCurrent { get; set; }

    public string SystemSetting { get; set; }

    public string ChargerSourcePriority { get; set; }
  }
}
