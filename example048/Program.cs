Console.WriteLine("Задайте начало и конец промежутка,в котором вы хотите унать сумму чисел");
Console.Write("Задайте число начала счета: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число конца счета: ");
int over = Convert.ToInt32(Console.ReadLine());


int SumNum(int start, int over)
{
    int sum =0;
    if (start > over) return 0;
    else return sum += over + SumNum(start, over - 1);
}
Console.WriteLine($"Сумма чисел в промежутке от {start} до {over} = {SumNum(start, over)}");