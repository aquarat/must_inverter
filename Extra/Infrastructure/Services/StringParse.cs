// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.StringParse
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Infrastructure.Services
{
  public class StringParse
  {
    public static double GetNumFromString(string stringWithNum)
    {
      string pattern = "[+-]?\\d+[\\.]?\\d*";
      double result;
      double.TryParse(Regex.Match(stringWithNum, pattern).Value, out result);
      return result;
    }

    public static (double dNo, int iNo, string dNoStr, string iNoStr, bool isConverted) GetNum(
      string stringWithNum,
      int coef = 1)
    {
      string pattern = "[+-]?\\d+[\\.]?\\d*";
      if (stringWithNum == null)
        return (0.0, 0, (string) null, (string) null, false);
      double result;
      double.TryParse(Regex.Match(stringWithNum, pattern).Value, out result);
      int num = (int) result;
      return (result * (double) coef, num * coef, (result * (double) coef).ToString((IFormatProvider) CultureInfo.InvariantCulture), (num * coef).ToString(), true);
    }
  }
}
