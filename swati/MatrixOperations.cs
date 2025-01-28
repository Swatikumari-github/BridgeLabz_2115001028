using System;

class MatrixOperations
{
    static void Main()
    {
        Console.Write("Enter rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix1 = CreateRandomMatrix(rows, cols);
        int[,] matrix2 = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        Console.WriteLine("Matrix Addition:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        Console.WriteLine("Matrix Subtraction:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            Console.WriteLine("Matrix Multiplication:");
            DisplayMatrix(MultiplyMatrices(matrix1, matrix2));
        }
        else
        {
            Console.WriteLine("Matrix multiplication not possible for the given matrices.");
        }

        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));

        if (rows == 2 && cols == 2)
        {
            Console.WriteLine("Determinant of Matrix 1: " + Determinant2x2(matrix1));
            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse2x2(matrix1));
        }

        if (rows == 3 && cols == 3)
        {
            Console.WriteLine("Determinant of Matrix 1: " + Determinant3x3(matrix1));
            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse3x3(matrix1));
        }
    }

    static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rand.Next(1, 10);
        return matrix;
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix1[i, j] + matrix2[i, j];
        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix1[i, j] - matrix2[i, j];
        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        int[,] result = new int[rows1, cols2];
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols2; j++)
                for (int k = 0; k < cols1; k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
        return result;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];
        return result;
    }

    static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    static double[,] Inverse2x2(int[,] matrix)
    {
        int det = Determinant2x2(matrix);
        if (det == 0)
            throw new InvalidOperationException("Matrix is not invertible.");

        double[,] result = new double[2, 2];
        result[0, 0] = matrix[1, 1] / (double)det;
        result[0, 1] = -matrix[0, 1] / (double)det;
        result[1, 0] = -matrix[1, 0] / (double)det;
        result[1, 1] = matrix[0, 0] / (double)det;
        return result;
    }

    static double[,] Inverse3x3(int[,] matrix)
    {
        int det = Determinant3x3(matrix);
        if (det == 0)
            throw new InvalidOperationException("Matrix is not invertible.");

        double[,] result = new double[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int[,] minor = GetMinor(matrix, i, j);
                result[j, i] = Determinant2x2(minor) * ((i + j) % 2 == 0 ? 1 : -1) / (double)det;
            }
        }
        return result;
    }

    static int[,] GetMinor(int[,] matrix, int row, int col)
    {
        int[,] minor = new int[2, 2];
        int m = 0, n = 0;
        for (int i = 0; i < 3; i++)
        {
            if (i == row) continue;
            n = 0;
            for (int j = 0; j < 3; j++)
            {
                if (j == col) continue;
                minor[m, n++] = matrix[i, j];
            }
            m++;
        }
        return minor;
    }

    static void DisplayMatrix<T>(T[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}
