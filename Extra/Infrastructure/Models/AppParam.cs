// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.AppParam
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
  public class AppParam
  {
    [Key]
    public long Id { get; set; }

    public bool AutoSensePort { get; set; }

    public bool AutoRun { get; set; }

    public string DefaultModule { get; set; }

    public string Ep3000DefaultBatType { get; set; }

    public int AutoSaveInterval { get; set; }
  }
}
