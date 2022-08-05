﻿Console.Write("Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите наибольшее количество символов строк,которые хотите увидеть: ");
int numberofcharacters = Convert.ToInt32(Console.ReadLine());

string[] mainarray = new string[arraysize];
string[] resultarray = new string[arraysize];


string[] Collection(int elements)
{
    Console.WriteLine("Заполните массив: ");
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
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= numberofcharacters)
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
        Console.Write(item + ",");
    }
    Console.WriteLine("\b \b");

    Console.WriteLine();
    Console.Write("Новый массив: ");

    resultarray = resultarray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

    foreach (var item in resultarray)
    {
        Console.Write(item + ",");
    }
    Console.WriteLine("\b \b");


}

Collection(arraysize);
NewCollection(mainarray, resultarray);
PrintArrays();