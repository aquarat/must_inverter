// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.AppParamsServer
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using Infrastructure.Models;
using System;
using System.Linq;
using System.Reflection;
using PH1800.Extra.Infrastructure.Models;

namespace Infrastructure.Services
{
  public static class AppParamsServer
  {
    public static AppParam DefaultParam;

    public static void IniAppParams()
    {
      using (PMEntity pmEntity = new PMEntity())
      {
        pmEntity.Params.Add(new AppParam()
        {
          AutoRun = true,
          AutoSensePort = true,
          DefaultModule = "Welcome",
          Ep3000DefaultBatType = "24V",
          AutoSaveInterval = 5
        });
        pmEntity.SaveChanges();
      }
    }

    public static AppParam Retrieve()
    {
      using (PMEntity pmEntity = new PMEntity())
        return pmEntity.Params.FirstOrDefault<AppParam>();
    }

    public static void Update(AppParam param)
    {
      using (PMEntity pmEntity = new PMEntity())
      {
        AppParam appParam = pmEntity.Params.FirstOrDefault<AppParam>();
        if (appParam == null)
          return;
        foreach (PropertyInfo property in param.GetType().GetProperties())
        {
          if (!string.Equals(property.Name, "Id", StringComparison.OrdinalIgnoreCase))
            property.SetValue((object) appParam, property.GetValue((object) param, (object[]) null), (object[]) null);
        }
        pmEntity.SaveChanges();
      }
    }
  }
}
