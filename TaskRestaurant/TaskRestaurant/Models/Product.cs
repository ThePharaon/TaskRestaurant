using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRestaurant.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        // because we wil use static resources for photos
        public string Photo { get; set; } 
    }
}
