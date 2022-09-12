namespace PasswordGenerator
{
    class Program
    {
        static void Main()
        {
            long length;
            string? action;

            while (true)
            {
                Console.WriteLine("Actions\n1 - generate password\n0 - quit");
                Console.Write("Action: ");
                action =  Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.Write("Password length: ");
                        length = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine(PasswordGenerator.Generate((int)length));

                        continue;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter an action.");
                        break;
                    }
            }
        }
    }
}