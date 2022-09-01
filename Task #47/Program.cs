// Задача 47. Задайте двумерный массив размером 
// m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.NextDouble() * 10;
        Console.Write("{0,8:F1}", array[i, j]);
    }
    Console.WriteLine();
}