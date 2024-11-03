

using System.Numerics;

BigInteger a1 = 1;
BigInteger a2 = 1;
BigInteger ai = 0;
BigInteger n;
Console.WriteLine("enter n:");
n = Convert.ToInt64(Console.ReadLine());


while (n > ai && n != 0)
{
    ai = a2 + a1;

    if (n == a1 || n == a2 || n == ai)
        n = 0;

    a1 = a2;
    a2 = ai;

    Console.Write(ai + "  ");

}

Console.WriteLine();
Console.WriteLine("n is " +
    (n == 0 ? "" : "not ")
     );

