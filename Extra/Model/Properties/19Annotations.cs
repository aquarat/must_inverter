// Decompiled with JetBrains decompiler
// Type: Model.Annotations.AspMvcAreaAttribute
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;

namespace Model.Annotations
{
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMvcAreaAttribute : Attribute
  {
    public AspMvcAreaAttribute()
    {
    }

    public AspMvcAreaAttribute([NotNull] string anonymousProperty)
    {
      this.AnonymousProperty = anonymousProperty;
    }

    [CanBeNull]
    public string AnonymousProperty { get; private set; }
  }
}
