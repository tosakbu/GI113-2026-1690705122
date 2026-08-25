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

        }
    }
}
