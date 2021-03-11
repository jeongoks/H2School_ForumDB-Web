using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_ForumDB_Web.Models
{
    public class User
    {
        public int UserID { get; set; }
        public Addresses AddressID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
