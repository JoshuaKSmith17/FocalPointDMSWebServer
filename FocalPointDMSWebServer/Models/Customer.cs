using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocalPointDMSWebServer.Models
{
    public class Customer
    {
        /*
         * Customer is any entity that the organization does business with. Customer can be a company or an individual.
         * Customer might have multiple locations(sites) where they own equipment.  Equipment will be related to the site for now.
         * That should help out when a location is transferred to another entity through a process such as a sale.
         */
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public List<Site> Sites { get; set; }
        public List<CustomerContact> CustomerContact { get; set; }


    }
}
