// Decompiled with JetBrains decompiler
// Type: Model.Rs485Model
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
  public class Rs485Model
  {
    [Key]
    public long Id { get; set; }

    public int DeviceID { get; set; }

    public DateTime RecordTime { get; set; }

    public string MachineType { get; set; }

    public string MachineInfo { get; set; }

    public string MachineStartDate { get; set; }

    public string HardwareVersion { get; set; }

    public string SoftwareVersion { get; set; }

    [NotMapped]
    public string PvVoltageC { get; set; }

    [NotMapped]
    public string BatteryVoltageC { get; set; }

    [NotMapped]
    public string ChargerCurrentC { get; set; }

    public string ProductedSerial { get; set; }

    public string ChargerWorkEnable { get; set; }

    public string AbsorbVoltage { get; set; }

    public string RefloatVoltage { get; set; }

    public string FloatVoltag { get; set; }

    public string BatteryLowVoltage { get; set; }

    public string BatteryHighVoltage { get; set; }

    public string MaxChargerCurrent { get; set; }

    public string AbsorbChargerCurrent { get; set; }

    public string BatteryType { get; set; }

    public string BatteryAH { get; set; }

    public string ChargerWorkstate { get; set; }

    public string MpptState { get; set; }

    public string ChargingState { get; set; }

    public string PvVoltage { get; set; }

    public string BatteryVoltage { get; set; }

    public string ChargerCurrent { get; set; }

    public string ChargerPower { get; set; }

    public string RadiatorTemperature { get; set; }

    public string ExternalTemperature { get; set; }

    public string BatteryRelay { get; set; }

    public string PvRelay { get; set; }

    public string ErrorMessage { get; set; }

    public string WarningMessage { get; set; }

    public string BattVolGrade { get; set; }

    public string RatedCurrent { get; set; }

    public string AccumulatedPower { get; set; }

    public string AccumulatedTime { get; set; }

    public string InvMachineType { get; set; }

    public string InvMachineInfo { get; set; }

    public string InvMachineStartDate { get; set; }

    public string InvHardwareVersion { get; set; }

    public string InvSoftwareVersion { get; set; }

    public string InvProductedSerial { get; set; }

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

    public string InverterOngridWorkEnable { get; set; }

    public string InverterChargerFromGridEnable { get; set; }

    public string InverterDischargerEnable { get; set; }

    public string InverterDischargerToGridEnable { get; set; }

    public string EnergyUseMode { get; set; }

    public string TimeModeUseEnable { get; set; }

    public string GridProtectStandard { get; set; }

    public string SolarUseAim { get; set; }

    public string InverterMaxDischargerCurrent { get; set; }

    public string InverterMaxChargerCurrent { get; set; }

    public string GridMaxOutputCurrent { get; set; }

    public string GridMaxInputCurrent { get; set; }

    public string StartChargerVoltagePoint { get; set; }

    public string NormalVoltagePoint { get; set; }

    public string StartSellVoltagePoint { get; set; }

    public string BattLowProtectionMode { get; set; }

    public string GridMaxChargerCurrentSet { get; set; }

    public string AbsorbChargerCurrentSet { get; set; }

    public string InverterBatteryLowVoltage { get; set; }

    public string InverterBatteryHighVoltage { get; set; }

    public string InverterBatteryType { get; set; }

    public string InverterBatteryAH { get; set; }

    public string BatteryLowReturnVoltage { get; set; }

    public string MaxCombineChargerCurrent { get; set; }

    public string ChargerStartTimeH { get; set; }

    public string ChargerStartTimeM { get; set; }

    public string ChargerEndTimeH { get; set; }

    public string ChargerEndTimeM { get; set; }

    public string DischargerStartTimeH { get; set; }

    public string DischargerStartTimeM { get; set; }

    public string DischargerEndTimeH { get; set; }

    public string DischargerEndTimeM { get; set; }

    public string SystemSetting { get; set; }

    public string ChargerSourcePriority { get; set; }

    public string GridtieSafetyType { get; set; }

    public string AutoTestStartCmd { get; set; }

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

    public string PowerRecoverSpeed { get; set; }

    public string OutputQMode { get; set; }

    public string ActivePowerSetting { get; set; }

    public string ReactivePowerSetting { get; set; }

    public short Year { get; set; }

    public short Month { get; set; }

    public short Day { get; set; }

    public short Hour { get; set; }

    public short Minutes { get; set; }

    public short Seconds { get; set; }

    public string ForceChargerEnable { get; set; }

    public string ForceDischargerEnable { get; set; }

    public string WorkState { get; set; }

    public string AcVoltageGrade { get; set; }

    public string RatedPower { get; set; }

    public string InverterBatteryVoltage { get; set; }

    public string InverterVoltage { get; set; }

    public string GridVoltage { get; set; }

    public string BusVoltage { get; set; }

    public string ControlCurrent { get; set; }

    public string InverterCurrent { get; set; }

    public string GridCurrent { get; set; }

    public string LoadCurrent { get; set; }

    public string PInverter { get; set; }

    public string PGrid { get; set; }

    public string PLoad { get; set; }

    public string LoadPercent { get; set; }

    public string SInverter { get; set; }

    public string SGrid { get; set; }

    public string Sload { get; set; }

    public string Qinverter { get; set; }

    public string Qgrid { get; set; }

    public string Qload { get; set; }

    public string InverterFrequency { get; set; }

    public string GridFrequency { get; set; }

    public string InverterMaxNumber { get; set; }

    public string CombineType { get; set; }

    public string InverterNumber { get; set; }

    public string AcRadiatorTemperature { get; set; }

    public string TransformerTemperature { get; set; }

    public string DcRadiatorTemperature { get; set; }

    public string InverterRelayState { get; set; }

    public string GridRelayState { get; set; }

    public string LoadRelayState { get; set; }

    public string N_LineRelayState { get; set; }

    public string DcRelayState { get; set; }

    public string EarthRelayState { get; set; }

    public string AccumulatedChargerPower { get; set; }

    public string AccumulatedDischargerPower { get; set; }

    public string AccumulatedBuyPower { get; set; }

    public string AccumulatedSellPower { get; set; }

    public string AccumulatedLoadPower { get; set; }

    public string AccumulatedSelf_usePower { get; set; }

    public string AccumulatedPV_sellPower { get; set; }

    public string AccumulatedGrid_chargerPower { get; set; }

    public string InverterErrorMessage { get; set; }

    public string InverterWarningMessage { get; set; }

    public string BattPower { get; set; }

    public string BattCurrent { get; set; }

    public Rs485Model(int id)
    {
      this.DeviceID = id;
    }
  }
}
