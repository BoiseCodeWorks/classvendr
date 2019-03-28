namespace classvendr.Models
{
    class Electronic
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public string UpdatePrice(decimal newPrice)
        {
            if (newPrice > Price)
            {
                Price = newPrice;
                return Price.ToString();
            }
            return "CANNOT DECREASE PROFITS";
        }

        public Electronic(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}