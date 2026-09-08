/*
 * Student ID : 1690705122
 * Name       : ต่อศักดิ์ โรจนกรินทร์
 * Section    : 129c
 * No.        : na
 * Course     : GI113 Computer Programming (GI)
 */
using static System.Net.Mime.MediaTypeNames;

namespace Leb02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"AttackPower: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();


            //Part B
            string Name1 = "Hino";
            int Hp1 = 40;
            int AttackPower1 = 40;
            float speed1 = 18.5f;
            bool num1 = true;

            string Name2 = "Nano";
            int Hp2 = 60;
            int AttackPower2 = 30;
            float speed2 = 30.2f;
            bool num2 = true;

            string Name3 = "Phone";
            int Hp3 = 80;
            int AttackPower3 = 45;
            float speed3 = 50.9f;
            bool num3 = true;

            string Name4 = "Coco";
            int Hp4 = 20;
            int AttackPower4 = 100;
            float speed4 = 20.2f;
            bool num4 = true;


            Console.WriteLine($"Name: {Name1}");
            Console.WriteLine($"Hp: {Hp1}");
            Console.WriteLine($"Speed: {speed1}");
            Console.WriteLine($"AttackPower: {AttackPower1}");
            Console.WriteLine($"IsHero {num1}");
            Console.WriteLine();
            Console.WriteLine($"Name: {Name2}");
            Console.WriteLine($"Hp: {Hp2}");
            Console.WriteLine($"Speed: {speed2}");
            Console.WriteLine($"AttackPower: {AttackPower2}");
            Console.WriteLine($"IsHero {num2}");
            Console.WriteLine();
            Console.WriteLine($"Name: {Name3}");
            Console.WriteLine($"Hp: {Hp3}");
            Console.WriteLine($"Speed: {speed3}");
            Console.WriteLine($"AttackPower: {AttackPower3}");
            Console.WriteLine($"IsHero {num3}");
            Console.WriteLine();
            Console.WriteLine($"Name: {Name4}");
            Console.WriteLine($"Hp: {Hp4}");
            Console.WriteLine($"Speed: {speed4}");
            Console.WriteLine($"AttackPower: {AttackPower4}");
            Console.WriteLine($"IsHero {num4}");
            Console.WriteLine();
            Console.WriteLine("===== Hero1 VS Hero3 =====");
            Console.WriteLine($"Name: {Name1} VS {Name3}");
            Console.WriteLine();
            int HPAttack = Hp3 - AttackPower1;
            Console.WriteLine($"{Name1} Attack {AttackPower1} to {Name3}");
            Console.WriteLine($"{Name3} Hp: {HPAttack}");
            int HPAttackback = Hp1 - AttackPower3;
            Console.WriteLine($"{Name3} Attack {AttackPower3} to {Name1}");
            Console.WriteLine($"{Name1} Hp: {HPAttackback}");
            Console.WriteLine($"Name Win: {Name3}");
            Console.WriteLine();
            Console.WriteLine("===== Hero2 VS Hero4 =====");
            Console.WriteLine($"Name: {Name2} VS {Name4}");
            Console.WriteLine();
            int HPAttack1 = Hp4 - AttackPower2;
            Console.WriteLine($"{Name2} Attack {AttackPower2} to {Name4}");
            Console.WriteLine($"{Name4} Hp: {HPAttack1}");
            Console.WriteLine($"Name Win: {Name2}");
            Console.WriteLine("===== Last round Hero2 VS Hero3 =====");
            int HPAttacklast = Hp3 - AttackPower2;
            Console.WriteLine($"{Name2} Attack {AttackPower2} to {Name3}");
            Console.WriteLine($"{Name3} Hp: {HPAttacklast}");
            int HPAttacklast1 = Hp2 - AttackPower3;
            Console.WriteLine($"{Name3} Attack {AttackPower3} to {Name2}");
            Console.WriteLine($"{Name2} Hp: {HPAttacklast}");
            int HPAttacklast3 = HPAttacklast - AttackPower2;
            Console.WriteLine($"{Name2} Attack {AttackPower2} to {Name3}");
            Console.WriteLine($"{Name3} Hp: {HPAttacklast3}");
            int HPAttacklast4 = HPAttacklast1 - AttackPower3;
            Console.WriteLine($"{Name3} Attack {AttackPower3} to {Name2}");
            Console.WriteLine($"{Name2} Hp: {HPAttacklast4}");
            Console.WriteLine($"===== Winner is {Name3} =====");


        }
    }
}
