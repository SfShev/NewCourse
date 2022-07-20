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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] Matrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                Matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            
        }
    }

    return Matrix;
}

int[,] firstmtrx = GetMatrix(rows, colums, min, max);
Console.WriteLine("Первая матрица для умножения\n");
ShowMatrix(firstmtrx);
Console.WriteLine();
int[,] secondmtrx = GetMatrix(rows, colums, min, max);
Console.WriteLine("Вторая матрица матрица для умножения\n");
ShowMatrix(secondmtrx);
Console.WriteLine();
int[,] resultmtrx = MatrixMultiplication(firstmtrx,secondmtrx);
Console.WriteLine("Результат умножения двух матриц\n");
ShowMatrix(resultmtrx);