//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[,] CreateMatrix(int rows, int columns)
{
    double[,] answer = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(-10, 10)/rnd.NextDouble();
        }
    }
    return answer;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:0.#} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = Prompt("Введите колличество строк = ");
int columns = Prompt("Введите колличество столбцов =");
PrintArray(CreateMatrix(rows, columns));
