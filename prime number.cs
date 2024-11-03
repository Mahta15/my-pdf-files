int n;
int m;
Console.WriteLine("enter n>1:");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter m>1:");
m = Convert.ToInt32(Console.ReadLine());
if (n > m)
{
    int temp = n;
    n = m; m = temp;
}
bool isprime = true;
for (int i = n + 1; i <= m; i++)
{
    for (int j = i - 1; j > 1; j--)
    {
        if (i == 1)
        {
            isprime = false;
        }
        if (i % j == 0)
            isprime = false;
    }
    if (isprime) Console.WriteLine(i);
    isprime = true;
}



