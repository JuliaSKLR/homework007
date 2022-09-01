// Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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


int MaxInRows(int[,] matrix)
{
    int sumMax = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max) max = matrix[i, j];
        }
        sumMax = sumMax + max;

    }

    return sumMax;
}

int MinInCollumns(int[,] matrix)
{
    int sumMin = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int min = matrix[0,0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
        }
        sumMin = sumMin + min;
    }
    return sumMin;
}

int[,] array = CreateMatrix(3, 3);
PrintArray(array);
int summax = MaxInRows(array);
int sumMin = MinInCollumns(array);
int dif = summax - sumMin;
Console.WriteLine($"Сумма максимальных в каждой строчке {summax} минус сумма минимальных в каждом столбце {sumMin} получается {dif}");

