using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRestaurant.Models
{
    public class OrderItem
    {
        public int Prod_ID { get; set; }
        public int Order_ID { get; set; }
        public float Price { get; set; } = 0;
        public int Count { get; set; } = 0;
        public float Total { get => Price * Count; }
    }
}
