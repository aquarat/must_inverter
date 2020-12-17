// Decompiled with JetBrains decompiler
// Type: Model.Ph1000Model
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
  public class Ph1000Model
  {
    [Key]
    public long Id { get; set; }

    public int ChargerId { get; set; }

    public int InverterId { get; set; }

    public DateTime RecordTime { get; set; }

    public string ChargerWorkEnable { get; set; }

    public string AbsorbVoltage { get; set; }

    public string RefloatVoltage { get; set; }

    public string FloatVoltage { get; set; }

    public string BatteryLowVoltage { get; set; }

    public string BatteryHighVoltage { get; set; }

    public string MaxChargerCurrent { get; set; }

    public string AbsorbChargerCurrent { get; set; }

    public string BatteryType { get; set; }

    public string BatteryAH { get; set; }

    public string ChargerWorkstate { get; set; }

    public string BatteryVoltage { get; set; }

    public string BatteryCurrent { get; set; }

    public string BatteryPower { get; set; }

    public string ChargerTemperature { get; set; }

    public string PV1Voltage { get; set; }

    public string PV1Current { get; set; }

    public string PV1Power { get; set; }

    public string PV2Voltage { get; set; }

    public string PV2Current { get; set; }

    public string PV2Power { get; set; }

    public string PvPower { get; set; }

    public string InvMachineType { get; set; }

    public string InvMachineInfo { get; set; }

    public string InvMachineStartDate { get; set; }

    public string InvHardwareVersion { get; set; }

    public string InvSoftwareVersion { get; set; }

    public string InvProductedSerial { get; set; }

    public string InverterChargerFromGridEnable { get; set; }

    public string InverterDischargerToGridEnable { get; set; }

    public string InverterMaxDischargerCurrent { get; set; }

    public string InverterMaxChargerCurrent { get; set; }

    public string ChargerStartTimeH { get; set; }

    public string ChargerStartTimeM { get; set; }

    public string ChargerEndTimeH { get; set; }

    public string ChargerEndTimeM { get; set; }

    public string DischargerStartTimeH { get; set; }

    public string DischargerStartTimeM { get; set; }

    public string DischargerEndTimeH { get; set; }

    public string DischargerEndTimeM { get; set; }

    public string GridtieSafetyType { get; set; }

    public string GridLVPSlowProtetionValue { get; set; }

    public string GridLVPSlowProtetionTime { get; set; }

    public string GridOVPSlowProtetionValue { get; set; }

    public string GridOVPSlowProtetionTime { get; set; }

    public string GridLVPFastProtetionValue { get; set; }

    public string GridLVPFastProtetionTime { get; set; }

    public string GridOVPFastProtetionValue { get; set; }

    public string GridOVPFastProtetionTime { get; set; }

    public string FrequencyLowProtectionValue { get; set; }

    public string FrequencylowProtectionTime { get; set; }

    public string FrequencyHighProtectionValue { get; set; }

    public string FrequencyHighProtectionTime { get; set; }

    public string ReconectTime { get; set; }

    public string Q_UCharacteristicCurveStartPoint { get; set; }

    public string PF_PCharacteristicCurvePowerPoint { get; set; }

    public string PF_PCharacteristicCurveVoltPoint { get; set; }

    public string PowerRecovedevpeed { get; set; }

    public string OutputQMode { get; set; }

    public string ActivePowedevetting { get; set; }

    public string ReactivePowedevetting { get; set; }

    public short Year { get; set; }

    public short Month { get; set; }

    public short Day { get; set; }

    public short Hour { get; set; }

    public short Minutes { get; set; }

    public short Seconds { get; set; }

    public string WorkState { get; set; }

    public string InverterVoltage { get; set; }

    public string GridVoltage { get; set; }

    public string GridCurrent { get; set; }

    public string InverterCurrent { get; set; }

    public string LoadCurrent { get; set; }

    public string GridPower { get; set; }

    public string LoadPower { get; set; }

    public string GridFrequency { get; set; }

    public string InverterTemperature { get; set; }

    public string TotalRechargeEnergy { get; set; }

    public string TotalDischargeEnergy { get; set; }

    public string TotalSellEnergy { get; set; }

    public string TotalGenerateEnergy { get; set; }

    public string ErrorMessage { get; set; }

    public string WarningMessage { get; set; }

    public string DailySellEnergy { get; set; }

    public string DailyGenerateEnergy { get; set; }

    public string DailyRechargeEnergy { get; set; }

    public string DailyDischargeEnergy { get; set; }
  }
}
