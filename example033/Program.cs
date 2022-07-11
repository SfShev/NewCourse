Console.Write("Хотите создать массив? Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
int difference = 0;
int[] collection = new int[arraysize];
Console.WriteLine("Заполните массив: ");


int[] Collection(int elements)
{
    for (int i = 0; i < elements; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите элемент массива # {i + 1}: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    return collection;
}

void PrintCollection()
{
    Console.WriteLine();
    Console.WriteLine("Ваш массив: ");

    foreach (var item in collection)
    {
        Console.Write(item + ",");
    }
    Console.WriteLine("\b \b");
}

int FindDifferenceBetweenMaxAndMinNumbers(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }

    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    difference = max - min;
    return difference;
}

void ShowDifferenceBetweenMaxAndMinNumbers()
{
    Console.WriteLine($"Разница между минимальным и максимальным числом = {difference}");
}

Collection(arraysize);
PrintCollection();
FindDifferenceBetweenMaxAndMinNumbers(collection);
ShowDifferenceBetweenMaxAndMinNumbers();