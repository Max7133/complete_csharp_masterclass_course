using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_collections
{
    class Order
    {
        // Order ID
        public int OrderId { get; set; } 
        // Quantity of the Order
        public int OrderQuantity { get; set; }
        // Constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }
        // Print message on the screen that the Order was processed
        public void ProcessOrder()
        {
            // Print the message
            Console.WriteLine($"Order {OrderId} processed!.");
        } // OUTPUT
          // Order 1 processed!.
          // Order 2 processed!.
          // Order 6 processed!.
          // Order 3 processed!.
          // Order 4 processed!.
          // Order 5 processed!.
    }
}
