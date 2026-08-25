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
            int Hp1 = 200;
            int speed1 = 100;
            float AttackPower1 = 18.5f;
            bool name1 = true;

            string Name2 = "Nano";
            int Hp2 = 150;
            int speed2 = 80;
            float AttackPower2 = 30.2f;
            bool name2 = true;

            string Name3 = "Phone";
            int Hp3 = 300;
            int speed3 = 50;
            float AttackPower3 = 50.9f;
            bool name3 = true;

            string Name4 = "Coco";
            int Hp4 = 100;
            int speed4 = 200;
            float AttackPower4 = 20.2f;
            bool name4 = true;


            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"Hp: {Hp1}");
            Console.WriteLine($"Speed: {speed1}");
            Console.WriteLine($"AttackPower: {AttackPower1}");
            Console.WriteLine($"IsHero {name1}");
            Console.WriteLine();
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"Hp: {Hp2}");
            Console.WriteLine($"Speed: {speed2}");
            Console.WriteLine($"AttackPower: {AttackPower2}");
            Console.WriteLine($"IsHero {name2}");
            Console.WriteLine();
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"Hp: {Hp3}");
            Console.WriteLine($"Speed: {speed3}");
            Console.WriteLine($"AttackPower: {AttackPower3}");
            Console.WriteLine($"IsHero {name3}");
            Console.WriteLine();
            Console.WriteLine($"Name: {name4}");
            Console.WriteLine($"Hp: {Hp4}");
            Console.WriteLine($"Speed: {speed4}");
            Console.WriteLine($"AttackPower: {AttackPower4}");
            Console.WriteLine($"IsHero {name4}");
            Console.WriteLine();
            Console.WriteLine("===== Hero VS Hero =====");
            int HPPercentVs1 = Hp3 - AttackPower1 / 100;
            Console.WriteLine($"Name: {Name1} VS {Name3}");
            Console.WriteLine();
            Console.WriteLine($"{Name1} Attack {AttackPower1} to {Name3}");
            Console.WriteLine($"{Name3} Hp: {HPPercentVs1}");
            Console.WriteLine($"Name: {Name2} VS {Name4}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
