Console.WriteLine("Введите размер матрицы (N*N)");
int size = Convert.ToInt32(Console.ReadLine());
int number = 1;
int[,] matrix = new int[size, size];


for (int j = 0; j < size; j++)
{
    for (int i = 0 + j; i <= size - 1 - j; i++)
    {
        matrix[0 + j, i] = number++;
    }
    number--;
    for (int i = 0 + j; i < size - 1 - j; i++)
    {
        matrix[i, size - 1 - j] = number++;
    }
    for (int i = size - 1 - j; i > 0 + j; i--)
    {
        matrix[size - 1 - j, i] = number++;
    }
    for (int i = size - 1 - j; i > 0 + j; i--)
    {
        matrix[i, 0 + j] = number++;
    }
}


void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write($" {matrix[i, j],3}|");
        }
        Console.WriteLine();
    }
}

ShowMatrix(matrix);

