using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
    }
}
