// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.DataFieldReader
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.IO;
using System.Xml;

namespace Infrastructure.Services
{
  public static class DataFieldReader
  {
    private static readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "DataField.xml");
    private static readonly XmlDocument doc = new XmlDocument();

    static DataFieldReader()
    {
      DataFieldReader.doc.Load(DataFieldReader.path);
    }

    public static double GetXmlData(string protocolName, FieldsScop minOrMax, string nodeName)
    {
      double result;
      if (DataFieldReader.doc.SelectSingleNode(string.Format("root/{0}/{1}", (object) protocolName, (object) nodeName)) is XmlElement xmlElement && double.TryParse(xmlElement.GetAttribute(minOrMax.ToString()), out result))
        return result;
      throw new Exception("Get xml data has failed");
    }
  }
}
