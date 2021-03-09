using System;
using System.Collections.Generic;
using System.Text;
using TaskRestaurant.Common;

namespace TaskRestaurant.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderTime { get; set; }
        public float Total { get; set; } = 0;
        public OrderStatus Description { get; set; } = OrderStatus.Unknown;
        public int ProdCount { get; set; } = 0;
    }
}
