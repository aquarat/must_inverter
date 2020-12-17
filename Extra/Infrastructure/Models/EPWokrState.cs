// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.EPWokrState
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

namespace Infrastructure.Models
{
  public enum EPWokrState
  {
    INIT = 1,
    SELF_CHECK = 2,
    BACKUP = 3,
    LINE = 4,
    STOP = 5,
    POWER_OFF = 6,
    GRID_CHG = 7,
    SOFT_START = 8,
  }
}
