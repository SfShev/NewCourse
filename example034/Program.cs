Console.Write("Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
int positivenumber = 0;
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

int SarchPositiveNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positivenumber = positivenumber + 1;
        }
    }
    return positivenumber;
}

void ShowEvens()
{
    Console.WriteLine("Количество положительных чисел в массиве: ");
    Console.WriteLine(positivenumber);
}

Collection(arraysize);
PrintCollection();
SarchPositiveNumber(collection);
ShowEvens();