// Decompiled with JetBrains decompiler
// Type: Model.Annotations.ImplicitUseTargetFlags
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;

namespace Model.Annotations
{
  [Flags]
  public enum ImplicitUseTargetFlags
  {
    Default = 1,
    Itself = Default, // 0x00000001
    Members = 2,
    WithMembers = Members | Itself, // 0x00000003
  }
}
