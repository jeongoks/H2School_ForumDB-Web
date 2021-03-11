using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace H2School_ForumDB_Web.Models
{
    public class Addresses
    {
        public int AddressID { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string RoadName { get; set; }
        public string HouseNumber { get; set; }
    }
}
