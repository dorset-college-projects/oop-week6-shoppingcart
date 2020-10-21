using System.Collections.Generic;

namespace ShoppingCart
{
    class ShoppingCart
    {
        public List<Product> ProductList { get; set; }
       
        public ShoppingCart()
        {
            ProductList = new List<Product>();
        }

        public double TotalPrice()
        {
            double Result = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                Result += ProductList[i].price;
            }
            return Result;
        }
    }
}
