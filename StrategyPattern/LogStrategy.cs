using static System.Console;

namespace StrategyPattern
{
    class Log
    {
        private string content;
        private LogStrategy logStrategy;

        public Log(LogStrategy logStrategy)
        {
            this.logStrategy = logStrategy;
        }

        public void DoLog()
        {
            logStrategy.DoLog(content);
        }

        public Log AddContent(string content)
        {
            this.content = content;
            return this;
        }
    }
    /// <summary>
    /// Strategy
    /// </summary>
    abstract class LogStrategy
    {
        abstract public void DoLog(string content);
    }

    /// <summary>
    /// One of ConcreteStrategies
    /// </summary>
    class ConsoleLog : LogStrategy
    {
        public override void DoLog(string content)
        {
            WriteLine($"Log to console:{content}");
        }
    }

    /// <summary>
    /// One of ConcreteStrategies
    /// </summary>
    class NotepadLog : LogStrategy
    {
        public override void DoLog(string content)
        {
            WriteLine($"Log to notepad:{content}");
        }
    }

    /// <summary>
    /// One of ConcreteStrategies
    /// </summary>
    class NowhereLog : LogStrategy
    {
        public override void DoLog(string content)
        {
            WriteLine($"Log to nowhere:{content}");
        }
    }
}
