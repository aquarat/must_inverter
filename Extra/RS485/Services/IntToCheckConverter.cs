// Decompiled with JetBrains decompiler
// Type: Rs485.Services.IntToCheckConverter
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

using System;
using System.Globalization;

namespace Rs485.Services
{
  public class IntToCheckConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      int result;
      return int.TryParse(value?.ToString(), out result) ? (object) ((uint) result > 0U) : (object) false;
    }

    public object ConvertBack(
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      return value != null ? (object) ((bool) value ? 1 : 0) : (object) 0;
    }
  }
}
