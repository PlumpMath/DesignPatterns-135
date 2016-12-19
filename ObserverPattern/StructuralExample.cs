using System.Collections.Generic;
using static System.Console;

namespace ObserverPattern
{
    abstract class Subject
    {
        private List<IObserver> Observers = new List<IObserver>();
        public string Content { get; set; }

        public Subject(string content)
        {
            Content = content;
        }

        public Subject AddObserver(IObserver observer)
        {
            Observers.Add(observer);
            return this;
        }

        public Subject RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
            return this;
        }

        public Subject Notify()
        {
            foreach (var observer in Observers)
                if (null != observer)
                    observer.Receive(this);
            return this;
        }
    }

    class ConcreteSubject : Subject
    {
        public ConcreteSubject(string content) : base(content)
        {
        }
    }

    interface IObserver
    {
        void Receive(Subject subject);
    }

    class Subscriber : IObserver
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void Receive(Subject subject)
        {
            WriteLine($"{Name}收到了通知{subject.Content}");
        }
    }
}
