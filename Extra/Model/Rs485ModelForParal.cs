// Decompiled with JetBrains decompiler
// Type: Model.Rs485ModelForParal
// Assembly: Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D1791FF-7A31-45F0-915A-28D92B8D3864
// Assembly location: D:\Program Files (x86)\CC\PowerMonitor\Model.dll

using Model.Annotations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
  public sealed class Rs485ModelForParal : INotifyPropertyChanged
  {
    public string _accumulatedBuyPower;
    public string _accumulatedChargerPower;
    public string _accumulatedDischargerPower;
    public string _accumulatedGridChargerPower;
    public string _accumulatedLoadPower;
    public string _accumulatedPower;
    public string _accumulatedPvSellPower;
    public string _accumulatedSelfUsePower;
    public string _accumulatedSellPower;
    public string _accumulatedTime;
    public string _acRadiatorTemperature;
    public string _acVoltageGrade;
    public string _battCurrent;
    public string _batteryRelay;
    public string _batteryVoltage;
    public string _battPower;
    public string _battVolGrade;
    public string _busVoltage;
    public string _chargerCurrent;
    public string _chargerPower;
    public string _chargerWorkstate;
    public string _chargingState;
    public string _combineType;
    public string _controlCurrent;
    public string _dcRadiatorTemperature;
    public string _dcRelayState;
    public int _chargerId;
    public string _earthRelayState;
    public string _errorMessage;
    public string _externalTemperature;
    public string _gridCurrent;
    public string _gridFrequency;
    public string _gridRelayState;
    public string _gridVoltage;
    public string _hardwareVersion;
    public string _inverterBatteryVoltage;
    public string _inverterCurrent;
    public string _inverterErrorMessage;
    public string _inverterFrequency;
    public string _inverterHardwareVersion;
    public string _inverterMachineType;
    public string _inverterMaxNumber;
    public string _inverterNumber;
    public string _inverterRelayState;
    public string _inverterSerialNumber;
    public string _inverterSoftwareVersion;
    public string _inverterVoltage;
    public string _inverterWarningMessage;
    public string _loadCurrent;
    public string _loadPercent;
    public string _loadRelayState;
    public string _machineType;
    public string _mpptState;
    public string _nLineRelayState;
    public string _pGrid;
    public string _pInverter;
    public string _pLoad;
    public string _pvRelay;
    public string _pvVoltage;
    public string _qgrid;
    public string _qinverter;
    public string _qload;
    public string _radiatorTemperature;
    public string _ratedCurrent;
    public string _ratedPower;
    public string _serialNumber;
    public string _sGrid;
    public string _sInverter;
    public string _sload;
    public string _softwareVersion;
    public string _transformerTemperature;
    public string _warningMessage;
    public string _workState;
    public int _inverterId;

    [Key]
    public long Id { get; set; }

    public int ChargerId
    {
      get
      {
        return this._chargerId;
      }
      set
      {
        if (value == this._chargerId)
          return;
        this._chargerId = value;
        this.OnPropertyChanged(nameof (ChargerId));
      }
    }

    public int InverterId
    {
      get
      {
        return this._inverterId;
      }
      set
      {
        if (value == this._inverterId)
          return;
        this._inverterId = value;
        this.OnPropertyChanged(nameof (InverterId));
      }
    }

    public DateTime RecordTime { get; set; }

    public string MachineType
    {
      get
      {
        return this._machineType;
      }
      set
      {
        if (value == this._machineType)
          return;
        this._machineType = value;
        this.OnPropertyChanged(nameof (MachineType));
      }
    }

    public string SerialNumber
    {
      get
      {
        return this._serialNumber;
      }
      set
      {
        if (value == this._serialNumber)
          return;
        this._serialNumber = value;
        this.OnPropertyChanged(nameof (SerialNumber));
      }
    }

    public string HardwareVersion
    {
      get
      {
        return this._hardwareVersion;
      }
      set
      {
        if (value == this._hardwareVersion)
          return;
        this._hardwareVersion = value;
        this.OnPropertyChanged(nameof (HardwareVersion));
      }
    }

    public string SoftwareVersion
    {
      get
      {
        return this._softwareVersion;
      }
      set
      {
        if (value == this._softwareVersion)
          return;
        this._softwareVersion = value;
        this.OnPropertyChanged(nameof (SoftwareVersion));
      }
    }

    [NotMapped]
    public string PvVoltageC { get; set; }

    [NotMapped]
    public string BatteryVoltageC { get; set; }

    [NotMapped]
    public string ChargerCurrentC { get; set; }

    [NotMapped]
    public string ChargerWorkEnable { get; set; }

    [NotMapped]
    public string AbsorbVoltage { get; set; }

    [NotMapped]
    public string FloatVoltage { get; set; }

    [NotMapped]
    public string AbsorptionVoltage { get; set; }

    [NotMapped]
    public string BatteryLowVoltage { get; set; }

    [NotMapped]
    public string BatteryHighVoltage { get; set; }

    [NotMapped]
    public string MaxChargerCurrent { get; set; }

    [NotMapped]
    public string AbsorbChargerCurrent { get; set; }

    [NotMapped]
    public string BatteryType { get; set; }

    [NotMapped]
    public string BatteryAh { get; set; }

    [NotMapped]
    public string RemoveTheAccumulatedData { get; set; }

    public string ChargerWorkstate
    {
      get
      {
        return this._chargerWorkstate;
      }
      set
      {
        if (value == this._chargerWorkstate)
          return;
        this._chargerWorkstate = value;
        this.OnPropertyChanged(nameof (ChargerWorkstate));
      }
    }

    public string MpptState
    {
      get
      {
        return this._mpptState;
      }
      set
      {
        if (value == this._mpptState)
          return;
        this._mpptState = value;
        this.OnPropertyChanged(nameof (MpptState));
      }
    }

    public string ChargingState
    {
      get
      {
        return this._chargingState;
      }
      set
      {
        if (value == this._chargingState)
          return;
        this._chargingState = value;
        this.OnPropertyChanged(nameof (ChargingState));
      }
    }

    public string PvVoltage
    {
      get
      {
        return this._pvVoltage;
      }
      set
      {
        if (value == this._pvVoltage)
          return;
        this._pvVoltage = value;
        this.OnPropertyChanged(nameof (PvVoltage));
      }
    }

    public string BatteryVoltage
    {
      get
      {
        return this._batteryVoltage;
      }
      set
      {
        if (value == this._batteryVoltage)
          return;
        this._batteryVoltage = value;
        this.OnPropertyChanged(nameof (BatteryVoltage));
      }
    }

    public string ChargerCurrent
    {
      get
      {
        return this._chargerCurrent;
      }
      set
      {
        if (value == this._chargerCurrent)
          return;
        this._chargerCurrent = value;
        this.OnPropertyChanged(nameof (ChargerCurrent));
      }
    }

    public string ChargerPower
    {
      get
      {
        return this._chargerPower;
      }
      set
      {
        if (value == this._chargerPower)
          return;
        this._chargerPower = value;
        this.OnPropertyChanged(nameof (ChargerPower));
      }
    }

    public string RadiatorTemperature
    {
      get
      {
        return this._radiatorTemperature;
      }
      set
      {
        if (value == this._radiatorTemperature)
          return;
        this._radiatorTemperature = value;
        this.OnPropertyChanged(nameof (RadiatorTemperature));
      }
    }

    public string ExternalTemperature
    {
      get
      {
        return this._externalTemperature;
      }
      set
      {
        if (value == this._externalTemperature)
          return;
        this._externalTemperature = value;
        this.OnPropertyChanged(nameof (ExternalTemperature));
      }
    }

    public string BatteryRelay
    {
      get
      {
        return this._batteryRelay;
      }
      set
      {
        if (value == this._batteryRelay)
          return;
        this._batteryRelay = value;
        this.OnPropertyChanged(nameof (BatteryRelay));
      }
    }

    public string PvRelay
    {
      get
      {
        return this._pvRelay;
      }
      set
      {
        if (value == this._pvRelay)
          return;
        this._pvRelay = value;
        this.OnPropertyChanged(nameof (PvRelay));
      }
    }

    public string ErrorMessage
    {
      get
      {
        return this._errorMessage;
      }
      set
      {
        if (value == this._errorMessage)
          return;
        this._errorMessage = value;
        this.OnPropertyChanged(nameof (ErrorMessage));
      }
    }

    public string WarningMessage
    {
      get
      {
        return this._warningMessage;
      }
      set
      {
        if (value == this._warningMessage)
          return;
        this._warningMessage = value;
        this.OnPropertyChanged(nameof (WarningMessage));
      }
    }

    public string BattVolGrade
    {
      get
      {
        return this._battVolGrade;
      }
      set
      {
        if (value == this._battVolGrade)
          return;
        this._battVolGrade = value;
        this.OnPropertyChanged(nameof (BattVolGrade));
      }
    }

    public string RatedCurrent
    {
      get
      {
        return this._ratedCurrent;
      }
      set
      {
        if (value == this._ratedCurrent)
          return;
        this._ratedCurrent = value;
        this.OnPropertyChanged(nameof (RatedCurrent));
      }
    }

    public string AccumulatedPower
    {
      get
      {
        return this._accumulatedPower;
      }
      set
      {
        if (value == this._accumulatedPower)
          return;
        this._accumulatedPower = value;
        this.OnPropertyChanged(nameof (AccumulatedPower));
      }
    }

    public string AccumulatedTime
    {
      get
      {
        return this._accumulatedTime;
      }
      set
      {
        if (value == this._accumulatedTime)
          return;
        this._accumulatedTime = value;
        this.OnPropertyChanged(nameof (AccumulatedTime));
      }
    }

    [NotMapped]
    public string InverterMachineType
    {
      get
      {
        return this._inverterMachineType;
      }
      set
      {
        if (value == this._inverterMachineType)
          return;
        this._inverterMachineType = value;
        this.OnPropertyChanged(nameof (InverterMachineType));
      }
    }

    public string InverterSerialNumber
    {
      get
      {
        return this._inverterSerialNumber;
      }
      set
      {
        if (value == this._inverterSerialNumber)
          return;
        this._inverterSerialNumber = value;
        this.OnPropertyChanged(nameof (InverterSerialNumber));
      }
    }

    [NotMapped]
    public string InverterHardwareVersion
    {
      get
      {
        return this._inverterHardwareVersion;
      }
      set
      {
        if (value == this._inverterHardwareVersion)
          return;
        this._inverterHardwareVersion = value;
        this.OnPropertyChanged(nameof (InverterHardwareVersion));
      }
    }

    [NotMapped]
    public string InverterSoftwareVersion
    {
      get
      {
        return this._inverterSoftwareVersion;
      }
      set
      {
        if (value == this._inverterSoftwareVersion)
          return;
        this._inverterSoftwareVersion = value;
        this.OnPropertyChanged(nameof (InverterSoftwareVersion));
      }
    }

    [NotMapped]
    public string InverterBatteryVoltageC { get; set; }

    [NotMapped]
    public string InverterVoltageC { get; set; }

    [NotMapped]
    public string GridVoltageC { get; set; }

    [NotMapped]
    public string BusVoltageC { get; set; }

    [NotMapped]
    public string ControlCurrentC { get; set; }

    [NotMapped]
    public string InverterCurrentC { get; set; }

    [NotMapped]
    public string GridCurrentC { get; set; }

    [NotMapped]
    public string LoadCurrentC { get; set; }

    [NotMapped]
    public string InverterOffgridWorkEnable { get; set; }

    [NotMapped]
    public string InverterOutputVoltageSet { get; set; }

    [NotMapped]
    public string InverterOutputFrequencySet { get; set; }

    [NotMapped]
    public string InverterSearchModeEnable { get; set; }

    [NotMapped]
    public string InverterDischargerToGridEnable { get; set; }

    [NotMapped]
    public string EnergyUseMode { get; set; }

    [NotMapped]
    public string GridProtectStandard { get; set; }

    [NotMapped]
    public string SolarUseAim { get; set; }

    [NotMapped]
    public string InverterMaxDischargerCurrent { get; set; }

    [NotMapped]
    public string NormalVoltagePoint { get; set; }

    [NotMapped]
    public string StartSellVoltagePoint { get; set; }

    [NotMapped]
    public string GridMaxChargerCurrentSet { get; set; }

    [NotMapped]
    public string InverterBatteryLowVoltage { get; set; }

    [NotMapped]
    public string InverterBatteryHighVoltage { get; set; }

    [NotMapped]
    public string MaxCombineChargerCurrent { get; set; }

    [NotMapped]
    public string SystemSetting { get; set; }

    public string ChargerSourcePriority { get; set; }

    public string WorkState
    {
      get
      {
        return this._workState;
      }
      set
      {
        if (value == this._workState)
          return;
        this._workState = value;
        this.OnPropertyChanged(nameof (WorkState));
      }
    }

    public string AcVoltageGrade
    {
      get
      {
        return this._acVoltageGrade;
      }
      set
      {
        if (value == this._acVoltageGrade)
          return;
        this._acVoltageGrade = value;
        this.OnPropertyChanged(nameof (AcVoltageGrade));
      }
    }

    public string RatedPower
    {
      get
      {
        return this._ratedPower;
      }
      set
      {
        if (value == this._ratedPower)
          return;
        this._ratedPower = value;
        this.OnPropertyChanged(nameof (RatedPower));
      }
    }

    public string InverterBatteryVoltage
    {
      get
      {
        return this._inverterBatteryVoltage;
      }
      set
      {
        if (value == this._inverterBatteryVoltage)
          return;
        this._inverterBatteryVoltage = value;
        this.OnPropertyChanged(nameof (InverterBatteryVoltage));
      }
    }

    public string InverterVoltage
    {
      get
      {
        return this._inverterVoltage;
      }
      set
      {
        if (value == this._inverterVoltage)
          return;
        this._inverterVoltage = value;
        this.OnPropertyChanged(nameof (InverterVoltage));
      }
    }

    public string GridVoltage
    {
      get
      {
        return this._gridVoltage;
      }
      set
      {
        if (value == this._gridVoltage)
          return;
        this._gridVoltage = value;
        this.OnPropertyChanged(nameof (GridVoltage));
      }
    }

    public string BusVoltage
    {
      get
      {
        return this._busVoltage;
      }
      set
      {
        if (value == this._busVoltage)
          return;
        this._busVoltage = value;
        this.OnPropertyChanged(nameof (BusVoltage));
      }
    }

    public string ControlCurrent
    {
      get
      {
        return this._controlCurrent;
      }
      set
      {
        if (value == this._controlCurrent)
          return;
        this._controlCurrent = value;
        this.OnPropertyChanged(nameof (ControlCurrent));
      }
    }

    public string InverterCurrent
    {
      get
      {
        return this._inverterCurrent;
      }
      set
      {
        if (value == this._inverterCurrent)
          return;
        this._inverterCurrent = value;
        this.OnPropertyChanged(nameof (InverterCurrent));
      }
    }

    public string GridCurrent
    {
      get
      {
        return this._gridCurrent;
      }
      set
      {
        if (value == this._gridCurrent)
          return;
        this._gridCurrent = value;
        this.OnPropertyChanged(nameof (GridCurrent));
      }
    }

    public string LoadCurrent
    {
      get
      {
        return this._loadCurrent;
      }
      set
      {
        if (value == this._loadCurrent)
          return;
        this._loadCurrent = value;
        this.OnPropertyChanged(nameof (LoadCurrent));
      }
    }

    public string PInverter
    {
      get
      {
        return this._pInverter;
      }
      set
      {
        if (value == this._pInverter)
          return;
        this._pInverter = value;
        this.OnPropertyChanged(nameof (PInverter));
      }
    }

    public string PGrid
    {
      get
      {
        return this._pGrid;
      }
      set
      {
        if (value == this._pGrid)
          return;
        this._pGrid = value;
        this.OnPropertyChanged(nameof (PGrid));
      }
    }

    public string PLoad
    {
      get
      {
        return this._pLoad;
      }
      set
      {
        if (value == this._pLoad)
          return;
        this._pLoad = value;
        this.OnPropertyChanged(nameof (PLoad));
      }
    }

    public string LoadPercent
    {
      get
      {
        return this._loadPercent;
      }
      set
      {
        if (value == this._loadPercent)
          return;
        this._loadPercent = value;
        this.OnPropertyChanged(nameof (LoadPercent));
      }
    }

    public string SInverter
    {
      get
      {
        return this._sInverter;
      }
      set
      {
        if (value == this._sInverter)
          return;
        this._sInverter = value;
        this.OnPropertyChanged(nameof (SInverter));
      }
    }

    public string SGrid
    {
      get
      {
        return this._sGrid;
      }
      set
      {
        if (value == this._sGrid)
          return;
        this._sGrid = value;
        this.OnPropertyChanged(nameof (SGrid));
      }
    }

    public string Sload
    {
      get
      {
        return this._sload;
      }
      set
      {
        if (value == this._sload)
          return;
        this._sload = value;
        this.OnPropertyChanged(nameof (Sload));
      }
    }

    public string Qinverter
    {
      get
      {
        return this._qinverter;
      }
      set
      {
        if (value == this._qinverter)
          return;
        this._qinverter = value;
        this.OnPropertyChanged(nameof (Qinverter));
      }
    }

    public string Qgrid
    {
      get
      {
        return this._qgrid;
      }
      set
      {
        if (value == this._qgrid)
          return;
        this._qgrid = value;
        this.OnPropertyChanged(nameof (Qgrid));
      }
    }

    public string Qload
    {
      get
      {
        return this._qload;
      }
      set
      {
        if (value == this._qload)
          return;
        this._qload = value;
        this.OnPropertyChanged(nameof (Qload));
      }
    }

    public string InverterFrequency
    {
      get
      {
        return this._inverterFrequency;
      }
      set
      {
        if (value == this._inverterFrequency)
          return;
        this._inverterFrequency = value;
        this.OnPropertyChanged(nameof (InverterFrequency));
      }
    }

    public string GridFrequency
    {
      get
      {
        return this._gridFrequency;
      }
      set
      {
        if (value == this._gridFrequency)
          return;
        this._gridFrequency = value;
        this.OnPropertyChanged(nameof (GridFrequency));
      }
    }

    public string InverterMaxNumber
    {
      get
      {
        return this._inverterMaxNumber;
      }
      set
      {
        if (value == this._inverterMaxNumber)
          return;
        this._inverterMaxNumber = value;
        this.OnPropertyChanged(nameof (InverterMaxNumber));
      }
    }

    public string CombineType
    {
      get
      {
        return this._combineType;
      }
      set
      {
        if (value == this._combineType)
          return;
        this._combineType = value;
        this.OnPropertyChanged(nameof (CombineType));
      }
    }

    public string InverterNumber
    {
      get
      {
        return this._inverterNumber;
      }
      set
      {
        if (value == this._inverterNumber)
          return;
        this._inverterNumber = value;
        this.OnPropertyChanged(nameof (InverterNumber));
      }
    }

    public string AcRadiatorTemperature
    {
      get
      {
        return this._acRadiatorTemperature;
      }
      set
      {
        if (value == this._acRadiatorTemperature)
          return;
        this._acRadiatorTemperature = value;
        this.OnPropertyChanged(nameof (AcRadiatorTemperature));
      }
    }

    public string TransformerTemperature
    {
      get
      {
        return this._transformerTemperature;
      }
      set
      {
        if (value == this._transformerTemperature)
          return;
        this._transformerTemperature = value;
        this.OnPropertyChanged(nameof (TransformerTemperature));
      }
    }

    public string DcRadiatorTemperature
    {
      get
      {
        return this._dcRadiatorTemperature;
      }
      set
      {
        if (value == this._dcRadiatorTemperature)
          return;
        this._dcRadiatorTemperature = value;
        this.OnPropertyChanged(nameof (DcRadiatorTemperature));
      }
    }

    public string InverterRelayState
    {
      get
      {
        return this._inverterRelayState;
      }
      set
      {
        if (value == this._inverterRelayState)
          return;
        this._inverterRelayState = value;
        this.OnPropertyChanged(nameof (InverterRelayState));
      }
    }

    public string GridRelayState
    {
      get
      {
        return this._gridRelayState;
      }
      set
      {
        if (value == this._gridRelayState)
          return;
        this._gridRelayState = value;
        this.OnPropertyChanged(nameof (GridRelayState));
      }
    }

    public string LoadRelayState
    {
      get
      {
        return this._loadRelayState;
      }
      set
      {
        if (value == this._loadRelayState)
          return;
        this._loadRelayState = value;
        this.OnPropertyChanged(nameof (LoadRelayState));
      }
    }

    public string N_LineRelayState
    {
      get
      {
        return this._nLineRelayState;
      }
      set
      {
        if (value == this._nLineRelayState)
          return;
        this._nLineRelayState = value;
        this.OnPropertyChanged(nameof (N_LineRelayState));
      }
    }

    public string DCRelayState
    {
      get
      {
        return this._dcRelayState;
      }
      set
      {
        if (value == this._dcRelayState)
          return;
        this._dcRelayState = value;
        this.OnPropertyChanged(nameof (DCRelayState));
      }
    }

    public string EarthRelayState
    {
      get
      {
        return this._earthRelayState;
      }
      set
      {
        if (value == this._earthRelayState)
          return;
        this._earthRelayState = value;
        this.OnPropertyChanged(nameof (EarthRelayState));
      }
    }

    public string AccumulatedChargerPower
    {
      get
      {
        return this._accumulatedChargerPower;
      }
      set
      {
        if (value == this._accumulatedChargerPower)
          return;
        this._accumulatedChargerPower = value;
        this.OnPropertyChanged(nameof (AccumulatedChargerPower));
      }
    }

    public string AccumulatedDischargerPower
    {
      get
      {
        return this._accumulatedDischargerPower;
      }
      set
      {
        if (value == this._accumulatedDischargerPower)
          return;
        this._accumulatedDischargerPower = value;
        this.OnPropertyChanged(nameof (AccumulatedDischargerPower));
      }
    }

    public string AccumulatedBuyPower
    {
      get
      {
        return this._accumulatedBuyPower;
      }
      set
      {
        if (value == this._accumulatedBuyPower)
          return;
        this._accumulatedBuyPower = value;
        this.OnPropertyChanged(nameof (AccumulatedBuyPower));
      }
    }

    public string AccumulatedSellPower
    {
      get
      {
        return this._accumulatedSellPower;
      }
      set
      {
        if (value == this._accumulatedSellPower)
          return;
        this._accumulatedSellPower = value;
        this.OnPropertyChanged(nameof (AccumulatedSellPower));
      }
    }

    public string AccumulatedLoadPower
    {
      get
      {
        return this._accumulatedLoadPower;
      }
      set
      {
        if (value == this._accumulatedLoadPower)
          return;
        this._accumulatedLoadPower = value;
        this.OnPropertyChanged(nameof (AccumulatedLoadPower));
      }
    }

    public string AccumulatedSelf_usePower
    {
      get
      {
        return this._accumulatedSelfUsePower;
      }
      set
      {
        if (value == this._accumulatedSelfUsePower)
          return;
        this._accumulatedSelfUsePower = value;
        this.OnPropertyChanged(nameof (AccumulatedSelf_usePower));
      }
    }

    public string AccumulatedPV_sellPower
    {
      get
      {
        return this._accumulatedPvSellPower;
      }
      set
      {
        if (value == this._accumulatedPvSellPower)
          return;
        this._accumulatedPvSellPower = value;
        this.OnPropertyChanged(nameof (AccumulatedPV_sellPower));
      }
    }

    public string AccumulatedGrid_chargerPower
    {
      get
      {
        return this._accumulatedGridChargerPower;
      }
      set
      {
        if (value == this._accumulatedGridChargerPower)
          return;
        this._accumulatedGridChargerPower = value;
        this.OnPropertyChanged(nameof (AccumulatedGrid_chargerPower));
      }
    }

    public string InverterErrorMessage
    {
      get
      {
        return this._inverterErrorMessage;
      }
      set
      {
        if (value == this._inverterErrorMessage)
          return;
        this._inverterErrorMessage = value;
        this.OnPropertyChanged(nameof (InverterErrorMessage));
      }
    }

    public string InverterWarningMessage
    {
      get
      {
        return this._inverterWarningMessage;
      }
      set
      {
        if (value == this._inverterWarningMessage)
          return;
        this._inverterWarningMessage = value;
        this.OnPropertyChanged(nameof (InverterWarningMessage));
      }
    }

    public string BattPower
    {
      get
      {
        return this._battPower;
      }
      set
      {
        if (value == this._battPower)
          return;
        this._battPower = value;
        this.OnPropertyChanged(nameof (BattPower));
      }
    }

    public string BattCurrent
    {
      get
      {
        return this._battCurrent;
      }
      set
      {
        if (value == this._battCurrent)
          return;
        this._battCurrent = value;
        this.OnPropertyChanged(nameof (BattCurrent));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public override string ToString()
    {
      switch (this.InverterId)
      {
        case 4:
          return "Device 1";
        case 5:
          return "Device 2";
        case 6:
          return "Device 3";
        default:
          return "Not Connected";
      }
    }

    [NotifyPropertyChangedInvocator]
    public void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public Rs485ModelForParal(int chargerId, int inverterId)
    {
      this.ChargerId = chargerId;
      this.InverterId = inverterId;
    }

    public Rs485ModelForParal()
    {
    }
  }
}
