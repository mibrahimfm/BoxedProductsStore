namespace BoxedProductsStore
{
    internal class Box : IPackage
    {
        public Box()
        {
            BoxContext = new();
        }

        public List<IPackage> BoxContext { get; set; }

        public double Calculate()
        {
            double sum = 0.0;
            foreach (var content in BoxContext)
            {
                sum += content.Calculate();
            }

            return sum;
        }

        public void AddContent(IPackage content)
        {
            BoxContext.Add(content);
        }

        public void RemoveContent(IPackage content)
        {
            BoxContext.Remove(content);
        }
    }
}
