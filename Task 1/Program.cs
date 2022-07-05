/* Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */

Random rndRows = new Random();
Random rndColumns = new Random();
int rows = rndRows.Next(2, 10);
int columns = rndColumns.Next(2, 10);
int[,] array = new int[rows, columns];
Random rand = new Random();
Console.WriteLine("Массив до сортировки:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(10, 100);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

for (int k = 0; k <= (rows * columns); k++)
{
    for (int m = 0; m < rows; m++)
    {
        for (int n = 0; n < columns - 1; n++)
        {
            if (array[m, n] < array[m, n + 1])
            {
                int temp = array[m, n];
                array[m, n] = array[m, n + 1];
                array[m, n + 1] = temp;
            }
        }
    }

}
Console.WriteLine("После сортировки строк по убыванию:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();

}
