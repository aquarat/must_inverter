// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.Ep3000Status
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

namespace Infrastructure.Models
{
  public class Ep3000Status
  {
    public string UtilityStatus { get; set; }

    public string BatteryVoltageStatus { get; set; }

    public string AvrStatus { get; set; }

    public string UpsStatus { get; set; }

    public string UpsType { get; set; }

    public string TestStatus { get; set; }

    public string ShutDownStatus { get; set; }

    public string BeeperStatus { get; set; }

    public override string ToString()
    {
      return string.Empty + (!string.IsNullOrEmpty(this.UtilityStatus) ? this.UtilityStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.BatteryVoltageStatus) ? this.BatteryVoltageStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.AvrStatus) ? this.AvrStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.UpsStatus) ? this.UpsStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.UpsType) ? this.UpsType + " " : string.Empty) + (!string.IsNullOrEmpty(this.TestStatus) ? this.TestStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.ShutDownStatus) ? this.ShutDownStatus + " " : string.Empty) + (!string.IsNullOrEmpty(this.BeeperStatus) ? this.BeeperStatus + " " : string.Empty);
    }
  }
}
