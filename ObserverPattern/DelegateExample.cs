using System;
using static System.Console;

namespace ObserverPattern
{
    public class Subject2
    {
        private Action<object> NotifyEvent;
        public string Content { get; set; }

        public Subject2(string content)
        {
            Content = content;
        }

        public Subject2 AddObserver(Action<object> action)
        {
            NotifyEvent += action;
            return this;
        }

        public Subject2 RemoveObserver(Action<object> action)
        {
            NotifyEvent -= action;
            return this;
        }

        public Subject2 Notify()
        {
            NotifyEvent?.Invoke(this);
            return this;
        }
    }

    class ConcreteSubject2 : Subject2
    {
        public ConcreteSubject2(string content) : base(content)
        {
        }
    }

    interface IObserver2
    {
        void Receive(object obj);
    }

    class Subscriber2 : IObserver2
    {
        public string Name { get; set; }
        public Subscriber2(string name)
        {
            Name = name;
        }

        public void Receive(object obj)
        {
            Subject2 subject = obj as Subject2;
            if (null != subject)
                WriteLine($"{Name}收到了通知{subject.Content}");
        }
    }
}
