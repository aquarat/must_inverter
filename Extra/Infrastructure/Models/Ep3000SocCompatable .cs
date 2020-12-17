// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.Ep3000SocCompatable
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
  public class Ep3000SocCompatable
  {
    [Key]
    public int Id { get; set; }

    public int Soc { get; set; }

    public double Type12V { get; set; }

    public double Type24V { get; set; }

    public double Type48V { get; set; }
  }
}
