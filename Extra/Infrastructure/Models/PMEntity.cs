// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.PMEntity
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.Data.Entity;
using Infrastructure.Models;
using Model;

namespace PH1800.Extra.Infrastructure.Models
{
  public class PMEntity : DbContext
  {
    public PMEntity()
      : base("name=PMEntity")
    {
    }

    public virtual DbSet<AppParam> Params { get; set; }

    public virtual DbSet<global::Infrastructure.Models.Devices> Devices { get; set; }

    public virtual DbSet<EffectiveRange> EffectiveRanges { get; set; }

    public virtual DbSet<Ep2000Model> Ep2000Models { get; set; }

    public virtual DbSet<Ep3000Model> Ep3000Models { get; set; }

    public virtual DbSet<Ep3000SocCompatable> Ep3000SocCompatables { get; set; }

    public virtual DbSet<Rs485ModelForParal> Rs485Models { get; set; }

    public virtual DbSet<Pv2000ProM> Pv2000ProMs { get; set; }

    public virtual DbSet<Ph1000Model> Ph1000Ms { get; set; }
  }
}
