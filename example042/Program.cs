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


int[,] GetMatrix(int rows, int colums, int min, int max)
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
            Console.Write($" {matrix[i, j],1}|");
        }
        Console.WriteLine();
    }
}

void FindMinElement(int[,] matrix, ref int indexI, ref int indexJ)
{
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
}

int[,] DeleteRowAndColumInMatrix(int[,] matrix, int indexI, int indexJ)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int offsetI = 0;
    int offsetJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexI) offsetI++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == indexJ) offsetJ++;
            resultMatrix[i, j] = matrix[i + offsetI, j + offsetJ];
        }
        offsetI = 0;
        offsetJ = 0;
    }


    return resultMatrix;
}


int[,] mtrx = GetMatrix(rows, colums, min, max);

ShowMatrix(mtrx);
Console.WriteLine();
int minI = 0;
int minJ = 0;
FindMinElement(mtrx, ref minI, ref minJ);
Console.WriteLine($"Строка: {minI + 1} Столбец: {minJ + 1}");

ShowMatrix(DeleteRowAndColumInMatrix(mtrx, minI, minJ));