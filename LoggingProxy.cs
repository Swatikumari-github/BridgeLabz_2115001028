

namespace AnnotationReflection
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    // Step 1: Define an interface
    public interface IGreeting1
    {
        void SayHello(string name);
        int AddNumbers(int a, int b);
    }

    // Step 2: Implement the interface
    public class GreetingService : IGreeting1
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }

    // Step 3: Create a dynamic proxy class using DispatchProxy
    public class LoggingProxy<T> : DispatchProxy
    {
        private T _instance;

        public static T Create(T instance)
        {
            var proxy = Create<T, LoggingProxy<T>>() as LoggingProxy<T>;
            proxy._instance = instance;
            return (T)(object)proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");

            object result = targetMethod.Invoke(_instance, args);

            if (targetMethod.ReturnType != typeof(void))
            {
                Console.WriteLine($"[LOG] Method {targetMethod.Name} returned: {result}");
            }

            return result;
        }
    }

    // Step 4: Use the proxy in the Main method
    class LoggingProxy1
    {
        static void Main()
        {
            // Create an instance of GreetingService
            IGreeting1 greeting = new GreetingService();

            // Wrap it in a logging proxy
            IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

            // Call methods through the proxy
            proxy.SayHello("Alice");
            int sum = proxy.AddNumbers(10, 20);

            Console.WriteLine($"Sum: {sum}");
        }
    }

}
