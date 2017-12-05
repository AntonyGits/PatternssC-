using System;

namespace AbstractInstantiate
{
    abstract class AbstractFactory
    {
        public abstract AbstractProduct CreateProduct();
    }

    class ConcreteFactory : AbstractFactory
    {
        public override AbstractProduct CreateProduct()
        {
            return new ConcreteProduct();
        }
    }

    abstract class AbstractProduct
    {
        public abstract void Operation();
    }

    class ConcreteProduct : AbstractProduct
    {
        public override void Operation()
        {
            Console.WriteLine("Some work ...");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractFactory factory = new ConcreteFactory();
            // Абстрагирование процесса создания экземпляра.
            AbstractProduct product = factory.CreateProduct();
            // Абстрагирование вариантов использования.
            product.Operation();
        }
    }
}
