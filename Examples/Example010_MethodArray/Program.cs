int[] array = {1,12,53,24,52,6,47,18,24};

int n = array.Length;
int find = 24;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}