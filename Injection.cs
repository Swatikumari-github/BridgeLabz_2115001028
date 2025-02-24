

namespace AnnotationReflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    // Step 1: Define the Inject Attribute
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property)]
    public class InjectAttribute : Attribute { }

    // Step 2: Define a Simple DI Container
    public class SimpleDIContainer
    {
        private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

        // Register interface with its concrete implementation
        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _registrations[typeof(TInterface)] = typeof(TImplementation);
        }

        // Resolve an instance of the requested type
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type type)
        {
            if (!_registrations.ContainsKey(type) && !type.IsInterface)
            {
                return CreateInstance(type);
            }

            if (!_registrations.TryGetValue(type, out var implementationType))
            {
                throw new Exception($"No registered implementation for {type.Name}");
            }

            return CreateInstance(implementationType);
        }

        private object CreateInstance(Type type)
        {
            ConstructorInfo[] constructors = type.GetConstructors();

            // Find the constructor with the Inject attribute or the first constructor
            ConstructorInfo constructor = constructors.FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null)
                                          ?? constructors.FirstOrDefault();

            if (constructor == null)
            {
                throw new Exception($"No suitable constructor found for {type.Name}");
            }

            // Resolve dependencies for the constructor parameters
            ParameterInfo[] parameters = constructor.GetParameters();
            object[] arguments = parameters.Select(p => Resolve(p.ParameterType)).ToArray();

            return constructor.Invoke(arguments);
        }
    }

    // Step 3: Define Sample Services
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    // Step 4: Create a Class with Dependencies
    public class NotificationManager
    {
        private readonly IMessageService _messageService;

        [Inject] // This tells the DI container to inject the dependency
        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void NotifyUser(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    // Step 5: Use the DI Container in Main
    class Injection
    {
        static void Main()
        {
            // Create a DI container
            SimpleDIContainer container = new SimpleDIContainer();

            // Register services
            container.Register<IMessageService, EmailService>();

            // Resolve NotificationManager, dependencies will be auto-injected
            var notificationManager = container.Resolve<NotificationManager>();

            // Use the object
            notificationManager.NotifyUser("Hello, Dependency Injection!");
        }
    }

}
