// Decompiled with JetBrains decompiler
// Type: Infrastructure.Base.ComServiceBase
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using Infrastructure.Services;
using System;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace Infrastructure.Base
{
  public abstract class ComServiceBase
  {
    public string[] GetPartArr(
      SerialPort sp,
      int xAddress,
      int deviceId,
      int length,
      int maxLoopCount = 20)
    {
      string hexString = deviceId.ToString("X").PadLeft(2, '0') + "03" + xAddress.ToString("X").PadLeft(4, '0') + length.ToString("X").PadLeft(4, '0');
      byte[] crcb = StringOperater.Insstance.GenerateCRCB(hexString);
      if (!sp.IsOpen)
        sp.Open();
      sp.Write(crcb, 0, crcb.Length);
      Thread.Sleep(200);
      int num = 0;
      while (sp.BytesToRead != length * 2 + 5)
      {
        if (num >= maxLoopCount)
          return (string[]) null;
        Thread.Sleep(100);
        ++num;
      }
      byte[] numArray = new byte[sp.BytesToRead];
      sp.Read(numArray, 0, numArray.Length);
      return StringOperater.Insstance.OriginalBytesToDataArray(numArray, length);
    }

    public string WriteCommand(string portName, int spBaudRate, string command, int sleepTimes = 200)
    {
      try
      {
        if (string.IsNullOrEmpty(portName))
          return string.Format("Port {0} is disabled", (object) portName);
        if (string.IsNullOrEmpty(command))
          return "command is null";
        using (SerialPort serialPort = new SerialPort(portName, spBaudRate)
        {
          RtsEnable = true
        })
        {
          if (!serialPort.IsOpen)
            serialPort.Open();
          byte[] hexByte = StringOperater.Insstance.StrToHexByte(command);
          serialPort.Write(hexByte, 0, hexByte.Length);
          Thread.Sleep(sleepTimes);
          if (serialPort.BytesToRead == 0)
            return "write command time out";
          int bytesToRead = serialPort.BytesToRead;
          byte[] buffer = new byte[bytesToRead];
          serialPort.Read(buffer, 0, bytesToRead);
          StringBuilder stringBuilder = new StringBuilder();
          foreach (byte num in buffer)
            stringBuilder.Append(num.ToString("X2"));
          return stringBuilder.ToString();
        }
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }

    public string WriteCommand(SerialPort sp, int xAddress, int deviceID, string[] hexStringValue)
    {
      throw new NotImplementedException();
    }
  }
}
