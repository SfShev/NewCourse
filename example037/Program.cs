Console.WriteLine("Введите параметры матрицы");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон чисел матрицы");
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double result = 0;



double[,] GetMatrix(int rowsMtrx, int columsMtrx, int minNum, int maxNum)
{
    double[,] matrix = new double[rows, colums];
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1) + random.NextDouble();
        }
    }
    return matrix;
}

void ShowMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write($" {Math.Round(matrix[i, j], 1),4}|");
        }
        Console.WriteLine();
    }
}

double CheckMatrix(double[,] matrix)
{
    Console.WriteLine("Введите позицию числа,которое вы ищите");
    Console.Write("Введите строку: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите столбец: ");
    int colum = Convert.ToInt32(Console.ReadLine()) - 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == colum)
            {
                result = matrix[i, j];
            }
        }

    }
    return result;
}

void ShowResult(double resultofcheckingmatrix)
{
    if (resultofcheckingmatrix == 0)
    {
        Console.WriteLine("Такого числа в массиве нет!");
    }
    else
    {
        Console.WriteLine($"Число которое вы ищете: {Math.Round(resultofcheckingmatrix, 1)}");
    }
}

double[,] mtrx = GetMatrix(rows, colums, min, max);
ShowMatrix(mtrx);
CheckMatrix(mtrx);
ShowResult(result);