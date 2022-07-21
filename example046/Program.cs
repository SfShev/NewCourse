Console.WriteLine("Введите параметры трехмерного массива");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество слоев: ");
int layers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон чисел трехмерного массива");
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());




Console.WriteLine();

int[,,] Get3DArray(int rows, int colums, int layers, int min, int max)
{
    int[,,] array3d = new int[rows, colums, layers];
    var random = new Random();
    // int size = matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);
    
    
    int[] arr = new int[array3d.GetLength(0) * array3d.GetLength(1) * array3d.GetLength(2)];
    int num = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = random.Next(min,max);
        num = arr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = random.Next(min,max);
                    j = 0;
                    num = arr[i];
                }

                num= arr[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                // matrix[i, j, k] = random.Next(min, max + 1);
                // bool contains = false;
                // int next = random.Next(min, max + 1);
                // for (int n = 0; n < matrix.GetLength(1); n++)
                // {
                //     int a = matrix[i, j, k];
                //     if (a == next)
                //     {
                //         contains = true;
                //         break;
                //     }
                //     while (contains)
                //     {
                //         matrix[i,j,k]=next;
                //     }
                array3d[i,j,k] = arr[count];
                count ++;

            }

        }
    }

    return array3d;
}


void Show3DArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($" {array3d[i, j, k]},({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] threedimensionalarrayarray = Get3DArray(rows, colums, layers, min, max);
Console.WriteLine();
Show3DArray(threedimensionalarrayarray);
Console.WriteLine();