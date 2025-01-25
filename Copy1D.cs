using System;

class Program
{
    static void Copy1D( int[,] matrix,int rows,int columns)
    {
        
         int[] array = new int[rows * columns];
        int index = 0;
		  for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
		  Console.WriteLine("\nThe 2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
           Console.WriteLine("\nThe 1D Array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
         Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
		 Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());
		  int[,] matrix = new int[rows, columns];
		    Console.WriteLine("\nEnter the elements of the 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
		  
		Copy1D(matrix,rows,columns);

        }
}