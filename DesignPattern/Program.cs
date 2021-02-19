using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            // CreationalPattern();
            StructuralPattern();
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

        private static void StructuralPattern()
        {
            CallPattern("适配器模式", () =>
            {
                new Adapter.Program().Main();
            });
            CallPattern("桥接模式", () =>
            {
                new Bridge.Program().Main();
            });
            CallPattern("组合模式", () =>
            {
                new Composite.Program().Main();
            });
            CallPattern("装饰模式", () =>
            {
                new Decorator.Program().Main();
            });
            CallPattern("外观模式", () =>
            {
                new Facade.Program().Main();
            });
            CallPattern("享元模式", () =>
            {
                new Flyweight.Program().Main();
            });
            CallPattern("代理模式", () =>
            {
                new Proxy.Program().Main();
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
