using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            CreationalPattern();
        }

        private static void CreationalPattern()
        {
            CallPattern("工厂方法模式", () =>
            {
                new FactoryMethod.Client().Main();
            });
            CallPattern("抽象工厂模式", () =>
            {
                new AbstractFactory.Client().Main();
            });
            CallPattern("生成器模式", () =>
            {
                new Builder.Program().Main();
            });
            CallPattern("原型模式", () =>
            {
                new Prototype.Program().Main();
            });
            CallPattern("单例模式", () =>
            {
                new Singleton.Program().Main();
            });
        }

        private static void CallPattern(string patternChineseName, Action callback)
        {
            Console.WriteLine($"===={patternChineseName}====");
            Console.WriteLine("");
            callback();
            Console.WriteLine("");
        }
    }

}
