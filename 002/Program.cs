// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNumSearch(int[,] array)
{
    int x = Prompt("ВВедите значение строки ");
    int y = Prompt("Введите значение столбца ");

    if (x < 0 || y < 0)
        {
        System.Console.WriteLine("Аргументы массива не могут быть отрицательными");
        }

    else if (x > array.GetLength(0) || y > array.GetLength(1))
        {
        Console.WriteLine("В данном массиве нет такой позиции");
        }

    else Console.WriteLine($"В данном массиве на позиции [{x},{y}] находится элемент со значением {array[x, y]}");
}
int[,] array = CreateMatrix(5, 5);
PrintArray(array);
PrintNumSearch(array);