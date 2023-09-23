int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1=5, b1=9, c1=10;
int a2=19, b2=15, c2=4;
int a3=2, b3=9, c3=100;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
    );

Console.WriteLine(max);