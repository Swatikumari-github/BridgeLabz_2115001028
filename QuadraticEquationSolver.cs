using System;

class QuadraticEquationSolver
{
    
     public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[0]; // No real roots
        }
		}

    static void Main(string[] args)
    {
       Console.Write("Enter the value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("The roots of the quadratic equation are: {0} and {1}", roots[0], roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The root of the quadratic equation is: {0}", roots[0]);
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots.");
        }
		Console.ReadLine();
    }
}
