# SparePartsInventoryAssistant

This program asks the user which spare part they need and checks if it is available in the inventory. The parts list is stored in an array (hydraulic pump, PLC module, servo motor).

* If the user types one of the parts exactly (case-sensitive), the program says it is available and ends.
* If the part is not found, the program says it is not available and asks again.
* If the user types a special question ("Do you actually have any parts?" or "Is there anything in stock at all?"), the program shows how many parts are in stock and lists them all.

The program uses branching (if/else), loops (while, foreach), arrays, and string interpolation to practice basic C# skills.
