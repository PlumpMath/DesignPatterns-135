/*
 * 策略模式具有三种角色：
 * Context：环境，持有一个Strategy类的引用
 * Strategy：抽象策略，通常由一个接口或抽象类实现，给出所有的具体策略类所需的接口
 * ConcreteStrategy：包装相关算法和行为
 */
using static System.Console;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test structural example
            new Context(new ConcreteStrategyA()).ContextInterface();
            new Context(new ConcreteStrategyB()).ContextInterface();
            new Context(new ConcreteStrategyC()).ContextInterface();

            //Test log strategy
            new Log(new ConsoleLog()).AddContent("test").DoLog();
            new Log(new NotepadLog()).AddContent("test").DoLog();
            new Log(new NowhereLog()).AddContent("test").DoLog();

            ReadKey();
        }
    }
}
