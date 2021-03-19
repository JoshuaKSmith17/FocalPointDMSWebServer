using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocalPointDMSWebServer.Models
{
    public class RepairOrderLineItem
    {
        public long Id { get; set; }
        public string WorkPerformed { get; set; }
        public Equipment Equipment { get; set; }
    }
}
