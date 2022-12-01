int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int [] arrya = {11, 15, 16, 17, 85, 9, 5, 9, 7};


int max = Max(
    Max(arrya[0], arrya[1], arrya[2]),
    Max(arrya[3], arrya[4], arrya[5]),
    Max(arrya[6], arrya[7], arrya[8])
    
);

Console.WriteLine(max);