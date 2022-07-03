Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


int ProductNumber(int num)
{
    int product = 1;
    for (int i = 2; i <= num; i++)
    {
        product *= i;
    }
    return product;
}
Console.WriteLine(ProductNumber(num));