// Decompiled with JetBrains decompiler
// Type: Rs485.Mod.ChargerSetting
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

namespace PH1800.Extra.RS485.Mod
{
  public class ChargerSetting
  {
    public int ChargerId { get; set; }

    public string ChargerWorkEnable { get; set; }

    public string AbsorbVoltage { get; set; }

    public string FloatVoltage { get; set; }

    public string AbsorptionVoltage { get; set; }

    public string BatteryLowVoltage { get; set; }

    public string BatteryHighVoltage { get; set; }

    public string MaxChargerCurrent { get; set; }

    public string AbsorbChargerCurrent { get; set; }

    public string BatteryType { get; set; }

    public string BatteryAh { get; set; }
  }
}
