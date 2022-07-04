/* Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */
int Sort(arrayTemp[,])
{
    for (int n = 0; n < arrayTemp.Length / 2; n++)
    {
        if (arrayTemp[n, m])
        {

        }
    }
}
Random rndRows = new Random();
Random rndColumns = new Random();
int rows = rndRows.Next(2, 3);
int columns = rndColumns.Next(2, 10);
int[,] array = new int[rows, columns];
Random rand = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(10, 1000);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
int Sort(array[]);