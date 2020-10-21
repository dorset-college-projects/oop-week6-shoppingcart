namespace ShoppingCart
{
    public static class Pricing
    {

        public static double getPricing(string item)
        {
            double price = 0;

            switch(item.ToLower()) {
                case "apples":  price = .6; break;
                case "oranges":  price = .25; break;
                default: price = 1000; break;

            }

            return price;




        }

    }
}
