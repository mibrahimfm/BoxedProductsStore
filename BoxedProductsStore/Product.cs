namespace BoxedProductsStore
{
    internal class Product : IPackage
    {
        public double Price { get; set; }
        public int Ammount { get; set; }

        public Product(double price, int ammount)
        {
            Price = price;
            Ammount = ammount;
        }

        public double Calculate()
        {
            return Price * Ammount;
        }
    }
}
