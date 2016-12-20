namespace SingletonPattern
{
    public class Singleton
    {
        private volatile static Singleton instance = null;
        private static readonly object lockHelper = new object();
        private Singleton() { }
        public static Singleton CreateInstance()
        {
            if (instance == null)
                lock (lockHelper)
                    if (instance == null)
                        instance = new Singleton();
            return instance;
        }
    }

    public class Singleton2
    {
        public static readonly Singleton2 Instance = new Singleton2();
        private Singleton2() { }
    }
}
