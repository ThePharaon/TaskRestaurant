using System;
using System.Collections.Generic;
using System.Text;
using TaskRestaurant.Models;

namespace TaskRestaurant.Common
{
    public class StaticValues
    {
        public static readonly Dictionary<string, User> AllUsers = new Dictionary<string, User>();
        public static readonly Dictionary<int, Product> AllProducts = new Dictionary<int, Product>();
        public static readonly Dictionary<int, Order> AllOrders = new Dictionary<int, Order>();
        public static readonly Dictionary<int, OrderItem> Cart = new Dictionary<int, OrderItem>();
        public static User CurrentUser = null;
    }
}
