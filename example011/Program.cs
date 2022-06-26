
{
    Console.WriteLine("Если хотите узнать какое число больше,а какое меньше");
    Console.WriteLine("Введите 2 числа");

    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
   

    if (number1 > number2)
    {
        Console.WriteLine("Число: " + number1 + " больше,а" + number2 + " меньше");
    }
    else
    {
        Console.WriteLine("Число: " + number2 + " больше, а " + number1 + " меньше");
    }
}