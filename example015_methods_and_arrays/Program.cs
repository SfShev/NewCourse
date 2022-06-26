int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a = 11;
int b = 12;
int c = 13;
int a1 = 21;
int b1 = 22;
int c1 = 23;
int a2 = 2231;
int b2 = 32;
int c2 = 33;


int max = Max(Max(a, b, c),
          Max(a1, b1, c1),
          Max(a2, b2, c2));

Console.WriteLine(max);