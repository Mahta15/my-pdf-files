List<string> phoneNumbers = new List<string>();

Console.WriteLine("What's your name?");
string a = Console.ReadLine();

Console.WriteLine("Enter your mobile phone number:");
string b = Console.ReadLine();
phoneNumbers.Add(b);

Console.WriteLine("Enter your home phone number:");
string c = Console.ReadLine();
phoneNumbers.Add(c);

Console.WriteLine("Enter your father's mobile phone number:");
string d = Console.ReadLine();
phoneNumbers.Add(d);

Console.WriteLine("Enter your mother's mobile phone number:");
string e = Console.ReadLine();
phoneNumbers.Add(e);

Console.WriteLine("Enter your emergency mobile phone number:");
string f = Console.ReadLine();
phoneNumbers.Add(f);

Console.WriteLine("Valid numbers:");
foreach (string s in phoneNumbers)
{
    if (s.Length == 11 && s[0] == '0')
    {
        bool differentDigit = false;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != s[0])
            {
                differentDigit = true;
                break;
            }
        }

        if (differentDigit)
        {
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine($"{s} is invalid: All digits are the same.");
        }
    }
    else
    {
        Console.WriteLine($"{s} is invalid: Must be 11 digits and start with 0.");
    }
}
Console.WriteLine($"Hello {a}.  your information that you entered is :\n Home phone number: {c}\n Your mobile phone number: {b}\n Father's mobile phone number: {d}\n Mother's mobile phone number: {e}\n Emergency mobile phone number: {f}");
