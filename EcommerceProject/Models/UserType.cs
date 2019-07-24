using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class UserType
    {
        public int id { get; set; }
        public string Type { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
