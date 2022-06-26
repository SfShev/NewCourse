Console.WriteLine("Введите номер дня недели");

int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер дня: " + day );

switch (day)
{
    case 1: Console.WriteLine("Нет, будний день"); break;
    case 2: Console.WriteLine("Нет, будний день"); break;
    case 3: Console.WriteLine("Нет, будний день"); break;
    case 4: Console.WriteLine("Нет, будний день"); break;
    case 5: Console.WriteLine("Нет, будний день"); break;
    case 6: Console.WriteLine("Да,выходной"); break;
    case 7: Console.WriteLine("Да,выходной"); break;
    default: Console.WriteLine("Неверный ввод"); break;
}
