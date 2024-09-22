using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallCenter
{
    public class IncommingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    }
}