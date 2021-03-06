# Console Dumper for Must Power PH1800 Inverters
[See my blog post for more info](https://aquarat.co.za/teardowns/reverse-engineering-a-solar-inverter-telemetry-protocol/).

This is an extremely basic wrapper application for a decompiled library that targets Must Power PH1800 hybrid solar inverters. This app connects to the inverter, grabs all the current inverter stats and dumps the data as a JSON payload to stdout. It works well on a Raspberry Pi connected to a Must Power PH1800 via USB.

The project is provided as-is. I no longer own a PH1800 (it blew up, long story). A binary executable for 32bit armhf boards (like the Pi) is provided [here](https://drive.google.com/file/d/15P8vta8QaSq_NnfAfMa6vZBCbI7lMW-g/view?usp=sharing).

This project was put together with Jetbrains Rider on Ubuntu. It required some changes to the build script.

Sample Home Assistant Sensor definitions based on the payload are provided below as well as sample output:

```
{"_accumulatedBuyPower":"2651.9","_accumulatedChargerPower":"904.3","_accumulatedDischargerPower":"1884.1","_accumulatedGridChargerPower":"904.3","_accumulatedLoadPower":"3654.1","_accumulatedPower":"1856.3","_accumulatedPvSellPower":"4","_accumulatedSelfUsePower":"1002.1","_accumulatedSellPower":"4","_accumulatedTime":"206:18:58","_acRadiatorTemperature":"27","_acVoltageGrade":"230","_battCurrent":"-2","_batteryRelay":"Connect","_batteryVoltage":"52.2","_battPower":"-146","_battVolGrade":"48","_busVoltage":"415.5","_chargerCurrent":"9.8","_chargerPower":"511","_chargerWorkstate":"Work Mode","_chargingState":" Float charge","_combineType":"0000","_controlCurrent":"1.5","_dcRadiatorTemperature":"24","_dcRelayState":"Connect","_chargerId":4,"_earthRelayState":"Disconnect","_errorMessage":"","_externalTemperature":"-53","_gridCurrent":"1.1","_gridFrequency":"49.97","_gridRelayState":"Connect","_gridVoltage":"218.2","_hardwareVersion":"1.02.02","_inverterBatteryVoltage":"52.1","_inverterCurrent":"1.5","_inverterErrorMessage":"","_inverterFrequency":"49.97","_inverterHardwareVersion":"1.01.01","_inverterMachineType":"PH1800","_inverterMaxNumber":"0000","_inverterNumber":"0000","_inverterRelayState":"Connect","_inverterSerialNumber":"FFFFFFFF","_inverterSoftwareVersion":"2.55.19","_inverterVoltage":"217","_inverterWarningMessage":"","_loadCurrent":"1.5","_loadPercent":"6","_loadRelayState":"Connect","_machineType":"0708","_mpptState":"Current limiting","_nLineRelayState":"Disconnect","_pGrid":"0","_pInverter":"306","_pLoad":"288","_pvRelay":"Connect","_pvVoltage":"107.8","_qgrid":"240","_qinverter":"105","_qload":"171","_radiatorTemperature":"28","_ratedCurrent":"80","_ratedPower":"5000","_serialNumber":"FFFFFFFF","_sGrid":"242","_sInverter":"319","_sload":"335","_softwareVersion":"1.16.26","_transformerTemperature":"47","_warningMessage":"","_workState":"Grid-Tie","_inverterId":4,"Id":0,"ChargerId":4,"InverterId":4,"RecordTime":"0001-01-01T00:00:00","MachineType":"0708","SerialNumber":"FFFFFFFF","HardwareVersion":"1.02.02","SoftwareVersion":"1.16.26","PvVoltageC":"4000","BatteryVoltageC":"4000","ChargerCurrentC":"4000","ChargerWorkEnable":"1","AbsorbVoltage":"50","FloatVoltage":"52","AbsorptionVoltage":"52.5","BatteryLowVoltage":"34","BatteryHighVoltage":"60","MaxChargerCurrent":"80","AbsorbChargerCurrent":"10","BatteryType":"2","BatteryAh":"200","RemoveTheAccumulatedData":"0","ChargerWorkstate":"Work Mode","MpptState":"Current limiting","ChargingState":" Float charge","PvVoltage":"107.8","BatteryVoltage":"52.2","ChargerCurrent":"9.8","ChargerPower":"511","RadiatorTemperature":"28","ExternalTemperature":"-53","BatteryRelay":"Connect","PvRelay":"Connect","ErrorMessage":"","WarningMessage":"","BattVolGrade":"48","RatedCurrent":"80","AccumulatedPower":"1856.3","AccumulatedTime":"206:18:58","InverterMachineType":"PH1800","InverterSerialNumber":"FFFFFFFF","InverterHardwareVersion":"1.01.01","InverterSoftwareVersion":"2.55.19","InverterBatteryVoltageC":"4040","InverterVoltageC":"FFFF","GridVoltageC":"FFFF","BusVoltageC":"FFFF","ControlCurrentC":"FFFF","InverterCurrentC":"FFFF","GridCurrentC":"FFFF","LoadCurrentC":"FFFF","InverterOffgridWorkEnable":"1","InverterOutputVoltageSet":"230","InverterOutputFrequencySet":"5000","InverterSearchModeEnable":"0","InverterDischargerToGridEnable":"0","EnergyUseMode":"2","GridProtectStandard":"2","SolarUseAim":"1","InverterMaxDischargerCurrent":"21.7","NormalVoltagePoint":"46.8","StartSellVoltagePoint":"52","GridMaxChargerCurrentSet":"30","InverterBatteryLowVoltage":"46.8","InverterBatteryHighVoltage":"60","MaxCombineChargerCurrent":"80","SystemSetting":"1100010000000000","ChargerSourcePriority":"2","WorkState":"Grid-Tie","AcVoltageGrade":"230","RatedPower":"5000","InverterBatteryVoltage":"52.1","InverterVoltage":"217","GridVoltage":"218.2","BusVoltage":"415.5","ControlCurrent":"1.5","InverterCurrent":"1.5","GridCurrent":"1.1","LoadCurrent":"1.5","PInverter":"306","PGrid":"0","PLoad":"288","LoadPercent":"6","SInverter":"319","SGrid":"242","Sload":"335","Qinverter":"105","Qgrid":"240","Qload":"171","InverterFrequency":"49.97","GridFrequency":"49.97","InverterMaxNumber":"0000","CombineType":"0000","InverterNumber":"0000","AcRadiatorTemperature":"27","TransformerTemperature":"47","DcRadiatorTemperature":"24","InverterRelayState":"Connect","GridRelayState":"Connect","LoadRelayState":"Connect","N_LineRelayState":"Disconnect","DCRelayState":"Connect","EarthRelayState":"Disconnect","AccumulatedChargerPower":"904.3","AccumulatedDischargerPower":"1884.1","AccumulatedBuyPower":"2651.9","AccumulatedSellPower":"4","AccumulatedLoadPower":"3654.1","AccumulatedSelf_usePower":"1002.1","AccumulatedPV_sellPower":"4","AccumulatedGrid_chargerPower":"904.3","InverterErrorMessage":"","InverterWarningMessage":"","BattPower":"-146","BattCurrent":"-2"}
```

```
sensor:
  - platform: mqtt
    state_topic: "/inverter"
    name: "_acRadiatorTemperature"
    expire_after: 360
    value_template: "{{ value_json._acRadiatorTemperature }}"
    unit_of_measurement: '°C'
  - platform: mqtt
    state_topic: "/inverter"
    name: "_dcRadiatorTemperature"
    expire_after: 360
    value_template: "{{ value_json._dcRadiatorTemperature }}"
    unit_of_measurement: '°C'
  - platform: mqtt
    state_topic: "/inverter"
    name: "_transformerTemperature"
    expire_after: 360
    value_template: "{{ value_json._transformerTemperature }}"
    unit_of_measurement: '°C'
  - platform: mqtt
    state_topic: "/inverter"
    name: "_battCurrent"
    expire_after: 360
    value_template: "{{ value_json._battCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_chargerCurrent"
    expire_after: 360
    value_template: "{{ value_json._chargerCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_controlCurrent"
    expire_after: 360
    value_template: "{{ value_json._controlCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_gridCurrent"
    expire_after: 360
    value_template: "{{ value_json._gridCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_inverterCurrent"
    expire_after: 360
    value_template: "{{ value_json._inverterCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_loadCurrent"
    expire_after: 360
    value_template: "{{ value_json._loadCurrent }}"
    unit_of_measurement: 'A'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_gridFrequency"
    expire_after: 360
    value_template: "{{ value_json._gridFrequency }}"
    unit_of_measurement: 'Hz'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_inverterBatteryVoltage"
    expire_after: 360
    value_template: "{{ value_json._inverterBatteryVoltage }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_inverterVoltage"
    expire_after: 360
    value_template: "{{ value_json._inverterVoltage }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_loadPercent"
    expire_after: 360
    value_template: "{{ value_json._loadPercent }}"
    unit_of_measurement: '%'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_battPower"
    expire_after: 360
    value_template: "{{ value_json._battPower }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_pGrid"
    expire_after: 360
    value_template: "{{ value_json._pGrid }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_pInverter"
    expire_after: 360
    value_template: "{{ value_json._pInverter }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_inverterVoltage"
    expire_after: 360
    value_template: "{{ value_json._pLoad }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_busVoltage"
    expire_after: 360
    value_template: "{{ value_json._busVoltage }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_sload"
    expire_after: 360
    value_template: "{{ value_json._sload }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_chargerPower"
    expire_after: 360
    value_template: "{{ value_json._chargerPower }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_sInverter"
    expire_after: 360
    value_template: "{{ value_json._sInverter }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_qgrid"
    expire_after: 360
    value_template: "{{ value_json._qgrid }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_qinverter"
    expire_after: 360
    value_template: "{{ value_json._qinverter }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_qload"
    expire_after: 360
    value_template: "{{ value_json._qload }}"
    unit_of_measurement: 'W'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_sGrid"
    expire_after: 360
    value_template: "{{ value_json._sGrid }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_pvVoltage"
    expire_after: 360
    value_template: "{{ value_json._pvVoltage }}"
    unit_of_measurement: 'V'
    device_class: power
  - platform: mqtt
    state_topic: "/inverter"
    name: "_mpptState"
    expire_after: 360
    value_template: "{{ value_json._mpptState }}"
  - platform: mqtt
    state_topic: "/inverter"
    name: "PV Inverter Power"
    expire_after: 360
    value_template: "{{ value_json.PInverter }}"
    unit_of_measurement: 'W'
    device_class: power
```
