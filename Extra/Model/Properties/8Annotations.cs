﻿// Decompiled with JetBrains decompiler
// Type: Model.Annotations.PublicAPIAttribute
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;

namespace Model.Annotations
{
  [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
  public sealed class PublicAPIAttribute : Attribute
  {
    public PublicAPIAttribute()
    {
    }

    public PublicAPIAttribute([NotNull] string comment)
    {
      this.Comment = comment;
    }

    [CanBeNull]
    public string Comment { get; private set; }
  }
}
