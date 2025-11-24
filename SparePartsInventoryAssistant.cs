using System;

class Program
{
    static void Main()
    {
        // parts in inventory
        string part1 = "hydraulic pump";
        string part2 = "PLC module";
        string part3 = "servo motor";

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        bool partAvailable = false;

        while (!partAvailable)
        {
            Console.Write("Which part do you need? ");
            var line = Console.ReadLine();

            if (line == part1 || line == part2 || line == part3)
            {
                Console.WriteLine($"I've got {line} here for you 😊 . Bye!");
                partAvailable = true;
            }
            else if (line == "Do you actually have any parts?" ||
                     line == "Is there anything in stock at all?")
            {
                Console.WriteLine($"We have 3 part(s)!");
                Console.WriteLine(part1);
                Console.WriteLine(part2);
                Console.WriteLine(part3);
            }
            else
            {
                Console.WriteLine($"I am afraid we don't have any {line} in the inventory 😔");
            }
        }
    }
}

