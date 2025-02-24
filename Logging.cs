

namespace AnnotationReflection
{

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;

    public interface IGreeting
    {
        void SayHello(string name);
    }

    public class GreetingImplementation : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    public class LoggingProxy
    {
        public static T Create<T>(T target)
        {
            // Get the interface type
            Type interfaceType = typeof(T);

            // Define a dynamic assembly and module
            AssemblyName assemblyName = new AssemblyName("DynamicProxyAssembly");
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");

            // Define a proxy type that implements the interface
            TypeBuilder typeBuilder = moduleBuilder.DefineType("LoggingProxy", TypeAttributes.Public);
            typeBuilder.AddInterfaceImplementation(interfaceType);

            // Create a constructor for the proxy type
            ConstructorBuilder constructor = typeBuilder.DefineConstructor(
                MethodAttributes.Public, CallingConventions.Standard, new Type[] { interfaceType });
            ILGenerator constructorIL = constructor.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0); // Load 'this'
            constructorIL.Emit(OpCodes.Ldarg_1); // Load the target object
            constructorIL.Emit(OpCodes.Stfld, typeBuilder.DefineField("_target", interfaceType, FieldAttributes.Private));
            constructorIL.Emit(OpCodes.Ret);

            // Create the method to intercept
            foreach (var method in interfaceType.GetMethods())
            {
                MethodBuilder methodBuilder = typeBuilder.DefineMethod(method.Name,
                    MethodAttributes.Public | MethodAttributes.Virtual, method.ReturnType,
                    method.GetParameters().Select(p => p.ParameterType).ToArray());

                ILGenerator ilGenerator = methodBuilder.GetILGenerator();

                // Log the method name
                ilGenerator.Emit(OpCodes.Ldstr, $"Calling method: {method.Name}");
                ilGenerator.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }));

                // Call the original method
                ilGenerator.Emit(OpCodes.Ldarg_0); // Load 'this'
                ilGenerator.Emit(OpCodes.Ldfld, typeBuilder.DefineField("_target", interfaceType, FieldAttributes.Private)); // Load the target field
                ilGenerator.Emit(OpCodes.Ldarg_1); // Load method arguments
                ilGenerator.Emit(OpCodes.Callvirt, method); // Call the method

                ilGenerator.Emit(OpCodes.Ret);
            }

            // Create the proxy type
            Type proxyType = typeBuilder.CreateType();

            // Create the proxy object
            return (T)Activator.CreateInstance(proxyType, target);
        }
    }

    class Logging
    {
        static void Main()
        {
            // Create an instance of the actual implementation
            IGreeting greeting = new GreetingImplementation();

            // Create the proxy instance
            IGreeting proxy = LoggingProxy.Create(greeting);

            // Call the method on the proxy, which will log the method name
            proxy.SayHello("Alice");
        }
    }

}
