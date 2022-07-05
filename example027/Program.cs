int [] Collection (int elements)
{
int[] collection = new int[elements];
Console.WriteLine("Заполните массив: ");

for (int i = 0; i < collection.Length; i++)
{
    Console.WriteLine();
    Console.Write($"Введите элемент массива {i}: "  );
    collection[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Ваш массив: ");

for (int i = 0; i < collection.Length; i++)
{
    Console.Write($"{collection[i]},");
}
return collection;
}

Console.Write("Хотите создать массив? Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine()); 


Collection(arraysize);