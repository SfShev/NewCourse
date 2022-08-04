Console.Write("Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
string[] mainarray = new string[arraysize];
string[] resultarray = new string[arraysize];
int j = 0;
Console.WriteLine("Заполните массив: ");


string[] Collection(int elements)
{
    for (int i = 0; i < elements; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите элемент массива # {i + 1}: ");
        mainarray[i] = Console.ReadLine()!;
    }
    return mainarray;
}


string[] NewCollection(string[] array, string[] newarray)
{

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    
    return newarray;
}
void PrintArrays()
{
    Console.WriteLine();
    Console.Write("Главный массив: ");
    foreach (var item in mainarray)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine();
    Console.Write("Новый массив: ");
    foreach (var item in resultarray)
    {
        Console.Write(item + " ");
    }
}

Collection(arraysize);
NewCollection(mainarray, resultarray);
PrintArrays();