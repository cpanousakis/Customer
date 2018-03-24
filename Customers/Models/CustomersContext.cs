using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Customers.Models
{
    public class CustomersContext : DbContext
    {
    
        public CustomersContext() : base("name=CustomersContext")
        {
        }

        public DbSet<Customers.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Customers.Models.CustomerContact> CustomerContacts { get; set; }
    }
}
