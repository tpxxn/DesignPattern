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
            StructuralPattern();
            BehavioralPattern();
        }

        /// <summary>
        /// 创建型模式
        /// </summary>
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

        /// <summary>
        /// 结构型模式
        /// </summary>
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

        /// <summary>
        /// 行为模式
        /// </summary>
        private static void BehavioralPattern()
        {
            CallPattern("责任链模式", () =>
            {
                new ChainOfResponsibility.Program().Main();
            });
            CallPattern("命令模式", () =>
            {
                new Command.Program().Main();
            });
            CallPattern("迭代器模式", () =>
            {
                new Iterator.Program().Main();
            });
            CallPattern("中介者模式", () =>
            {
                new Mediator.Program().Main();
            });
            CallPattern("备忘录模式", () =>
            {
                new Memento.Program().Main();
            });
            CallPattern("观察者模式", () =>
            {
                new Observer.Program().Main();
            });
            CallPattern("状态模式", () =>
            {
                new State.Program().Main();
            });
            CallPattern("策略模式", () =>
            {
                new Strategy.Program().Main();
            });
            CallPattern("模板方法模式", () =>
            {
                new TemplateMethod.Program().Main();
            });
            CallPattern("访问者模式", () =>
            {
                new Visitor.Program().Main();
            });
        }

        /// <summary>
        /// 调用指定模式
        /// </summary>
        /// <param name="patternChineseName">模式中文名称，用于打印显示</param>
        /// <param name="callback">实际调用模式的方法回调</param>
        private static void CallPattern(string patternChineseName, Action callback)
        {
            Console.WriteLine($"===={patternChineseName}====");
            Console.WriteLine("");
            callback();
            Console.WriteLine("");
        }
    }

}
