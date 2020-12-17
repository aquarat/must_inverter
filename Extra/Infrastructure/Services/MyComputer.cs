// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.MyComputer
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Infrastructure.Services
{
  public static class MyComputer
  {
    [DllImport("user32")]
    private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

    [DllImport("user32")]
    private static extern void LockWorkStation();

    [DllImport("user32")]
    private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

    public static void ShutDown(int shutDonTimer)
    {
      try
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", string.Format("-s -t {0}", (object) shutDonTimer)));
      }
      catch
      {
      }
    }

    public static void Restart(int secondsLater = 0)
    {
      try
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", string.Format("-r -t {0}", (object) secondsLater)));
      }
      catch
      {
      }
    }

    public static void LogOff()
    {
      try
      {
        MyComputer.ExitWindowsEx(0U, 0U);
      }
      catch
      {
      }
    }

    public static void LockPC()
    {
      try
      {
        MyComputer.LockWorkStation();
      }
      catch
      {
      }
    }

    public static void Turnoffmonitor()
    {
      MyComputer.SetMonitorInState(MonitorState.MonitorStateOff);
    }

    private static void SetMonitorInState(MonitorState state)
    {
      MyComputer.SendMessage((int) ushort.MaxValue, 274, 61808, (int) state);
    }
  }
}
