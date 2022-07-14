int[,] coefficient = new int[2, 2];
int[] coordinate = new int[2];
Console.WriteLine("Хотите узнать точку пересечения двух прямых?");
void InputValueOfTheEquation()
{
    for (int i = 0; i < coefficient.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значения {i + 1}-го уравнения ");
        for (int j = 0; j < coefficient.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            coefficient[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
int[] FindingCoordinates(int[,] coordates)
{
    coordinate[0] = (coefficient[1, 1] - coefficient[0, 1]) / (coefficient[0, 0] - coefficient[1, 0]);
    coordinate[1] =  coefficient[0, 0] * coordinate[0] + coefficient[0, 1];
    return coordinate;
}
void Response(int[,] coordates)
{
    if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] != coefficient[1, 1])
    {
        Console.Write("Прямые параллельны");
    }
    else if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] == coefficient[1, 1])
    {
        Console.Write("Прямые совпадают");
    }
    else
    {
        FindingCoordinates(coefficient);
        Console.Write($"Точка пересечения прямых: ({coordinate[0]}, {coordinate[1]})");
    }
}
InputValueOfTheEquation();
Response(coefficient);