// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.Ep3000Model
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Infrastructure.Models;
using Infrastructure.Services;

namespace PH1800.Extra.Infrastructure.Models
{
  public class Ep3000Model
  {
    private static List<Ep3000SocCompatable> _compatables = new List<Ep3000SocCompatable>();
    private string _upsStatus;

    public Ep3000Model()
    {
      if (Ep3000Model._compatables.Any<Ep3000SocCompatable>())
        return;
      Ep3000Model._compatables = Ep3000SocCompatableServer.Instance.Retrieve();
    }

    public void AnalyzeMode(string batType, int voltType)
    {
      this.BatTypeTran(batType);
      if (this.UpsStatus.Length != 8)
        return;
      this.GetWorkMode(this.UpsStatus, voltType, batType);
    }

    public long Id { get; set; }

    public string InputVoltage { get; set; }

    public string InputFaultVoltage { get; set; }

    public string InputFrequency { get; set; }

    public string OutputVoltage { get; set; }

    public string OutputCurrent { get; set; }

    public string LoadFrequency { get; set; }

    public string BatteryVoltage { get; set; }

    public double ChargeCurrent { get; set; }

    public double BattSoc { get; set; }

    public string Temperature { get; set; }

    public string UpsStatus
    {
      get
      {
        return this._upsStatus;
      }
      set
      {
        this._upsStatus = value;
        if (value.Length != 8)
          return;
        this.Status = this.ConvertStatus(value);
      }
    }

    public string Abnormity { get; set; }

    public DateTime RecordTime { get; set; }

    [NotMapped]
    public WorkingMode WorkingMode { get; set; }

    [NotMapped]
    public List<global::Infrastructure.Models.EarlyWarning> EarlyWarning { get; set; }

    [NotMapped]
    public Ep3000Status Status { get; set; }

    private Ep3000Status ConvertStatus(string upsStatus)
    {
      int upsStatu1 = (int) upsStatus[7];
      int upsStatu2 = (int) upsStatus[6];
      int upsStatu3 = (int) upsStatus[5];
      int upsStatu4 = (int) upsStatus[4];
      int upsStatu5 = (int) upsStatus[3];
      int upsStatu6 = (int) upsStatus[2];
      int upsStatu7 = (int) upsStatus[1];
      int upsStatu8 = (int) upsStatus[0];
      return new Ep3000Status()
      {
        UtilityStatus = upsStatus[0] == '1' ? "Utility Fail (Immediate)" : string.Empty,
        BatteryVoltageStatus = upsStatus[1] == '1' ? "Battery Low" : string.Empty,
        AvrStatus = upsStatus[2] == '1' ? "AVR" : "NORMAL",
        UpsStatus = upsStatus[3] == '1' ? " UPS Failed" : string.Empty,
        UpsType = upsStatus[4] == '1' ? "Line-Interactive" : "On_line",
        TestStatus = upsStatus[5] == '1' ? "Test in Progress" : string.Empty,
        ShutDownStatus = upsStatus[6] == '1' ? "Shutdown Active" : string.Empty,
        BeeperStatus = upsStatus[7] == '1' ? "Beeper On" : string.Empty
      };
    }

    private void BatTypeTran(string batType)
    {
      // // ISSUE: object of a compiler-generated type is created
      // // ISSUE: variable of a compiler-generated type
      // Ep3000Model.DisplayClass720 cDisplayClass720 = new Ep3000Model.DisplayClass720();
      // // ISSUE: reference to a compiler-generated field
      // if (!double.TryParse(this.BatteryVoltage, out cDisplayClass720.batVoltage))
      //   return;
      // int num;
      // if (!(batType == "12V"))
      // {
      //   if (!(batType == "24V"))
      //   {
      //     if (!(batType == "48V"))
      //       return;
      //     // ISSUE: method pointer
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: method pointer
      //     List<int> list = ((IEnumerable<int>) Enumerable.Select<Ep3000SocCompatable, int>(Enumerable.Where<Ep3000SocCompatable>((IEnumerable<M0>) Ep3000Model._compatables, (Func<M0, bool>) new Func<Ep3000SocCompatable, bool>((object) cDisplayClass720, __methodptr(\u003CBatTypeTran\u003Eb__4))), (Func<M0, M1>) (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_5 ?? (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_5 = new Func<Ep3000SocCompatable, int>((object) Ep3000Model.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CBatTypeTran\u003Eb__72_5)))))).ToList<int>();
      //     num = list.Any<int>() ? list.Min() : 100;
      //   }
      //   else
      //   {
      //     // ISSUE: method pointer
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: reference to a compiler-generated field
      //     // ISSUE: method pointer
      //     List<int> list = ((IEnumerable<int>) Enumerable.Select<Ep3000SocCompatable, int>(Enumerable.Where<Ep3000SocCompatable>((IEnumerable<M0>) Ep3000Model._compatables, (Func<M0, bool>) new Func<Ep3000SocCompatable, bool>((object) cDisplayClass720, __methodptr(\u003CBatTypeTran\u003Eb__2))), (Func<M0, M1>) (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_3 ?? (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_3 = new Func<Ep3000SocCompatable, int>((object) Ep3000Model.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CBatTypeTran\u003Eb__72_3)))))).ToList<int>();
      //     num = list.Any<int>() ? list.Min() : 100;
      //   }
      // }
      // else
      // {
      //   // ISSUE: method pointer
      //   // ISSUE: reference to a compiler-generated field
      //   // ISSUE: reference to a compiler-generated field
      //   // ISSUE: reference to a compiler-generated field
      //   // ISSUE: method pointer
      //   List<int> list = ((IEnumerable<int>) Enumerable.Select<Ep3000SocCompatable, int>(Enumerable.Where<Ep3000SocCompatable>((IEnumerable<M0>) Ep3000Model._compatables, (Func<M0, bool>) new Func<Ep3000SocCompatable, bool>((object) cDisplayClass720, __methodptr(\u003CBatTypeTran\u003Eb__0))), (Func<M0, M1>) (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_1 ?? (Ep3000Model.\u003C\u003Ec.\u003C\u003E9__72_1 = new Func<Ep3000SocCompatable, int>((object) Ep3000Model.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CBatTypeTran\u003Eb__72_1)))))).ToList<int>();
      //   num = list.Any<int>() ? list.Min() : 100;
      // }
      // this.BattSoc = (double) num;
    }

    private void GetWorkMode(string upsStatus, int voltType, string batyType)
    {
      WorkingMode workingMode = WorkingMode.Common;
      this.WorkingMode = workingMode;
      string s1 = upsStatus[0].ToString();
      string s2 = upsStatus[6].ToString();
      char upsStatu = upsStatus[2];
      double result1;
      double result2;
      int result3;
      int result4;
      if (!double.TryParse(this.InputVoltage, out result1) || !double.TryParse(this.InputFrequency, out result2) || (!int.TryParse(s2, out result3) || !int.TryParse(s1, out result4)))
        return;
      int num;
      switch (upsStatu)
      {
        case '\x001E':
          num = 0;
          break;
        case '\x001F':
          num = 1;
          break;
        case '2':
          num = 2;
          break;
        default:
          num = 0;
          break;
      }
      double result5;
      if (!double.TryParse(this.OutputVoltage, out result5))
        return;
      if (result1 < 10.0 || result2 > 80.0 || result2 < 40.0)
        this.InputFrequency = "0";
      if (!this.Abnormity.Contains("Normal"))
        workingMode = WorkingMode.Fail;
      else if (result1 < 50.0 && result5 >= 50.0)
      {
        workingMode = WorkingMode.InvertOnly;
        this.ChargeCurrent = 0.0;
      }
      else if (result1 <= 73.0 && result3 == 0 && voltType == 120 || result1 >= 140.0 && result3 == 0 && voltType == 120 || (result1 <= 90.0 && result3 == 0 && voltType == 230 || result1 >= 272.0 && result3 == 0 && voltType == 230) || (result2 > 80.0 || result2 < 40.0) && result3 == 0)
      {
        workingMode = WorkingMode.GridFailAndInvert;
        this.ChargeCurrent = 0.0;
      }
      else if (result3 == 1 && result1 <= 80.0)
        workingMode = WorkingMode.GridAndInvertFail;
      else if (result1 >= 130.0 && voltType == 120 || result4 == 0 || result1 >= 260.0 && voltType == 230)
      {
        switch (num)
        {
          case 0:
            workingMode = WorkingMode.BatteryPriority;
            break;
          case 1:
            workingMode = WorkingMode.Bypass;
            this.LoadFrequency = this.InputFrequency;
            break;
          case 2:
            workingMode = WorkingMode.InvertOnly;
            break;
        }
      }
      else
      {
        workingMode = WorkingMode.GridFailAndInvert;
        this.ChargeCurrent = 0.0;
      }
      this.WorkingMode = workingMode;
      List<global::Infrastructure.Models.EarlyWarning> source = new List<global::Infrastructure.Models.EarlyWarning>();
      double result6;
      if (double.TryParse(this.BatteryVoltage, out result6))
      {
        if (!(batyType == "12V"))
        {
          if (!(batyType == "24V"))
          {
            if (batyType == "48V")
            {
              if (result6 < 40.0)
                source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_low);
              if (result6 >= 64.0)
                source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_high);
            }
          }
          else
          {
            if (result6 < 20.0)
              source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_low);
            if (result6 >= 32.0)
              source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_high);
          }
        }
        else
        {
          if (result6 < 10.0)
            source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_low);
          if (result6 >= 16.0)
            source.Add(global::Infrastructure.Models.EarlyWarning.Battery_too_high);
        }
      }
      double result7;
      if (double.TryParse(this.Temperature, out result7) && result7 > 95.0)
        source.Add(global::Infrastructure.Models.EarlyWarning.Invert_temp_high);
      double result8;
      if (double.TryParse(this.OutputCurrent, out result8) && result8 > 110.0)
        source.Add(global::Infrastructure.Models.EarlyWarning.Over_load);
      if (!this.Abnormity.Contains("Normal") || !source.Any<global::Infrastructure.Models.EarlyWarning>())
        return;
      this.EarlyWarning = source;
    }
  }
}
