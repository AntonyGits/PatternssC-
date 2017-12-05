using System;

namespace AbstractInstantiate
{
    abstract class AbstractFactory
    {
        public abstract AbstractProduct CreateProduct();        
    }

    abstract class AbstractProduct
    {
        public abstract void Operation();
    }

    class Program
    {
        static void Main()
        {
            AbstractFactory factory = null;
            // Абстрагирование процесса создания экземпляра.
            AbstractProduct product = factory.CreateProduct();
            // Абстрагирование вариантов использования.
            product.Operation();
        }
    }
}
