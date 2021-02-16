using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocalPointDMSWebServer.Models
{
    public class Equipment
    {
        public long Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}
