/*  Задача 3: Задайте две матрицы. 
 Напишите программу, которая будет находить 
 произведение двух матриц. */
int[,] matrixA = new int[2, 3];
Random rand1 = new Random();
Console.WriteLine("Матрица 1:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrixA[i, j] = rand1.Next(1, 10);
        Console.Write($"{matrixA[i, j]} \t");
    }
    Console.WriteLine();
}
int[,] matrixB = new int[3, 3];
Random rand2 = new Random();
Console.WriteLine("Матрица 2:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrixB[i, j] = rand2.Next(1, 10);
        Console.Write($"{matrixB[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("Произведение матриц:");
int[,] matrixC = new int[2, 3];
for (int i = 0; i < 2; i++)
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