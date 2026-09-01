/*
 * Student ID : 1690705122
 * Name       : ต่อศักดิ์ โรจนกรินทร์
 * Section    : 129c
 * No.        : na
 * Course     : GI113 Computer Programming (GI)
 */
namespace leb_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName} " +
                $"\nRank: {rank} " +
                $"\nLevel: {level} / {MaxLevel} " +
                $"\nHP: {currentHp} / {maxHp} " +
                $"\nAttack Power: {attackPower} " +
                $"\nCrit Multiplier: {critMultiplier} " +
                $"\nIs Boss: {isBoss}");
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"\nHP (double): {currentHpDouble}");
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"\nHP Percent (exact): {hpPercentExact}%");
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"\nAttack Power (int cast): {attackDisplay}");
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"\nCrit Multiplier (int cast): {critCast}");
            Console.WriteLine($"\nCrit Multiplier (Convert rounded): {critConvert}");

        }
    }
}