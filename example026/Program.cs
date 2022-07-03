int SumOfDigits(int Number)
{
    int remainder = 0;
    int summ = 0;
    for (; Number >= 1; summ += remainder)
    {
        remainder = Number % 10;
        Number = Number / 10;
    }
    for (; Number <= -1; summ += remainder)
    {
        remainder = Number % 10;
        Number = Number / 10;
    }
    return summ;
}
Console.Write("Введите число у которого хотите узнать сумму его цифр: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {SumOfDigits(num)} ");

/*
}
    int i = 0;
    int a = 0;
    while (Number >= 1)
    {
        a = Number % 10;
        Number = Number / 10;
        i = i + a ;
    }
    return i;
}
*/