// Decompiled with JetBrains decompiler
// Type: Rs485.Services.Rs485ComServer
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using Infrastructure.Services;
using Model;
using Rs485;
using Rs485.Services;

namespace PH1800.Extra.RS485.Services
{
  public class Rs485ComServer
  {
    private static readonly int MaxLoop = 20;
    private static readonly StringOperater Operator = StringOperater.Insstance;
    private static readonly byte[] ScanBytes = Rs485ComServer.Operator.StrToHexByte("04 03 4E 21 00 05 C2 BE");

    public string[] ScanPort()
    {
      foreach (string portName in SerialPort.GetPortNames())
      {
        using (SerialPort serialPort = new SerialPort(portName, 19200)
        {
          ReadTimeout = 1000,
          WriteTimeout = 1000,
          RtsEnable = true
        })
        {
          if (!serialPort.IsOpen)
            serialPort.Open();
          serialPort.Write(Rs485ComServer.ScanBytes, 0, Rs485ComServer.ScanBytes.Length);
          Thread.Sleep(200);
          for (int index = 0; serialPort.BytesToRead == 0 && index < Rs485ComServer.MaxLoop; ++index)
            Thread.Sleep(100);
          int bytesToRead = serialPort.BytesToRead;
          if (bytesToRead != 0)
          {
            byte[] numArray = new byte[bytesToRead];
            serialPort.Read(numArray, 0, bytesToRead);
            string[] dataArray = Rs485ComServer.Operator.OriginalBytesToDataArray(numArray, 5);
            if (!string.IsNullOrEmpty(dataArray[0]))
            {
              if (!string.IsNullOrEmpty(dataArray[4]))
                return new string[3]
                {
                  portName,
                  Convert.ToInt16(dataArray[0], 16).ToString(),
                  Convert.ToInt16(dataArray[4], 16).ToString()
                };
            }
          }
        }
      }
      return (string[]) null;
    }

    public string[] ScanPort(int[] deviceIds)
    {
      foreach (int deviceId in deviceIds)
      {
        string hexString = string.Format("{0:X2} 03 4E 21 00 05", (object) deviceId);
        byte[] crcb = Rs485ComServer.Operator.GenerateCRCB(hexString);
        foreach (string portName in SerialPort.GetPortNames())
        {
          using (SerialPort serialPort = new SerialPort(portName, 19200)
          {
            ReadTimeout = 1000,
            WriteTimeout = 1000,
            RtsEnable = true
          })
          {
            if (!serialPort.IsOpen)
              serialPort.Open();
            serialPort.Write(crcb, 0, crcb.Length);
            Thread.Sleep(200);
            for (int index = 0; serialPort.BytesToRead == 0 && index < Rs485ComServer.MaxLoop; ++index)
              Thread.Sleep(100);
            int bytesToRead = serialPort.BytesToRead;
            if (bytesToRead != 0)
            {
              byte[] numArray = new byte[bytesToRead];
              serialPort.Read(numArray, 0, bytesToRead);
              string[] dataArray = Rs485ComServer.Operator.OriginalBytesToDataArray(numArray, 5);
              if (!string.IsNullOrEmpty(dataArray[0]))
              {
                if (!string.IsNullOrEmpty(dataArray[4]))
                  return new string[3]
                  {
                    portName,
                    Convert.ToInt16(dataArray[0], 16).ToString(),
                    Convert.ToInt16(dataArray[4], 16).ToString()
                  };
              }
            }
          }
        }
      }
      return (string[]) null;
    }

    public static UnitedRs485 GetData(UnitedRs485 rs)
    {
      try
      {
        UnitedRs485 unitedRs485 = new UnitedRs485(rs.MTypy, rs.PortName);
        using (SerialPort sp = new SerialPort(unitedRs485.PortName, 19200)
        {
          ReadTimeout = 1000,
          WriteTimeout = 1000,
          RtsEnable = true
        })
        {
          for (int index = 0; index < ((Collection<Rs485ModelForParal>) unitedRs485.Rs485Models).Count; ++index)
            ((Collection<Rs485ModelForParal>) unitedRs485.Rs485Models)[index] = Rs485ComServer.GetPartData(((Collection<Rs485ModelForParal>) unitedRs485.Rs485Models)[index].ChargerId, ((Collection<Rs485ModelForParal>) unitedRs485.Rs485Models)[index].InverterId, sp);
          return unitedRs485;
        }
      }
      catch (Exception)
      {
        return (UnitedRs485) null;
      }
    }

    public static Rs485ModelForParal GetPartData(int chargerId, int inverterId, SerialPort sp) {
      Rs485ModelForParal rs485ModelForParal1 = new Rs485ModelForParal(chargerId, inverterId);
      byte[] crcb1 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 27 11 00 0A", (object) chargerId.ToString().PadLeft(2, '0')));
      byte[] crcb2 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 27 75 00 0C", (object) chargerId.ToString().PadLeft(2, '0')));
      byte[] crcb3 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 3B 61 00 15", (object) chargerId.ToString().PadLeft(2, '0')));
      byte[] crcb4 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 4E 21 00 10", (object) inverterId.ToString().PadLeft(2, '0')));
      byte[] crcb5 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 4E 85 00 2B", (object) inverterId.ToString().PadLeft(2, '0')));
      byte[] crcb6 = Rs485ComServer.Operator.GenerateCRCB(string.Format("{0} 03 62 71 00 4A", (object) inverterId.ToString().PadLeft(2, '0')));
      if (!sp.IsOpen)
        sp.Open();
      string[] partArr1 = Rs485ComServer.GetPartArr(sp, crcb1, 10, 20);
      if (partArr1 != null && partArr1.Length == 10)
      {
        string[] partArr2 = Rs485ComServer.GetPartArr(sp, crcb2, 12, 20);
        Thread.Sleep(100);
        string[] partArr3 = Rs485ComServer.GetPartArr(sp, crcb3, 21, 20);
        Thread.Sleep(100);
        string[] partArr4 = Rs485ComServer.GetPartArr(sp, crcb4, 16, 20);
        Thread.Sleep(100);
        string[] partArr5 = Rs485ComServer.GetPartArr(sp, crcb5, 43, 20);
        Thread.Sleep(100);
        string[] partArr6 = Rs485ComServer.GetPartArr(sp, crcb6, 74, 40);
        rs485ModelForParal1.MachineType = partArr1[0];
        rs485ModelForParal1.SerialNumber = partArr1[1] + partArr1[2];
        int int16_1 = (int) Convert.ToInt16(partArr1[3], 16);
        rs485ModelForParal1.HardwareVersion = string.IsNullOrEmpty(partArr1[3]) ? string.Empty : (partArr1[3] == "0" || int16_1 == 0 ? "1.00.00" : Convert.ToInt16(partArr1[3], 16).ToString().Insert(3, ".").Insert(1, "."));
        int int16_2 = (int) Convert.ToInt16(partArr1[4], 16);
        rs485ModelForParal1.SoftwareVersion = string.IsNullOrEmpty(partArr1[4]) ? string.Empty : (partArr1[4] == "0" || int16_2 == 0 ? "1.00.00" : Convert.ToInt16(partArr1[4], 16).ToString().Insert(3, ".").Insert(1, "."));
        rs485ModelForParal1.PvVoltageC = partArr1[5];
        rs485ModelForParal1.BatteryVoltageC = partArr1[6];
        rs485ModelForParal1.ChargerCurrentC = partArr1[7];
        double num;
        if (partArr2 != null && partArr2.Length == 12)
        {
          rs485ModelForParal1.ChargerWorkEnable = Convert.ToInt16(partArr2[0], 16).ToString();
          rs485ModelForParal1.AbsorbVoltage = ((double) Convert.ToInt16(partArr2[1], 16) * 0.1).ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal1.FloatVoltage = ((double) Convert.ToInt16(partArr2[2], 16) * 0.1).ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal1.AbsorptionVoltage = ((double) Convert.ToInt16(partArr2[3], 16) * 0.1).ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal1.BatteryLowVoltage = ((double) Convert.ToInt16(partArr2[4], 16) * 0.1).ToString((IFormatProvider) CultureInfo.InvariantCulture);
          Rs485ModelForParal rs485ModelForParal2 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr2[6], 16) * 0.1;
          string str1 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal2.BatteryHighVoltage = str1;
          Rs485ModelForParal rs485ModelForParal3 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr2[7], 16) * 0.1;
          string str2 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal3.MaxChargerCurrent = str2;
          Rs485ModelForParal rs485ModelForParal4 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr2[8], 16) * 0.1;
          string str3 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal4.AbsorbChargerCurrent = str3;
          rs485ModelForParal1.BatteryType = Convert.ToInt16(partArr2[9], 16).ToString();
          rs485ModelForParal1.BatteryAh = Convert.ToInt16(partArr2[10], 16).ToString();
          rs485ModelForParal1.RemoveTheAccumulatedData = Convert.ToInt16(partArr2[11], 16).ToString();
        }
        short int16_3;
        if (partArr3 != null && partArr3.Length == 21)
        {
          rs485ModelForParal1.ChargerWorkstate = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr3[0], 16), Rs485Parse.ChargerWorkstate);
          rs485ModelForParal1.MpptState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr3[1], 16), Rs485Parse.MpptState);
          rs485ModelForParal1.ChargingState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr3[2], 16), Rs485Parse.ChargingState);
          Rs485ModelForParal rs485ModelForParal2 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr3[4], 16) * 0.1;
          string str1 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal2.PvVoltage = str1;
          Rs485ModelForParal rs485ModelForParal3 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr3[5], 16) * 0.1;
          string str2 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal3.BatteryVoltage = str2;
          Rs485ModelForParal rs485ModelForParal4 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr3[6], 16) * 0.1;
          string str3 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "A";
          rs485ModelForParal4.ChargerCurrent = str3;
          rs485ModelForParal1.ChargerPower = Convert.ToInt16(partArr3[7], 16).ToString();// + " W";
          rs485ModelForParal1.RadiatorTemperature = Convert.ToInt16(partArr3[8], 16).ToString();// + " ℃";
          rs485ModelForParal1.ExternalTemperature = Convert.ToInt16(partArr3[9], 16).ToString();// + " ℃";
          rs485ModelForParal1.BatteryRelay = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr3[10], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.PvRelay = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr3[11], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.ErrorMessage = Rs485ComServer.Operator.AnalyBitMessage(partArr3[12], Rs485Parse.ChargerError);
          rs485ModelForParal1.WarningMessage = Rs485ComServer.Operator.AnalyBitMessage(partArr3[13], Rs485Parse.ChargerWarning);
          rs485ModelForParal1.BattVolGrade = Convert.ToInt16(partArr3[14], 16).ToString();// + " V";
          Rs485ModelForParal rs485ModelForParal5 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr3[15], 16) * 0.1;
          string str4 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " A";
          rs485ModelForParal5.RatedCurrent = str4;
          Rs485ModelForParal rs485ModelForParal6 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr3[16], 16) * 1000) + (double) Convert.ToInt16(partArr3[17], 16) * 0.1;
          string str5 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " KWH";
          rs485ModelForParal6.AccumulatedPower = str5;
          Rs485ModelForParal rs485ModelForParal7 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr3[18], 16);
          string str6 = int16_3.ToString().PadLeft(2, '0');
          int16_3 = Convert.ToInt16(partArr3[19], 16);
          string str7 = int16_3.ToString().PadLeft(2, '0');
          int16_3 = Convert.ToInt16(partArr3[20], 16);
          string str8 = int16_3.ToString().PadLeft(2, '0');
          string str9 = string.Format("{0}:{1}:{2}", (object) str6, (object) str7, (object) str8);
          rs485ModelForParal7.AccumulatedTime = str9;
        }
        if (partArr4 != null && partArr4.Length == 16)
        {
          int int16_4 = (int) Convert.ToInt16(partArr1[4], 16);
          int int16_5 = (int) Convert.ToInt16(partArr1[0], 16);
          string str1 = string.Empty;
          switch (int16_5)
          {
            case 1600:
              str1 = "PC1600";
              break;
            case 1800:
              str1 = int16_4 > 20000 ? "PV1800" : "PH1800";
              break;
            case 3000:
              str1 = "PH3000";
              break;
            case 3500:
              str1 = "PV3500";
              break;
          }
          rs485ModelForParal1.InverterMachineType = str1;
          rs485ModelForParal1.InverterSerialNumber = partArr4[1] + partArr4[2];
          int int16_6 = (int) Convert.ToInt16(partArr4[3], 16);
          Rs485ModelForParal rs485ModelForParal2 = rs485ModelForParal1;
          string str2;
          if (!string.IsNullOrEmpty(partArr4[3]))
          {
            if (!(partArr4[3] == "0") && int16_6 != 0)
            {
              int16_3 = Convert.ToInt16(partArr4[3], 16);
              str2 = int16_3.ToString().Insert(3, ".").Insert(1, ".");
            }
            else
              str2 = "1.00.00";
          }
          else
            str2 = string.Empty;
          rs485ModelForParal2.InverterHardwareVersion = str2;
          int int16_7 = (int) Convert.ToInt16(partArr4[4], 16);
          Rs485ModelForParal rs485ModelForParal3 = rs485ModelForParal1;
          string str3;
          if (!string.IsNullOrEmpty(partArr4[4]))
          {
            if (!(partArr4[4] == "0") && int16_7 != 0)
            {
              int16_3 = Convert.ToInt16(partArr4[4], 16);
              str3 = int16_3.ToString().Insert(3, ".").Insert(1, ".");
            }
            else
              str3 = "1.00.00";
          }
          else
            str3 = string.Empty;
          rs485ModelForParal3.InverterSoftwareVersion = str3;
          rs485ModelForParal1.InverterBatteryVoltageC = partArr4[8];
          rs485ModelForParal1.InverterVoltageC = partArr4[9];
          rs485ModelForParal1.GridVoltageC = partArr4[10];
          rs485ModelForParal1.BusVoltageC = partArr4[11];
          rs485ModelForParal1.ControlCurrentC = partArr4[12];
          rs485ModelForParal1.InverterCurrentC = partArr4[13];
          rs485ModelForParal1.GridCurrentC = partArr4[14];
          rs485ModelForParal1.LoadCurrentC = partArr4[15];
        }
        if (partArr5 != null && partArr5.Length == 43)
        {
          Rs485ModelForParal rs485ModelForParal2 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[0], 16);
          string str1 = int16_3.ToString();
          rs485ModelForParal2.InverterOffgridWorkEnable = str1;
          Rs485ModelForParal rs485ModelForParal3 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[1], 16) * 0.1;
          string str2 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal3.InverterOutputVoltageSet = str2;
          Rs485ModelForParal rs485ModelForParal4 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[2], 16);
          string str3 = int16_3.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal4.InverterOutputFrequencySet = str3;
          Rs485ModelForParal rs485ModelForParal5 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[3], 16);
          string str4 = int16_3.ToString();
          rs485ModelForParal5.InverterSearchModeEnable = str4;
          Rs485ModelForParal rs485ModelForParal6 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[7], 16);
          string str5 = int16_3.ToString();
          rs485ModelForParal6.InverterDischargerToGridEnable = str5;
          Rs485ModelForParal rs485ModelForParal7 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[8], 16);
          string str6 = int16_3.ToString();
          rs485ModelForParal7.EnergyUseMode = str6;
          Rs485ModelForParal rs485ModelForParal8 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[10], 16);
          string str7 = int16_3.ToString();
          rs485ModelForParal8.GridProtectStandard = str7;
          Rs485ModelForParal rs485ModelForParal9 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[11], 16);
          string str8 = int16_3.ToString();
          rs485ModelForParal9.SolarUseAim = str8;
          Rs485ModelForParal rs485ModelForParal10 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[12], 16) * 0.1;
          string str9 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal10.InverterMaxDischargerCurrent = str9;
          Rs485ModelForParal rs485ModelForParal11 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[17], 16) * 0.1;
          string str10 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal11.NormalVoltagePoint = str10;
          Rs485ModelForParal rs485ModelForParal12 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[18], 16) * 0.1;
          string str11 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal12.StartSellVoltagePoint = str11;
          Rs485ModelForParal rs485ModelForParal13 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[24], 16) * 0.1;
          string str12 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal13.GridMaxChargerCurrentSet = str12;
          Rs485ModelForParal rs485ModelForParal14 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[26], 16) * 0.1;
          string str13 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal14.InverterBatteryLowVoltage = str13;
          Rs485ModelForParal rs485ModelForParal15 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[27], 16) * 0.1;
          string str14 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal15.InverterBatteryHighVoltage = str14;
          Rs485ModelForParal rs485ModelForParal16 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr5[31], 16) * 0.1;
          string str15 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          rs485ModelForParal16.MaxCombineChargerCurrent = str15;
          rs485ModelForParal1.SystemSetting = Rs485ComServer.Operator.AnalyBitMessage(partArr5[41]);
          Rs485ModelForParal rs485ModelForParal17 = rs485ModelForParal1;
          int16_3 = Convert.ToInt16(partArr5[42], 16);
          string str16 = int16_3.ToString();
          rs485ModelForParal17.ChargerSourcePriority = str16;
        }
        if (partArr6 != null && partArr6.Length == 74)
        {
          rs485ModelForParal1.WorkState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[0], 16), Rs485Parse.WorkState);
          rs485ModelForParal1.AcVoltageGrade = Convert.ToInt16(partArr6[1], 16).ToString();// + " V";
          int int16_4 = (int) Convert.ToInt16(partArr6[2], 16);
          string inverterMachineType = rs485ModelForParal1.InverterMachineType;
          //string str1 = inverterMachineType == "PV1800" || inverterMachineType == "PH1800" ? int16_4.ToString() + " VA" : (inverterMachineType == "PH3000" ? int16_4.ToString() + " W" : int16_4.ToString() + "W");
          string str1 = inverterMachineType == "PV1800" || inverterMachineType == "PH1800" ? int16_4.ToString() : (inverterMachineType == "PH3000" ? int16_4.ToString() : int16_4.ToString());
          rs485ModelForParal1.RatedPower = str1;
          Rs485ModelForParal rs485ModelForParal2 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[4], 16) * 0.1;
          string str2 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal2.InverterBatteryVoltage = str2;
          Rs485ModelForParal rs485ModelForParal3 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[5], 16) * 0.1;
          string str3 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal3.InverterVoltage = str3;
          Rs485ModelForParal rs485ModelForParal4 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[6], 16) * 0.1;
          string str4 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal4.GridVoltage = str4;
          Rs485ModelForParal rs485ModelForParal5 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[7], 16) * 0.1;
          string str5 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " V";
          rs485ModelForParal5.BusVoltage = str5;
          Rs485ModelForParal rs485ModelForParal6 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[8], 16) * 0.1;
          string str6 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " A";
          rs485ModelForParal6.ControlCurrent = str6;
          Rs485ModelForParal rs485ModelForParal7 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[9], 16) * 0.1;
          string str7 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " A";
          rs485ModelForParal7.InverterCurrent = str7;
          Rs485ModelForParal rs485ModelForParal8 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[10], 16) * 0.1;
          string str8 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " A";
          rs485ModelForParal8.GridCurrent = str8;
          Rs485ModelForParal rs485ModelForParal9 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[11], 16) * 0.1;
          string str9 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " A";
          rs485ModelForParal9.LoadCurrent = str9;
          rs485ModelForParal1.PInverter = Convert.ToInt16(partArr6[12], 16).ToString();// + " W";
          rs485ModelForParal1.PGrid = Convert.ToInt16(partArr6[13], 16).ToString();// + " W";
          rs485ModelForParal1.PLoad = Convert.ToInt16(partArr6[14], 16).ToString();// + " W";
          rs485ModelForParal1.LoadPercent = Convert.ToInt16(partArr6[15], 16).ToString();// + " %";
          rs485ModelForParal1.SInverter = Convert.ToInt16(partArr6[16], 16).ToString();// + " VA";
          rs485ModelForParal1.SGrid = Convert.ToInt16(partArr6[17], 16).ToString();// + " VA";
          rs485ModelForParal1.Sload = Convert.ToInt16(partArr6[18], 16).ToString();// + " VA";
          rs485ModelForParal1.Qinverter = Convert.ToInt16(partArr6[20], 16).ToString();// + " var";
          rs485ModelForParal1.Qgrid = Convert.ToInt16(partArr6[21], 16).ToString();// + " var";
          rs485ModelForParal1.Qload = Convert.ToInt16(partArr6[22], 16).ToString();// + " var";
          Rs485ModelForParal rs485ModelForParal10 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[24], 16) * 0.01;
          string str10 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " Hz";
          rs485ModelForParal10.InverterFrequency = str10;
          Rs485ModelForParal rs485ModelForParal11 = rs485ModelForParal1;
          num = (double) Convert.ToInt16(partArr6[25], 16) * 0.01;
          string str11 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " Hz";
          rs485ModelForParal11.GridFrequency = str11;
          rs485ModelForParal1.InverterMaxNumber = partArr6[28];
          rs485ModelForParal1.CombineType = partArr6[29];
          rs485ModelForParal1.InverterNumber = partArr6[30];
          rs485ModelForParal1.AcRadiatorTemperature = Convert.ToInt16(partArr6[32], 16).ToString();// + " ℃";
          rs485ModelForParal1.TransformerTemperature = Convert.ToInt16(partArr6[33], 16).ToString();// + " ℃";
          rs485ModelForParal1.DcRadiatorTemperature = Convert.ToInt16(partArr6[34], 16).ToString();// + " ℃";
          rs485ModelForParal1.InverterRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[36], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.GridRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[37], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.LoadRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[38], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.N_LineRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[39], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.DCRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[40], 16), Rs485Parse.ConnectStates);
          rs485ModelForParal1.EarthRelayState = Rs485ComServer.GetValue((int) Convert.ToInt16(partArr6[41], 16), Rs485Parse.ConnectStates);
          Rs485ModelForParal rs485ModelForParal12 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[44], 16) * 1000) + (double) Convert.ToInt16(partArr6[45], 16) * 0.1;
          string str12 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " KWH";
          rs485ModelForParal12.AccumulatedChargerPower = str12;
          Rs485ModelForParal rs485ModelForParal13 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[46], 16) * 1000) + (double) Convert.ToInt16(partArr6[47], 16) * 0.1;
          string str13 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + " KWH";
          rs485ModelForParal13.AccumulatedDischargerPower = str13;
          Rs485ModelForParal rs485ModelForParal14 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[48], 16) * 1000) + (double) Convert.ToInt16(partArr6[49], 16) * 0.1;
          string str14 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal14.AccumulatedBuyPower = str14;
          Rs485ModelForParal rs485ModelForParal15 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[50], 16) * 1000) + (double) Convert.ToInt16(partArr6[51], 16) * 0.1;
          string str15 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal15.AccumulatedSellPower = str15;
          Rs485ModelForParal rs485ModelForParal16 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[52], 16) * 1000) + (double) Convert.ToInt16(partArr6[53], 16) * 0.1;
          string str16 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal16.AccumulatedLoadPower = str16;
          Rs485ModelForParal rs485ModelForParal17 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[54], 16) * 1000) + (double) Convert.ToInt16(partArr6[55], 16) * 0.1;
          string str17 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal17.AccumulatedSelf_usePower = str17;
          Rs485ModelForParal rs485ModelForParal18 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[56], 16) * 1000) + (double) Convert.ToInt16(partArr6[57], 16) * 0.1;
          string str18 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal18.AccumulatedPV_sellPower = str18;
          Rs485ModelForParal rs485ModelForParal19 = rs485ModelForParal1;
          num = (double) ((int) Convert.ToInt16(partArr6[58], 16) * 1000) + (double) Convert.ToInt16(partArr6[59], 16) * 0.1;
          string str19 = num.ToString((IFormatProvider) CultureInfo.InvariantCulture);// + "KWH";
          rs485ModelForParal19.AccumulatedGrid_chargerPower = str19;
          rs485ModelForParal1.InverterErrorMessage = Rs485ComServer.Operator.AnalyBitMessage(partArr6[60], Rs485Parse.InverterError1) + Rs485ComServer.Operator.AnalyBitMessage(partArr6[61], Rs485Parse.InverterError2);
          rs485ModelForParal1.InverterWarningMessage = Rs485ComServer.Operator.AnalyBitMessage(partArr6[64], Rs485Parse.InverterWarning);
          rs485ModelForParal1.BattPower = Convert.ToInt16(partArr6[72], 16).ToString();// + "W";
          rs485ModelForParal1.BattCurrent = Convert.ToInt16(partArr6[73], 16).ToString();// + "A";
        }
      }
      return rs485ModelForParal1;
    }

    private static string[] GetPartArr(
      SerialPort sp,
      byte[] bytes,
      int dataLength,
      int maxloopCount = 20)
    {
      sp.Write(bytes, 0, bytes.Length);
      int num = 0;
      while (sp.BytesToRead != dataLength * 2 + 5)
      {
        if (num >= maxloopCount)
          return (string[]) null;
        Thread.Sleep(100);
        ++num;
      }
      byte[] numArray = new byte[sp.BytesToRead];
      sp.Read(numArray, 0, numArray.Length);
      return Rs485ComServer.Operator.OriginalBytesToDataArray(numArray, dataLength);
    }

    private static string GetValue(int readValue, string[] protocolValues)
    {
      return readValue <= protocolValues.Length - 1 && readValue >= 0 ? protocolValues[readValue] : string.Format("Results are out of range[0-{0}].{1}", (object) (protocolValues.Length - 1), (object) readValue);
    }

    public  string WriteCommand(Queue<string> commands, string portName)
    {
      try
      {
        StringBuilder stringBuilder1 = new StringBuilder();
        using (SerialPort serialPort = new SerialPort(portName, 19200)
        {
          ReadTimeout = 1000,
          WriteTimeout = 1000,
          RtsEnable = true
        })
        {
          while (commands.Any<string>())
          {
            string hexString = commands.Dequeue();
            byte[] hexByte = Rs485ComServer.Operator.StrToHexByte(hexString);
            if (!serialPort.IsOpen)
              serialPort.Open();
            serialPort.Write(hexByte, 0, hexByte.Length);
            Thread.Sleep(200);
            for (int index = 0; serialPort.BytesToRead == 0 && index < 8; ++index)
              Thread.Sleep(100);
            if (serialPort.BytesToRead != 0)
            {
              byte[] numArray = new byte[serialPort.BytesToRead];
              StringBuilder stringBuilder2 = new StringBuilder();
              foreach (byte num in numArray)
                stringBuilder2.Append(num.ToString("X2") + " ");
              stringBuilder1.Append(string.Format("command:[{0}] has been written,returns:{1}", (object) hexString, (object) stringBuilder2)).Append(Environment.NewLine);
            }
            else
              stringBuilder1.Append(string.Format("command:[{0}] fail", (object) hexString)).Append(Environment.NewLine);
          }
        }
        return stringBuilder1.ToString();
      }
      catch (Exception ex)
      {
        return string.Format("{0}:{1}", (object) ex.Source, (object) ex.Message);
      }
    }

    public  string WriteCommand(string command, string portName)
    {
      try
      {
        StringBuilder stringBuilder1 = new StringBuilder();
        if (string.IsNullOrEmpty(command))
          return string.Empty;
        using (SerialPort serialPort = new SerialPort(portName, 19200)
        {
          ReadTimeout = 1000,
          WriteTimeout = 1000,
          RtsEnable = true
        })
        {
          byte[] hexByte = Rs485ComServer.Operator.StrToHexByte(command);
          if (!serialPort.IsOpen)
            serialPort.Open();
          serialPort.Write(hexByte, 0, hexByte.Length);
          Thread.Sleep(200);
          for (int index = 0; serialPort.BytesToRead == 0 && index < 8; ++index)
            Thread.Sleep(100);
          if (serialPort.BytesToRead != 0)
          {
            int bytesToRead = serialPort.BytesToRead;
            byte[] buffer = new byte[bytesToRead];
            serialPort.Read(buffer, 0, bytesToRead);
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (byte num in buffer)
              stringBuilder2.Append(num.ToString("X2") + " ");
            stringBuilder1.Append(string.Format("command:[{0}] has been written,returns:{1}", (object) command, (object) stringBuilder2)).Append(Environment.NewLine);
          }
          else
            stringBuilder1.Append(string.Format("command:[{0}] fail", (object) command)).Append(Environment.NewLine);
        }
        return stringBuilder1.ToString();
      }
      catch (Exception ex)
      {
        return string.Format("{0}:{1}", (object) ex.Source, (object) ex.Message);
      }
    }
  }
}
