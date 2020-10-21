namespace ShoppingCart
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string _name)
        {
            name = _name;
            price = Pricing.getPricing(_name);
        }
    }
}
