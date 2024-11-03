//mirror number
int n;
int m;
Console.WriteLine("enter n :");
 n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter m :");
 m = Convert.ToInt32(Console.ReadLine());
if(n>m)
{
    int temp = n;
    n = m; m = temp;
}
for (int i = n + 1; i <= m; i++)
{
    string StrI = i.ToString();
    string reversedStr = new string(StrI.Reverse().ToArray());
    if (StrI == reversedStr)
    {
        Console.WriteLine(i);
    }
}


Console.ReadKey();
