using System;
using System.IO.Ports;
using Newtonsoft.Json;
using PH1800.Extra.RS485.Services;

namespace MonoInverter
{
    static class Program
    {
        static void Main(string[] args)
        {
            String spID = "/dev/ttyUSB0";
            if (args.Length > 0)
            {
                spID = "";

                for (int i = 0; i < spID.Length; i++)
                {
                    spID = spID + args[i];
                }
            }

            using (SerialPort sp = new SerialPort(spID, 19200)
            {
                ReadTimeout = 1000,
                WriteTimeout = 1000,
                RtsEnable = true
            })
            {
                var someData = Rs485ComServer.GetPartData(4, 4, sp);
                string output = JsonConvert.SerializeObject(someData);
                Console.WriteLine(output);
            }
        }
    }

}