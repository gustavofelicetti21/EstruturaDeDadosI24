int j=0;
int[] num = new int[50];

for (int i = 1; i<=100; i++) {
    if ((float)(i%2)==0)
    {
        num[j] = i;
        j++;
    }
}

foreach (int n in num)
{
    Console.WriteLine(n);
}