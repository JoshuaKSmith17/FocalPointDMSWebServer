using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocalPointDMSWebServer.Models
{
    public class RepairOrder
    {
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public List<RepairOrderLineItem> RepairOrderLineItem { get; set; }
    }
}
