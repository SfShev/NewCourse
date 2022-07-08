Console.Write("Хотите создать массив? Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
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

}

Collection(arraysize);
PrintCollection();
System.Console.WriteLine("\b \b");