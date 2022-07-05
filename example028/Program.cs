int[] Collection(int elements)
{
    int[] collection = new int[elements];
    Console.WriteLine("Заполните массив: ");

    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите элемент массива {i}: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    return collection;
}


void PrintCollection(int[] collection)
{
    Console.WriteLine();
    Console.WriteLine("Ваш массив: ");

    foreach (var item in collection)
    {
        Console.Write(item + ",");
    }

}

Console.Write("Хотите создать массив? Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());


PrintCollection(Collection(arraysize));