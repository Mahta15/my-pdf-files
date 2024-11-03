Console.Write("enter a number:");

string input = "";
ConsoleKeyInfo key;

do
{
    key = Console.ReadKey(true);
    if (char.IsDigit(key.KeyChar))
    {
        input += key.KeyChar;
        Console.Write(key.KeyChar);
    }
    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
    {
        input = input.Substring(0, input.Length - 1);
        Console.Write("\b \b");  
    }
} while (key.Key != ConsoleKey.Enter);

Console.WriteLine();

if (int.TryParse(input, out int x))
{
    Console.WriteLine(x + " is number");
}
else
{
    Console.WriteLine("input is not number");
}
