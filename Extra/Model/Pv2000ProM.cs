// Decompiled with JetBrains decompiler
// Type: Model.Pv2000ProM
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
  public class Pv2000ProM : IDataModel
  {
    public long Id { get; set; }

    public string MachineType { get; set; }

    public string SoftwareVersion { get; set; }

    public string WorkState { get; set; }

    [NotMapped]
    public int BatClassInt { get; set; }

    public string BatClass { get; set; }

    [NotMapped]
    public int RatedPowerInt { get; set; }

    public string RatedPower { get; set; }

    public string GridVoltage { get; set; }

    public string GridFrequency { get; set; }

    public string OutputVoltage { get; set; }

    public string OutputFrequency { get; set; }

    public string LoadCurrent { get; set; }

    public string LoadPower { get; set; }

    public string LoadVa { get; set; }

    public string LoadPercent { get; set; }

    public string BatteryVoltage { get; set; }

    public string BatteryCurrent { get; set; }

    public string BatterySoc { get; set; }

    public string TransformerTemp { get; set; }

    [NotMapped]
    public string AvrState { get; set; }

    [NotMapped]
    public string BuzzerState { get; set; }

    public string SystemFault { get; set; }

    public string SystemAlarm { get; set; }

    [NotMapped]
    public string ChargeStage { get; set; }

    [NotMapped]
    public string GridChargeFlag { get; set; }

    [NotMapped]
    public string MainSw { get; set; }

    [NotMapped]
    public string DelayType { get; set; }

    [NotMapped]
    public string PvStart { get; set; }

    [NotMapped]
    public int PvFlagInt { get; set; }

    [NotMapped]
    public string PvFlag { get; set; }

    [NotMapped]
    public int PvChgFlagInt { get; set; }

    [NotMapped]
    public string PvChgFlag { get; set; }

    public string PvTemp { get; set; }

    public string PvV { get; set; }

    public string PvI { get; set; }

    public string PvPower { get; set; }

    [NotMapped]
    public string ChgSource { get; set; }

    [NotMapped]
    public int OutSourceInt { get; set; }

    [NotMapped]
    public string OutSource { get; set; }

    public DateTime RecordTime { get; set; }

    [NotMapped]
    public int GridFrequencyType { get; set; }

    [NotMapped]
    public string GridVoltageType { get; set; }

    [NotMapped]
    public string ShutdownVoltage { get; set; }

    [NotMapped]
    public string AbsorptionChargeVoltage { get; set; }

    [NotMapped]
    public string FloatChargeVoltage { get; set; }

    [NotMapped]
    public string BulkCurrent { get; set; }

    [NotMapped]
    public int Buzzer { get; set; }

    [NotMapped]
    public int EnableBacklight { get; set; }

    [NotMapped]
    public string GridChargeCurrent { get; set; }

    [NotMapped]
    public int OutPriority { get; set; }

    [NotMapped]
    public int ChgPriority { get; set; }

    [NotMapped]
    public string Point2Inv { get; set; }

    [NotMapped]
    public string Point2Grid { get; set; }

    [NotMapped]
    public int GridPowerOn { get; set; }
  }
}
