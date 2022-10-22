int[] array = {1, 12, 2,3,4,23,1,2,};
int n = array.Length;
int find =2;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        
        Console.WriteLine(index);
        break;
    }

    index++;
}

