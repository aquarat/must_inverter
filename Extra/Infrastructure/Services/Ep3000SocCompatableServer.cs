// Decompiled with JetBrains decompiler
// Type: Infrastructure.Services.Ep3000SocCompatableServer
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;
using PH1800.Extra.Infrastructure.Models;

namespace Infrastructure.Services
{
  public class Ep3000SocCompatableServer
  {
    public static readonly Ep3000SocCompatableServer Instance = new Ep3000SocCompatableServer();

    private Ep3000SocCompatableServer()
    {
    }

    public static void IniEp3000SocCompatable()
    {
      using (PMEntity pmEntity = new PMEntity())
      {
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 0,
          Type12V = 9.8,
          Type24V = 19.6,
          Type48V = 39.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 10,
          Type12V = 9.9,
          Type24V = 19.8,
          Type48V = 39.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 11,
          Type12V = 9.95,
          Type24V = 19.9,
          Type48V = 39.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 12,
          Type12V = 10.0,
          Type24V = 20.0,
          Type48V = 40.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 13,
          Type12V = 10.1,
          Type24V = 20.2,
          Type48V = 40.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 14,
          Type12V = 10.15,
          Type24V = 20.3,
          Type48V = 40.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 15,
          Type12V = 10.2,
          Type24V = 20.4,
          Type48V = 40.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 16,
          Type12V = 10.3,
          Type24V = 20.6,
          Type48V = 41.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 17,
          Type12V = 10.35,
          Type24V = 20.7,
          Type48V = 41.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 18,
          Type12V = 10.4,
          Type24V = 20.8,
          Type48V = 41.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 19,
          Type12V = 10.5,
          Type24V = 21.0,
          Type48V = 42.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 20,
          Type12V = 10.55,
          Type24V = 21.1,
          Type48V = 42.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 21,
          Type12V = 10.6,
          Type24V = 21.2,
          Type48V = 42.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 22,
          Type12V = 10.7,
          Type24V = 21.4,
          Type48V = 42.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 23,
          Type12V = 10.75,
          Type24V = 21.5,
          Type48V = 43.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 24,
          Type12V = 10.8,
          Type24V = 21.6,
          Type48V = 43.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 25,
          Type12V = 10.82,
          Type24V = 21.64,
          Type48V = 43.28
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 26,
          Type12V = 10.84,
          Type24V = 21.68,
          Type48V = 43.36
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 27,
          Type12V = 10.86,
          Type24V = 21.72,
          Type48V = 43.44
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 28,
          Type12V = 10.88,
          Type24V = 21.76,
          Type48V = 43.52
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 29,
          Type12V = 10.9,
          Type24V = 21.8,
          Type48V = 43.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 30,
          Type12V = 10.93,
          Type24V = 21.85,
          Type48V = 43.7
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 31,
          Type12V = 10.95,
          Type24V = 21.9,
          Type48V = 43.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 32,
          Type12V = 10.98,
          Type24V = 21.95,
          Type48V = 43.9
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 33,
          Type12V = 11.0,
          Type24V = 22.0,
          Type48V = 44.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 34,
          Type12V = 11.02,
          Type24V = 22.04,
          Type48V = 44.08
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 35,
          Type12V = 11.04,
          Type24V = 22.08,
          Type48V = 44.16
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 36,
          Type12V = 11.06,
          Type24V = 22.12,
          Type48V = 44.24
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 37,
          Type12V = 11.08,
          Type24V = 22.16,
          Type48V = 44.32
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 38,
          Type12V = 11.1,
          Type24V = 22.2,
          Type48V = 44.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 39,
          Type12V = 11.13,
          Type24V = 22.25,
          Type48V = 44.5
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 40,
          Type12V = 11.15,
          Type24V = 22.3,
          Type48V = 44.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 41,
          Type12V = 11.18,
          Type24V = 22.35,
          Type48V = 44.7
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 42,
          Type12V = 11.2,
          Type24V = 22.4,
          Type48V = 44.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 43,
          Type12V = 11.22,
          Type24V = 22.44,
          Type48V = 44.88
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 44,
          Type12V = 11.24,
          Type24V = 22.48,
          Type48V = 44.96
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 45,
          Type12V = 11.26,
          Type24V = 22.52,
          Type48V = 45.04
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 46,
          Type12V = 11.28,
          Type24V = 22.56,
          Type48V = 45.12
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 47,
          Type12V = 11.3,
          Type24V = 22.6,
          Type48V = 45.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 48,
          Type12V = 11.33,
          Type24V = 22.65,
          Type48V = 45.3
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 49,
          Type12V = 11.35,
          Type24V = 22.7,
          Type48V = 45.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 50,
          Type12V = 11.38,
          Type24V = 22.75,
          Type48V = 45.5
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 51,
          Type12V = 11.4,
          Type24V = 22.8,
          Type48V = 45.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 52,
          Type12V = 11.43,
          Type24V = 22.87,
          Type48V = 45.73
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 53,
          Type12V = 11.47,
          Type24V = 22.93,
          Type48V = 45.87
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 54,
          Type12V = 11.5,
          Type24V = 23.0,
          Type48V = 46.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 55,
          Type12V = 11.55,
          Type24V = 23.1,
          Type48V = 46.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 56,
          Type12V = 11.6,
          Type24V = 23.2,
          Type48V = 46.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 57,
          Type12V = 11.63,
          Type24V = 23.27,
          Type48V = 46.53
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 58,
          Type12V = 11.67,
          Type24V = 23.33,
          Type48V = 46.67
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 59,
          Type12V = 11.7,
          Type24V = 23.4,
          Type48V = 46.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 60,
          Type12V = 11.75,
          Type24V = 23.5,
          Type48V = 47.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 61,
          Type12V = 11.8,
          Type24V = 23.6,
          Type48V = 47.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 62,
          Type12V = 11.83,
          Type24V = 23.67,
          Type48V = 47.33
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 63,
          Type12V = 11.87,
          Type24V = 23.73,
          Type48V = 47.47
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 64,
          Type12V = 11.9,
          Type24V = 23.8,
          Type48V = 47.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 65,
          Type12V = 11.95,
          Type24V = 23.9,
          Type48V = 47.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 66,
          Type12V = 12.0,
          Type24V = 24.0,
          Type48V = 48.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 67,
          Type12V = 12.03,
          Type24V = 24.07,
          Type48V = 48.13
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 68,
          Type12V = 12.07,
          Type24V = 24.13,
          Type48V = 48.27
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 69,
          Type12V = 12.1,
          Type24V = 24.2,
          Type48V = 48.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 70,
          Type12V = 12.15,
          Type24V = 24.3,
          Type48V = 48.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 71,
          Type12V = 12.2,
          Type24V = 24.4,
          Type48V = 48.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 72,
          Type12V = 12.23,
          Type24V = 24.45,
          Type48V = 48.9
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 73,
          Type12V = 12.25,
          Type24V = 24.5,
          Type48V = 49.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 74,
          Type12V = 12.28,
          Type24V = 24.55,
          Type48V = 49.1
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 75,
          Type12V = 12.3,
          Type24V = 24.6,
          Type48V = 49.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 76,
          Type12V = 12.32,
          Type24V = 24.64,
          Type48V = 49.28
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 77,
          Type12V = 12.34,
          Type24V = 24.68,
          Type48V = 49.36
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 78,
          Type12V = 12.36,
          Type24V = 24.72,
          Type48V = 49.44
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 79,
          Type12V = 12.38,
          Type24V = 24.76,
          Type48V = 49.52
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 80,
          Type12V = 12.4,
          Type24V = 24.8,
          Type48V = 49.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 81,
          Type12V = 12.43,
          Type24V = 24.85,
          Type48V = 49.7
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 82,
          Type12V = 12.45,
          Type24V = 24.9,
          Type48V = 49.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 83,
          Type12V = 12.48,
          Type24V = 24.95,
          Type48V = 49.9
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 84,
          Type12V = 12.5,
          Type24V = 25.0,
          Type48V = 50.0
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 85,
          Type12V = 12.52,
          Type24V = 25.04,
          Type48V = 50.08
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 86,
          Type12V = 12.54,
          Type24V = 25.08,
          Type48V = 50.16
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 87,
          Type12V = 12.56,
          Type24V = 25.12,
          Type48V = 50.24
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 88,
          Type12V = 12.58,
          Type24V = 25.16,
          Type48V = 50.32
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 89,
          Type12V = 12.6,
          Type24V = 25.2,
          Type48V = 50.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 90,
          Type12V = 12.63,
          Type24V = 25.25,
          Type48V = 50.5
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 91,
          Type12V = 12.65,
          Type24V = 25.3,
          Type48V = 50.6
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 92,
          Type12V = 12.68,
          Type24V = 25.35,
          Type48V = 50.7
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 93,
          Type12V = 12.7,
          Type24V = 25.4,
          Type48V = 50.8
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 94,
          Type12V = 12.72,
          Type24V = 25.44,
          Type48V = 50.88
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 95,
          Type12V = 12.74,
          Type24V = 25.48,
          Type48V = 50.96
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 96,
          Type12V = 12.76,
          Type24V = 25.52,
          Type48V = 51.04
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 97,
          Type12V = 12.78,
          Type24V = 25.56,
          Type48V = 51.12
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 98,
          Type12V = 12.8,
          Type24V = 25.6,
          Type48V = 51.2
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 99,
          Type12V = 12.85,
          Type24V = 25.7,
          Type48V = 51.4
        });
        pmEntity.Ep3000SocCompatables.Add(new Ep3000SocCompatable()
        {
          Soc = 100,
          Type12V = 12.9,
          Type24V = 25.8,
          Type48V = 51.6
        });
        pmEntity.SaveChanges();
      }
    }

    public List<Ep3000SocCompatable> Retrieve()
    {
      using (PMEntity pmEntity = new PMEntity())
        return pmEntity.Ep3000SocCompatables.ToList<Ep3000SocCompatable>();
    }
  }
}
