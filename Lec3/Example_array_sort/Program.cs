﻿int[] arr = { 6, 8, 3, 4, 1, 4, 5, 7, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPos])  MinPos = j;
        }

        int temp = array[i];
        array[i] = array[MinPos];
        array[MinPos] = temp;

    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
