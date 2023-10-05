using System;

namespace FutureTechnologies.Test.Ex2.Models
{
    public class Log
    {
        public int Sent { get; set; }

        public int Lost { get; set; }

        public int Received { get; set; }

        public string Time => $"{DateTimeOffset.Now.Hour}:{DateTimeOffset.Now.Minute}";
    }
}
