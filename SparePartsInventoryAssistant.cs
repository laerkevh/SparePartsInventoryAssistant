using System;

namespace SparePartsInventoryAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Arrays ---
            // Inventory parts must match EXACT names (case-sensitive), per the activity spec.
            string[] inventory = { "hydraulic pump", "PLC module", "servo motor" };

            // --- Strings & string interpolation ---
            Console.WriteLine("Hej. Welcome to the spare parts inventory!");

            // --- Looping: while ---
            // Keep asking until the assistant affirms a part is available.
            while (true)
            {
                Console.Write("Which part do you need? ");
                string? raw = Console.ReadLine();
                string input = (raw ?? string.Empty).Trim();

                // --- Branching ---
                if (IsAnyPartsQuery(input))
                {
                    // Special queries (case-insensitive):
                    //   "Do you actually have any parts?"
                    //   "Is there anything in stock at all?"
                    Console.WriteLine($"We have {inventory.Length} part(s)!");
                    // --- Looping: foreach ---
                    foreach (var part in inventory)
                    {
                        Console.WriteLine(part);
                    }
                    continue; // keep the conversation going
                }

                // Exact, case-sensitive match against the inventory list
                if (Array.Exists(inventory, p => p == input))
                {
                    Console.WriteLine($"I've got {input} here for you 😊");
                    break; // program exits only after confirming availability
                }
                else
                {
                    Console.WriteLine($"I am afraid we don't have any {input} in the inventory 😔");
                }
            }
        }

        // --- Strings + branching helper ---
        private static bool IsAnyPartsQuery(string s)
        {
            // Treat the two special queries in a case-insensitive way to be user-friendly,
            // while keeping part-name matching strict (case-sensitive) per the activity.
            return s.Equals("Do you actually have any parts?", StringComparison.OrdinalIgnoreCase)
                || s.Equals("Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase);
        }
    }
}
