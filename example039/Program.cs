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

void SwapLinesInMatrix(int[,] matrix,int row1,int row2)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[row1, i];
        matrix[row1, i] = matrix[row2, i];
        matrix[row2, i] = temp;
    }
}

int [,] mtrx = GetMatrix(rows,colums,min,max);
ShowMatrix(mtrx);
SwapLinesInMatrix(mtrx,0,mtrx.GetLength(0)-1);
Console.WriteLine();
ShowMatrix(mtrx);