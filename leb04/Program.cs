namespace leb04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          Item Shop           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("How many potions?");
            bool quantityOK = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOK}");
            Console.WriteLine($"quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          Set Volume           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Set music volume (0.0-1.0)");
            bool volumeOK = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOK}");
            Console.WriteLine($"volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          New Save File           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Enter save name");
            string saveName = Console.ReadLine();
            Console.WriteLine("Choose save slot (1-3)");
            bool slotOK = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOK}");
            Console.WriteLine($"Slot: {slot}");
            */

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          Item Shop           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("How many potions?");
            bool quantityOK = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOK}");
            Console.WriteLine($"quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          Set Volume           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Set music volume (0.0-1.0)");
            bool volumeOK = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOK}");
            Console.WriteLine($"volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          New Save File           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Enter save name");
            string saveName = Console.ReadLine();
            Console.WriteLine("Choose save slot (1-3)");
            bool slotOK = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOK}");
            Console.WriteLine($"Slot: {slot}");


        }
    }
}
