using System;
using System.Collections.Generic;
using System.Reflection;


namespace AnnotationReflection
{
   
    // Define the CacheResult attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheResultAttribute : Attribute
    {
        public CacheResultAttribute()
        {
        }
    }

    // CacheManager to manage cached results
    public class CacheManager
    {
        private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

        // Get the cached result for the method and parameters (if exists)
        public static object GetCache(string key)
        {
            if (Cache.ContainsKey(key))
            {
                return Cache[key];
            }
            return null;
        }

        // Set the cache for a method with a specific key
        public static void SetCache(string key, object value)
        {
            Cache[key] = value;
        }

        // Generate a unique key based on method name and parameters
        public static string GenerateCacheKey(MethodBase method, object[] parameters)
        {
            string key = method.Name + "(";
            foreach (var param in parameters)
            {
                key += param?.ToString() + ",";
            }
            key = key.TrimEnd(',') + ")";
            return key;
        }
    }

    // Class with the computationally expensive method
    public class Calculator
    {
        [CacheResult]  // Apply the CacheResult attribute to cache the result
        public int Fibonacci(int n)
        {
            Console.WriteLine($"Calculating Fibonacci for {n}...");

            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    // Custom method invoker to handle caching logic
    public class MethodInvoker
    {
        public static object InvokeMethod(object obj, MethodInfo method, object[] parameters)
        {
            // Check if the method has the CacheResult attribute
            var cacheResultAttribute = (CacheResultAttribute)Attribute.GetCustomAttribute(method, typeof(CacheResultAttribute));

            if (cacheResultAttribute != null)
            {
                // Generate a unique cache key based on the method name and parameters
                string cacheKey = CacheManager.GenerateCacheKey(method, parameters);

                // Check if the result is already cached
                var cachedResult = CacheManager.GetCache(cacheKey);

                if (cachedResult != null)
                {
                    Console.WriteLine("Returning cached result...");
                    return cachedResult;
                }

                // Call the method if the result is not cached
                var result = method.Invoke(obj, parameters);

                // Cache the result
                CacheManager.SetCache(cacheKey, result);

                return result;
            }

            // If CacheResult attribute is not present, just invoke the method normally
            return method.Invoke(obj, parameters);
        }
    }

    class Caching
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            // Get the Fibonacci method using reflection
            MethodInfo fibonacciMethod = typeof(Calculator).GetMethod("Fibonacci");

            // Invoke the method with parameter 10 and cache the result
            var result1 = MethodInvoker.InvokeMethod(calculator, fibonacciMethod, new object[] { 10 });
            Console.WriteLine($"Fibonacci(10) = {result1}");

            // Invoke the method with the same parameter (this should hit the cache)
            var result2 = MethodInvoker.InvokeMethod(calculator, fibonacciMethod, new object[] { 10 });
            Console.WriteLine($"Fibonacci(10) = {result2}");

            // Invoke the method with a different parameter (this should not hit the cache)
            var result3 = MethodInvoker.InvokeMethod(calculator, fibonacciMethod, new object[] { 15 });
            Console.WriteLine($"Fibonacci(15) = {result3}");

            // Invoke the method with the same parameter (this should hit the cache again)
            var result4 = MethodInvoker.InvokeMethod(calculator, fibonacciMethod, new object[] { 15 });
            Console.WriteLine($"Fibonacci(15) = {result4}");
        }
    }

}
