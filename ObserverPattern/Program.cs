/*
 * 观察者模式具有四种角色：
 * Subject：抽象主题，把所有观察者对象的引用保存到一个聚集里，每个主题都可以用任意数量的观察者，提供可以增删观察者对象的接口
 * ConcreteSubject：具体主题，将有关状态存入具体观察者对象，其内部状态改变时给所有注册过的观察者发出通知
 * Observer：抽象观察者，为所有的具体观察者定义一个接口，得到主题通知时更新自己
 * ConcreteObserver：实现抽象观察者角色所要求的更新接口，使本身的状态与主题状态协调
 */
using System;
using static System.Console;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test structural example
            new ConcreteSubject("雾霾天放假")
                .AddObserver(new Subscriber("One"))
                .AddObserver(new Subscriber("Two"))
                .AddObserver(new Subscriber("Three"))
                .AddObserver(new Subscriber("Four"))
                .Notify();

            var four = new Action<object>(new Subscriber2("Four").Receive);

            new ConcreteSubject2("雾霾天放假")
                .AddObserver(new Action<object>(new Subscriber2("One").Receive))
                .AddObserver(new Action<object>(new Subscriber2("Two").Receive))
                .AddObserver(new Action<object>(new Subscriber2("Three").Receive))
                .AddObserver(four)
                .Notify()
                .RemoveObserver(four)
                .Notify();

            ReadKey();
        }
    }
}
