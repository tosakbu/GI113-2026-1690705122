/*
 * Student ID : 1690705122
 * Name       : ต่อศักดิ์ โรจนกรินทร์
 * Section    : 129c
 * No.        : na
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Game Booty friend ============== ");
            Console.WriteLine("Name: ");
            String Charactername = Console.ReadLine();
            Console.WriteLine("Gender: ");
            String Charactergender = Console.ReadLine();
            Console.WriteLine("Height: ");
            bool isHeightValid = int.TryParse(Console.ReadLine(), out int Characterheight);
            Console.WriteLine("Weight:");
            bool isWeightValid = int.TryParse(Console.ReadLine(), out int Characterweight);
            Console.WriteLine("Color: ");
            String Charactercolor = Console.ReadLine();
            double Inventory = 10.0;
            const int Hp = 100;
            const int speed = 30;
            Console.WriteLine($" {Charactername} is a {Charactergender} \n height: {Characterheight} cm\n weight: {Characterweight} kg\n Color character: {Charactercolor}\n My inventory: {Inventory}\n HP: {Hp}\n Speed: {speed}");
            Console.WriteLine();

        
            var FriendName = "Max";     
            var Gender = "Male"; 
            const int friendHp = 100;
            const int friendSpeed = 30;
            int Height = 80;
            int Weight  = 120;
            var color = "Red";
            bool isPlayable = true;
            double FriendInventory = 10.0;

            Console.WriteLine(" Name Your Friend:");
            Console.WriteLine($"Hero Name   : {FriendName}");
            Console.WriteLine($"Gender      : {Gender}");
            Console.WriteLine($"HP          : {friendHp}");
            Console.WriteLine($"Speed       : {friendSpeed}");
            Console.WriteLine($"Height      : {Height}");
            Console.WriteLine($"Weight      : {Weight}");
            Console.WriteLine($"Color       : {color}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine($"Inventory   : {FriendInventory}");
            Console.WriteLine("==================================================");

            const string GameTitle = "Phantom Heist: City of Thieves";
            int item = 20;
            const string BossName = "Ghost";
            char BossSymbol = 'G';
            float attackPower = 17.50f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            int AttackPowerBoss = (int)attackPower;
            int CritMultiplierBoss = (int)critMultiplier;

            Console.WriteLine($"Game Title: {GameTitle}");
            Console.WriteLine($"In Map have {item} items" +
                $"\nBoss Name:              {BossName}" +
                $"\nBoss Symbol:            {BossSymbol}" +
                $"\nAttack Power:           {AttackPowerBoss}" +
                $"\nCritical Multiplier:    {CritMultiplierBoss}" +
                $"\nIs Boss:                {isBoss}");





        }
    }
}
