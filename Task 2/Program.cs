/*  Задача 2: Задайте прямоугольный двумерный массив. 
 Напишите программу, которая будет находить строку с наименьшей суммой элементов. */
Random rndRows = new Random();
Random rndColumns = new Random();
int rows = rndRows.Next(2, 10);
int columns = rndColumns.Next(2, 10);
int[,] array = new int[rows, columns];
Random rand = new Random();
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(10, 100);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
int minSumOfRow = int.MaxValue;
int indexMinRow = 0;

for (int i = 0; i < rows; i++)
{
    int sumOfRow = 0;
    for (int j = 0; j < columns; j++)
    {
        sumOfRow += array[i, j];
    }
    if (sumOfRow < minSumOfRow)
    {
        minSumOfRow = sumOfRow;
        indexMinRow = i;
    }
}
Console.WriteLine($"Номер строки с минимальной суммой элементов - {indexMinRow + 1}, сумма = {minSumOfRow}");