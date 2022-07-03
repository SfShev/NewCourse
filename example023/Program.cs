int GetSum(int a)
{
    int sum = 0;

    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }

    return sum;
}

Console.WriteLine("введите число");
int num = int.Parse (Console.ReadLine()!);
Console.WriteLine (GetSum(num));