// Decompiled with JetBrains decompiler
// Type: Model.Annotations.MustUseReturnValueAttribute
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;

namespace Model.Annotations
{
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class MustUseReturnValueAttribute : Attribute
  {
    public MustUseReturnValueAttribute()
    {
    }

    public MustUseReturnValueAttribute([NotNull] string justification)
    {
      this.Justification = justification;
    }

    [CanBeNull]
    public string Justification { get; private set; }
  }
}
