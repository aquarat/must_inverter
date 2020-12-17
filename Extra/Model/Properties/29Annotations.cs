// Decompiled with JetBrains decompiler
// Type: Model.Annotations.RazorInjectionAttribute
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using System;

namespace Model.Annotations
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      this.Type = type;
      this.FieldName = fieldName;
    }

    [NotNull]
    public string Type { get; private set; }

    [NotNull]
    public string FieldName { get; private set; }
  }
}
