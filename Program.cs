int[] num = {1,2,3,4,5,6,345,432,24,341};
int left = 0;
int n = 3;
int right = num.Length - 1;
while (left <= right)
{
    int middle = (left + right) / 2;
    if (num[middle] == n)
    {
        Console.WriteLine("Axteardiginiz eded tapildi");
        break;
    }
    else if(num[middle] > n)
    {
        right = middle - 1;
    }
    else
    {
        left = middle+1;
    }
}