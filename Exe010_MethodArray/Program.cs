﻿int[] array = {1, 2, 3, 4, 3, 6, 7, 8, 9};

int n = array.Length;

int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
