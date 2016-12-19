using static System.Console;

namespace StrategyPattern
{
    #region Context角色
    class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
    #endregion

    #region Strategy角色
    abstract class Strategy
    {
        abstract public void AlgorithmInterface();
    }
    #endregion

    #region ConcreteStrategy角色
    class ConcreteStrategyA : Strategy
    {
        override public void AlgorithmInterface()
        {
            WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        override public void AlgorithmInterface()
        {
            WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        override public void AlgorithmInterface()
        {
            WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
    #endregion
}
