/*  Задача 3: Задайте две матрицы. 
 Напишите программу, которая будет находить 
 произведение двух матриц. */

int[,] FillMatrix(int[,] matrix)
{
    int[,] matrix1 = new int[3, 3];
    Random rand = new Random();
    Console.WriteLine("Матрица:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix1[i, j] = rand.Next(1, 10);
            Console.Write($"{matrix1[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix1;
}

int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    Console.WriteLine("Произведение матриц:");
    int[,] matrixC = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int l = 0; l < 3; l++)
        {
            matrixC[i, l] = 0;
            for (int k = 0; k < 3; k++)
            {
                matrixC[i, l] += matrixA[i, k] * matrixB[k, l];
            }
            Console.Write($"{matrixC[i, l]} \t");
        }
        Console.WriteLine();
    }
    return matrixC;
}
var m = new int[,] { };
int[,] mxA = FillMatrix(m);
int[,] mxB = FillMatrix(m);
int[,] mxC = ProductMatrix(mxA, mxB);