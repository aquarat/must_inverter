// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.GlobalServer
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.Reflection;

namespace Infrastructure.Services
{
  public class GlobalServer
  {
    public string GetAssemblyName()
    {
      return Assembly.GetCallingAssembly().GetName().Name;
    }
  }
}
