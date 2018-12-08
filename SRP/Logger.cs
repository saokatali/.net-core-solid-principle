using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SolidPrinciple.SRP
{
    // Logger class is only responsible for logging related operations 
    public class Logger : ILogger
    {
        public void Log(string data)
        {
            File.WriteAllText("log.txt", $"Time:{DateTime.Now};Text:{data}");
        }
    }
}
