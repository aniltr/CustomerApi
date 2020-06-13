using System;

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
