// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.StringOperater
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Services
{
  public class StringOperater
  {
    public static readonly StringOperater Insstance = new StringOperater();

    private StringOperater()
    {
    }

    public byte[] StrToHexByte(string hexString)
    {
      hexString = hexString.Replace(" ", "");
      if (hexString.Length % 2 != 0)
        hexString += " ";
      byte[] numArray = new byte[hexString.Length / 2];
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] = Convert.ToByte(hexString.Substring(index * 2, 2), 16);
      return numArray;
    }

    public bool CRCCheck(byte[] readedBytes)
    {
      byte[] numArray1 = readedBytes;
      byte[] numArray2 = new byte[numArray1.Length - 2];
      int num1 = (int) numArray1[numArray1.Length - 2] + (int) numArray1[numArray1.Length - 1];
      for (int index = 0; index < numArray1.Length - 2; ++index)
        numArray2[index] = numArray1[index];
      byte maxValue1 = byte.MaxValue;
      byte maxValue2 = byte.MaxValue;
      byte num2 = 1;
      byte num3 = 160;
      foreach (byte num4 in numArray2)
      {
        maxValue1 ^= num4;
        for (int index = 0; index <= 7; ++index)
        {
          int num5 = (int) maxValue2;
          byte num6 = maxValue1;
          maxValue2 >>= 1;
          maxValue1 >>= 1;
          if ((num5 & 1) == 1)
            maxValue1 |= (byte) 128;
          if (((int) num6 & 1) == 1)
          {
            maxValue2 ^= num3;
            maxValue1 ^= num2;
          }
        }
      }
      byte[] numArray3 = new byte[2]{ maxValue2, maxValue1 };
      return (int) maxValue2 + (int) maxValue1 == num1;
    }

    public string GenerateCRC(string hexString)
    {
      StringBuilder stringBuilder = new StringBuilder();
      hexString = hexString.Replace(" ", "");
      if (hexString.Length % 2 != 0)
        hexString += " ";
      byte[] numArray1 = new byte[hexString.Length / 2];
      for (int index = 0; index < numArray1.Length; ++index)
        numArray1[index] = Convert.ToByte(hexString.Substring(index * 2, 2), 16);
      byte[] numArray2 = numArray1;
      byte maxValue1 = byte.MaxValue;
      byte maxValue2 = byte.MaxValue;
      foreach (byte num1 in numArray2)
      {
        maxValue1 ^= num1;
        for (int index = 0; index <= 7; ++index)
        {
          int num2 = (int) maxValue2;
          byte num3 = maxValue1;
          maxValue2 >>= 1;
          maxValue1 >>= 1;
          if ((num2 & 1) == 1)
            maxValue1 |= (byte) 128;
          if (((int) num3 & 1) == 1)
          {
            maxValue2 ^= (byte) 160;
            maxValue1 ^= (byte) 1;
          }
        }
      }
      int length = numArray2.Length + 2;
      byte[] numArray3 = new byte[length];
      numArray2.CopyTo((Array) numArray3, 0);
      numArray3[length - 1] = maxValue2;
      numArray3[length - 2] = maxValue1;
      foreach (byte num in numArray3)
        stringBuilder.Append(num.ToString("X2") + " ");
      return stringBuilder.ToString();
    }

    public byte[] GenerateCRCB(string hexString)
    {
      hexString = hexString.Replace(" ", "");
      if (hexString.Length % 2 != 0)
        hexString += " ";
      byte[] numArray1 = new byte[hexString.Length / 2];
      for (int index = 0; index < numArray1.Length; ++index)
        numArray1[index] = Convert.ToByte(hexString.Substring(index * 2, 2), 16);
      byte maxValue1 = byte.MaxValue;
      byte maxValue2 = byte.MaxValue;
      foreach (byte num1 in numArray1)
      {
        maxValue1 ^= num1;
        for (int index = 0; index <= 7; ++index)
        {
          int num2 = (int) maxValue2;
          byte num3 = maxValue1;
          maxValue2 >>= 1;
          maxValue1 >>= 1;
          if ((num2 & 1) == 1)
            maxValue1 |= (byte) 128;
          if (((int) num3 & 1) == 1)
          {
            maxValue2 ^= (byte) 160;
            maxValue1 ^= (byte) 1;
          }
        }
      }
      int length = numArray1.Length + 2;
      byte[] numArray2 = new byte[length];
      numArray1.CopyTo((Array) numArray2, 0);
      numArray2[length - 1] = maxValue2;
      numArray2[length - 2] = maxValue1;
      return numArray2;
    }

    public string[] HandleComReturned(string hexstrg)
    {
      StringBuilder stringBuilder = new StringBuilder(hexstrg);
      stringBuilder.Remove(0, 8);
      string str = stringBuilder.Remove(stringBuilder.Length - 6, 5).ToString().Trim();
      for (int startIndex = str.Length - 1; startIndex >= 0; --startIndex)
      {
        if (startIndex % 6 == 2)
          str = str.Remove(startIndex, 1);
      }
      return str.Split(' ');
    }

    public string[] OriginalBytesToDataArray(byte[] bytes, int arrLength)
    {
      string[] strArray = new string[arrLength];
      if (bytes.Length != arrLength * 2 + 5)
        throw new Exception(string.Format("[StringOperater]Error by byte arraylength,require:{0},actually{1}", (object) (arrLength * 2 + 5), (object) bytes.Length));
      int num1 = 0;
      int index = 0;
      string empty = string.Empty;
      foreach (byte num2 in bytes)
      {
        if (num1 <= 2 || num1 >= bytes.Length - 2)
        {
          ++num1;
        }
        else
        {
          if (num1 % 2 == 1)
            empty = num2.ToString("X2");
          if (num1 % 2 == 0)
          {
            string str = empty + num2.ToString("X2");
            strArray[index] = str;
            empty = string.Empty;
            ++index;
          }
          ++num1;
        }
      }
      return strArray;
    }

    public string AnalyBitMessage(string hexCode, string[] messageStorage)
    {
      StringBuilder stringBuilder = new StringBuilder();
      IEnumerable<char> chars = Convert.ToString((int) Convert.ToInt16(hexCode, 16), 2).PadLeft(16, '0').Reverse<char>();
      int index = 0;
      foreach (char ch in chars)
      {
        if (ch == '1')
          stringBuilder.Append(messageStorage[index]).Append(Environment.NewLine);
        ++index;
      }
      return stringBuilder.ToString();
    }

    public string AnalyBitMessage(string hexCode)
    {
      IEnumerable<char> chars = Convert.ToString((int) Convert.ToInt16(hexCode, 16), 2).PadLeft(16, '0').Reverse<char>();
      StringBuilder stringBuilder = new StringBuilder();
      foreach (char ch in chars)
        stringBuilder.Append(ch);
      return stringBuilder.ToString();
    }
  }
}
