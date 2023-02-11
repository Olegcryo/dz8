// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

double[,] GetMultArray(double[,] firstArray, double[,] secondArray)
{
    double[,] resultArray = new double[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, j] * secondArray[k, j];
            }
            resultArray[i, j] = Math.Round(resultArray[i, j], 2);
        }
        return resultArray;
}


int rows1 = 3;
int colums1 = 5;
int rows2 = colums1;
int colums2 = 4;
double[,] Array1 = GetArray(rows1, colums1, -10,10);
double[,] Array2 = GetArray(rows2, colums2, -10,10);
double[,] result = GetMultArray(Array1,Array2);

System.Console.WriteLine("Первый массив: ");
WriteArrayToConsole(Array1);
System.Console.WriteLine("\nВторой массив: ");
WriteArrayToConsole(Array2);
System.Console.WriteLine("\nИх произведение: ");
WriteArrayToConsole(result);