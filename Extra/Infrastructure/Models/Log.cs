// Decompiled with JetBrains decompiler
// Type: Infrastructure.Models.Log
// Assembly: Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C37DAAB3-24F9-4F2F-AB22-74E2D60C6018
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Infrastructure.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

// namespace PH1800.Extra.Infrastructure.Models
// {
//   public class Log
//   {
//     public static List<Log> logs = new List<Log>();
//
//     [Key]
//     public long Id { get; set; }
//
//     public string Model { get; set; }
//
//     public string Message { get; set; }
//
//     public DateTime Time { get; set; }
//
//     public static List<Log> Retrieve()
//     {
//       using (PMEntity pmEntity = new PMEntity())
//         return pmEntity.Logs.ToList<Log>();
//     }
//
//     public static List<Log> Retrieve(string modelName)
//     {
//       using (PMEntity pmEntity = new PMEntity())
//         return ((IEnumerable<Log>) Queryable.Where<Log>((IQueryable<M0>) pmEntity.Logs, (Expression<Func<M0, bool>>) (s => string.Equals(s.Model, modelName, StringComparison.OrdinalIgnoreCase)))).ToList<Log>();
//     }
//
//     public static void SaveLogs()
//     {
//       if (!Log.logs.Any<Log>())
//         return;
//       using (PMEntity pmEntity = new PMEntity())
//       {
//         pmEntity.Logs.AddRange((IEnumerable<Log>) Log.logs);
//         Log.logs.Clear();
//         pmEntity.SaveChanges();
//       }
//     }
//   }
//}
