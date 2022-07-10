int SumNumbersParametric(int[] array, bool findPositiveNumbers = true)
{
    int sum = 0;
    foreach (int elem in array)
    {
        if (findPositiveNumbers)
        {
            sum += elem > 0 ? elem : 0;
        }
        else
        {
            sum += elem < 0 ? elem : 0;
        }
    }
    return sum;
}

int[] GetArray(int size, int minValue, int maxVelue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxVelue + 1);
    }
    Console.WriteLine(array);
    return array;
}

void PrintArray(int[] array)
{
Console.WriteLine(string.Join(",",array));
}


int[] array = GetArray(12, -9, 9);

PrintArray(array);
Console.WriteLine(SumNumbersParametric(array));
Console.WriteLine(SumNumbersParametric(array,false));