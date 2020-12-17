// Decompiled with JetBrains decompiler
// Type: Rs485.Services.Rs485DataAnalysis
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

using Infrastructure.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Rs485.Services
{
  public static class Rs485DataAnalysis
  {
    public static DeviceStates AnalysisData(Rs485ModelForParal rs485ModelForParal)
    {
      string[] strArray1 = new string[4];
      States[] partStates = new States[5];
      int num1 = 0;
      int num2 = ((IEnumerable<string>) Rs485Parse.WorkState).ToList<string>().IndexOf(rs485ModelForParal.WorkState);
      Rs485Parse.CurOrited curOrited;
      switch (num2)
      {
        case 2:
        case 3:
        case 4:
        case 6:
          string[] strArray2 = strArray1;
          curOrited = Rs485Parse.CurOrited.ELtoR;
          string str1 = curOrited.ToString();
          strArray2[2] = str1;
          break;
      }
      (double dNo, int iNo, string dNoStr, string iNoStr, bool isConverted) num3 = StringParse.GetNum(rs485ModelForParal.PGrid, 1);
      if (num3.isConverted)
      {
        num1 = num3.iNo;
        double result1;
        int num4 = double.TryParse(StringParse.GetNumFromString(rs485ModelForParal.RatedPower).ToString((IFormatProvider) CultureInfo.InvariantCulture), out result1) ? 1 : 0;
        double result2;
        bool flag = double.TryParse(StringParse.GetNumFromString(rs485ModelForParal.InverterSoftwareVersion.Replace(".", "")).ToString((IFormatProvider) CultureInfo.InvariantCulture), out result2);
        int num5 = (int) result1;
        int num6 = (int) result2;
        int num7 = flag ? 1 : 0;
        if ((num4 & num7) != 0 && num6 > 20000 && (num5 == 20000 || num5 == 3000) && (num2 == 3 || num2 == 4 || num2 == 6))
        {
          string[] strArray3 = strArray1;
          curOrited = Rs485Parse.CurOrited.NTtoB;
          string str2 = curOrited.ToString();
          strArray3[1] = str2;
        }
        else if (num2 == 6)
        {
          string[] strArray3 = strArray1;
          curOrited = Rs485Parse.CurOrited.NTtoB;
          string str2 = curOrited.ToString();
          strArray3[1] = str2;
        }
        else
        {
          if (num1 > 0)
          {
            string[] strArray3 = strArray1;
            curOrited = Rs485Parse.CurOrited.NBtoT;
            string str2 = curOrited.ToString();
            strArray3[1] = str2;
          }
          if (num1 < 0)
          {
            string[] strArray3 = strArray1;
            curOrited = Rs485Parse.CurOrited.NTtoB;
            string str2 = curOrited.ToString();
            strArray3[1] = str2;
          }
        }
      }
      double result;
      if (double.TryParse(StringParse.GetNumFromString(rs485ModelForParal.BattCurrent).ToString((IFormatProvider) CultureInfo.InvariantCulture), out result))
      {
        if (num2 == 6)
        {
          string[] strArray3 = strArray1;
          curOrited = Rs485Parse.CurOrited.SBtoT;
          string str2 = curOrited.ToString();
          strArray3[3] = str2;
        }
        else
        {
          if (result > 0.0)
          {
            string[] strArray3 = strArray1;
            curOrited = Rs485Parse.CurOrited.SBtoT;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
          if (result < 0.0)
          {
            string[] strArray3 = strArray1;
            curOrited = Rs485Parse.CurOrited.STtoB;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
          if (num1 == 0 && Math.Abs(result) < 0.1)
          {
            string[] strArray3 = strArray1;
            curOrited = Rs485Parse.CurOrited.SBtoT;
            string str2 = curOrited.ToString();
            strArray3[3] = str2;
          }
        }
      }
      if (((IEnumerable<string>) Rs485Parse.ChargerWorkstate).ToList<string>().IndexOf(rs485ModelForParal.ChargerWorkstate) == 2)
      {
        string[] strArray3 = strArray1;
        curOrited = Rs485Parse.CurOrited.WLtoR;
        string str2 = curOrited.ToString();
        strArray3[0] = str2;
      }
      double? soc = new double?(100.0);
      string[] curOrient = strArray1;
      return new DeviceStates(partStates, soc, curOrient);
    }
  }
}
