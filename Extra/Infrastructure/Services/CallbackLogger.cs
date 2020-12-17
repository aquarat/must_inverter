// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.CallbackLogger
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Collections.Generic;

namespace Infrastructure.Services
{
  public class CallbackLogger
  {
    private Queue<string> savedLogs = new Queue<string>();
    private Action<string> callback;

    public Action<string> Callback
    {
      get
      {
        return this.callback;
      }
      set
      {
        this.callback = value;
      }
    }

    public void Log(string message)
    {
      if (this.Callback != null)
        this.Callback(message);
      else
        this.savedLogs.Enqueue(message);
    }
  }
}
