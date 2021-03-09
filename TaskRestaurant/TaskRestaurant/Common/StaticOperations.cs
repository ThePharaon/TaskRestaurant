using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRestaurant.Common
{
    public class StaticOperations
    {
        public static bool IsValidInput(string text)
        {
            return !string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text);
        }
        public static void InitData()
        {
            // products
            StaticValues.AllProducts.Clear();
            StaticValues.AllProducts.Add(1, new Models.Product()
            {
                ID = 1,
                Name = "Tea",
                Price = 10,
                Photo = "Tea.png",
                Description = "Fresh Tea."
            });
            StaticValues.AllProducts.Add(2, new Models.Product()
            {
                ID = 2,
                Name = "Coffee",
                Price = 25,
                Photo = "Coffee.png",
                Description = "Tasty Coffee."
            });
            StaticValues.AllProducts.Add(3, new Models.Product()
            {
                ID = 3,
                Name = "Pizza",
                Price = 150,
                Photo = "Pizza.png",
                Description = "Big Size Pizza."
            });
            StaticValues.AllProducts.Add(4, new Models.Product()
            {
                ID = 4,
                Name = "Steak",
                Price = 230,
                Photo = "Steak.png",
                Description = "Beaf Steak with red sous."
            });
        }
    }
}
