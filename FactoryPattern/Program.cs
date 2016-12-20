/*
 * 工厂模式具有四种角色：
 * Creator：抽象工厂角色，核心，与应用程序无关，在模式中创建的对象的工厂类必须实现这个接口
 * Concrete Creator：具体工厂角色，包含与应用程序密切相关的逻辑，受到应用程序调用以创建产品对象
 * Product：抽象产品角色，工厂方法模式创建的对象的超类型，产品对象的共同父类或共同拥有的接口
 * Concrete Product：具体产品角色，某具体产品有专门的具体工厂创建，往往一一对应
 */
using static System.Console;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new BulbCreator().Factory().TurnOn().TurnOff();
            new TubeCreator().Factory().TurnOn().TurnOff();

            ReadKey();
        }
    }
}
