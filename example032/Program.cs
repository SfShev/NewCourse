Console.Write("Хотите создать массив? Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
int sum = 0;
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

int SumOfNumbersInOddPositions(int[] array)
{

    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void ShowSumm()
{
    Console.WriteLine($"Сумма чисел,стоящих на нечетных позициях = {sum}");
}


Collection(arraysize);
PrintCollection();
SumOfNumbersInOddPositions(collection);
ShowSumm();
