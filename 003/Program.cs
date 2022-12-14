// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Average(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double aver = 0;
        int sumrows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrows = sumrows + matrix[i, j];
        }
        aver = (double)sumrows / matrix.GetLength(0);
        System.Console.WriteLine($"Среднее арифметическое строки{i} = {aver}");

    }

}

int[,] array = CreateMatrix(4, 4);
PrintArray(array);
Average(array);