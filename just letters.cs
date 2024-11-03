            Console.Write("enter just letters:");

            string input = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (char.IsLetter(key.KeyChar))
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
            Console.WriteLine(input + " are letters.");