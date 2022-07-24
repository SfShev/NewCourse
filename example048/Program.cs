int SumNum(int m, int n)
{
    int sum =0;
    if (m > n) return 0;
    else return sum += n + SumNum(m, n - 1);
}
System.Console.WriteLine(SumNum(1, 8));