namespace FactoryMethod.Product
{
    abstract class Page
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}