// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
double[] sum = new double[columns];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        sum[i] += array[j, i];
    }
}
for (int i = 0; i < columns; i++)
{
    Console.WriteLine($"Среднее арифметическое столбца = {sum[i] / rows}");
}