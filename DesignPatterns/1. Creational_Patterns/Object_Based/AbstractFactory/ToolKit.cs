namespace AbstractFactory
{
    interface IFactory<Brand>
    where Brand : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }

    // Conctete Factories (both in the same one)
    class Factory<Brand> : IFactory<Brand>
      where Brand : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<Brand>();
        }
        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();
        }
    }

    // Product 1
    interface IBag
    {
        string Material { get; }
    }

    // Concrete Product 1
    class Bag<Brand> : IBag
      where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Bag()
        {
            myBrand = new Brand();
        }
    }
}