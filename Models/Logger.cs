namespace Models;
using System;
using System.IO;

    public class Logger
    {
        
        public static void Log(string logMessage, TextWriter w) {

        w.Write("\r\nLog Entry : ");
        w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
        w.WriteLine("  :");
        w.WriteLine($"  :{logMessage}");
        w.WriteLine ("-------------------------------");

        }


    }
