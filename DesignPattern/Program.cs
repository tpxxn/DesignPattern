using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            /*====工厂方法模式====*/
            Console.WriteLine("====工厂方法模式====");
            Console.WriteLine("");
            new FactoryMethod.Client().Main();
            Console.WriteLine("");
            /*====抽象工厂模式====*/
            Console.WriteLine("====抽象工厂模式====");
            Console.WriteLine("");
            new AbstractFactory.Client().Main();
            Console.WriteLine("");
            /*====生成器模式====*/
            Console.WriteLine("====生成器模式====");
            Console.WriteLine("");
            new Builder.Program().Main();
            Console.WriteLine("");
            /*====原型模式====*/
            Console.WriteLine("====原型模式====");
            Console.WriteLine("");
            new Prototype.Program().Main();
            Console.WriteLine("");
            /*====单例模式====*/
            Console.WriteLine("====单例模式====");
            Console.WriteLine("");
            new Singleton.Program().Main();
            Console.WriteLine("");
        }
    }

}
