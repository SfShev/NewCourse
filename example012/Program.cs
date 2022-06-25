Console.WriteLine("Если хотите узнать какое число больше из трех чисел");
Console.WriteLine("Введите 3 числа");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number1 > max)
    max = number1;

if (number2 > max)
    max = number2;
else max = number3;

Console.WriteLine("Число: " + max + " больше остальных");
