int[] array = {22,1,2,4,14,12,5,6,7,12,41};

int n = array.Length;
int find = 12;

int index = 0;

while( index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine("found number index = " + index);
        break;
    }
    index++;
}
