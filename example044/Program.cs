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
int[,] mtrx = GetMatrix(rows, colums, min, max);


Console.WriteLine();

int[,] GetMatrix(int rowsMtrx, int columsMtrx, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write($" {matrix[i, j],2}|");
        }
        Console.WriteLine();
    }
}

int LineSumm(int[,] matrix, int i)
{
    int summ = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summ += matrix[i, j];
    }
    return summ;
}

void ShowMinSummLine()
{
    int lineminsumm = 0;
    int summline = LineSumm(mtrx, 0);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int temp = LineSumm(mtrx, i);
        if (summline > temp)
        {
            summline = temp;
            lineminsumm = i;
        }
    }
    Console.WriteLine($"Минимальная сумма находится в строке {lineminsumm + 1} и равна:{summline}");
}


ShowMatrix(mtrx);
Console.WriteLine();
ShowMinSummLine();