using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocalPointDMSWebServer.Models
{
    public class Site
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
