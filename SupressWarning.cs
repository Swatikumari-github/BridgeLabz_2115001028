using System;
using System.Collections;

namespace AnnotationReflection
{
    

    class SupressWarning
    {
        static void Main()
        {
            // Suppress the warnings for using non-generic ArrayList
#pragma warning disable 0618

            // Creating an ArrayList without generics
            ArrayList oldArrayList = new ArrayList();

            // Adding elements to the ArrayList
            oldArrayList.Add(10);
            oldArrayList.Add("Hello");
            oldArrayList.Add(3.14);

            // Displaying the elements of the ArrayList
            foreach (var item in oldArrayList)
            {
                Console.WriteLine(item);
            }

            // Re-enable warnings after the unchecked operation
#pragma warning restore 0618
        }
    }

}
