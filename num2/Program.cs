// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

double[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (MaxValue - MinValue) + MinValue, 2);
        }
    }
    return result;
}

void WriteArrayToConsole(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            System.Console.Write($"{doubleArray[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int FindMinSumRow(double[,] matrix)
{
    int row = 0;
    double minSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i + 1} строки равна -> {Math.Round(sum, 2)}");
    }
    return row + 1;
}

int rows = 3;
int colums = 5;
double[,] d_array = GetArray(rows, colums, -10, 10);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(d_array);
System.Console.WriteLine($"\nСтрока с минимальной суммой -> {FindMinSumRow(d_array)}");