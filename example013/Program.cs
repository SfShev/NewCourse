Console.WriteLine("Если хотите узнать четное это число или нет");
Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 %2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
