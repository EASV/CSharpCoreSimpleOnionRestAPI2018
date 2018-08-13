using Cust.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cust.Infrastructure.Data.Seed
{
    public static class DbInitializer
    {
        public static void Seed(CustomerAppDBContext context)
        {
            context.Customers.Add( new Customer
                {
                    Firstname = "Lars",
                    Lastname = "Bilde",
                    Address = "Uhhahahstrasse1",
                    EMail = "jumbaimba.org"
                }
            );

            context.SaveChanges();
        }
    }
}
