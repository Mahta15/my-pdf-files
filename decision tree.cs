Console.WriteLine("Do you like movie?(yes/no)");
string a = Console.ReadLine();
if (a.ToLower()== "yes")
{
    Console.WriteLine("do you like iranian movie?");
    string b = Console.ReadLine();
    if (b.ToLower() == "yes")
    {
        Console.WriteLine("do you like drama movie?");
        string c = Console.ReadLine();
        if (c.ToLower() == "yes")
        {
            Console.WriteLine("movie:  A Separation");
        }
        else if (c.ToLower() == "no")
        {
            Console.WriteLine("movie: About Elly");
        }
    }
    else if (b.ToLower() =="no")
    {
        Console.WriteLine("do you like drama movie?");
        string d = Console.ReadLine();
        if (d.ToLower() == "yes")
        {
            Console.WriteLine("movie: The Shawshank Redemption");
        }
        else if (d.ToLower() == "no")
        {
            Console.WriteLine("movie: Inception");
        }
    }
}
else if (a.ToLower() == "no")
{
    Console.WriteLine("do you like music?");
    string b = Console.ReadLine();
    if (b.ToLower() == "yes")
    {
        Console.WriteLine("do you like iranian music ?");
         string c = Console.ReadLine();
        if(c.ToLower() == "yes")
        {
            Console.WriteLine("music: EY JAAN EY JAAN");
        }
        else if(c.ToLower() == "no")
        {
            Console.WriteLine("music : baby calm down");
        }
    }
    else if (b.ToLower() == "no")
    {
        Console.WriteLine("you are not cool.");
    }
}
