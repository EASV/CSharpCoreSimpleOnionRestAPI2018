using System;
using System.Collections.Generic;
using System.Linq;

namespace Cust.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }
    }
}
