// Decompiled with JetBrains decompiler
// Type: Rs485.UnitedRs485
// Assembly: Rs485, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5E205531-BA01-47B2-8CDC-F6CADFAB970B
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Rs485.dll

using Model;
using Model.Annotations;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Rs485
{
  public sealed class UnitedRs485 : INotifyPropertyChanged
  {
    private string _portName;

    public UnitedRs485(MachinaType t, string portName)
    {
      switch (t)
      {
        case MachinaType.Linkable:
          ObservableCollection<Rs485ModelForParal> observableCollection1 = new ObservableCollection<Rs485ModelForParal>();
          ((Collection<Rs485ModelForParal>) observableCollection1).Add(new Rs485ModelForParal(4, 4));
          ((Collection<Rs485ModelForParal>) observableCollection1).Add(new Rs485ModelForParal(5, 5));
          ((Collection<Rs485ModelForParal>) observableCollection1).Add(new Rs485ModelForParal(6, 6));
          this.Rs485Models = observableCollection1;
          break;
        case MachinaType.unlinkable:
          ObservableCollection<Rs485ModelForParal> observableCollection2 = new ObservableCollection<Rs485ModelForParal>();
          ((Collection<Rs485ModelForParal>) observableCollection2).Add(new Rs485ModelForParal(4, 4));
          this.Rs485Models = observableCollection2;
          break;
        case MachinaType.LinkablePart:
          ObservableCollection<Rs485ModelForParal> observableCollection3 = new ObservableCollection<Rs485ModelForParal>();
          ((Collection<Rs485ModelForParal>) observableCollection3).Add(new Rs485ModelForParal(1, 4));
          ((Collection<Rs485ModelForParal>) observableCollection3).Add(new Rs485ModelForParal(2, 5));
          ((Collection<Rs485ModelForParal>) observableCollection3).Add(new Rs485ModelForParal(3, 6));
          this.Rs485Models = observableCollection3;
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof (t), (object) t, (string) null);
      }
      if (!string.IsNullOrEmpty(portName))
        this.PortName = portName;
      this.MTypy = t;
    }

    public string PortName
    {
      get
      {
        return this._portName;
      }
      set
      {
        if (value == this._portName)
          return;
        this._portName = value;
        this.OnPropertyChanged(nameof (PortName));
      }
    }

    public MachinaType MTypy { get; set; }

    public ObservableCollection<Rs485ModelForParal> Rs485Models { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    private void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
