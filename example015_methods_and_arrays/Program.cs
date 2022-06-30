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



int Max1(int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int[] array = { 156, 22, 3993, 47, 56, 64, 37, 82, 29 };



int max1 = Max1(
    Max1(array[0], array[1], array[2]),
    Max1(array[3], array[4], array[5]),
    Max1(array[6], array[7], array[8]));

Console.WriteLine(max1);