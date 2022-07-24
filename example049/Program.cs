Console.WriteLine("Функция Аккермана");
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }

}

void PrintAckerman()
{
    Console.Write($"A({m},{n}) = {AckermanFunction(m, n)}");
}

PrintAckerman();