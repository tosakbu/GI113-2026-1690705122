namespace leb05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Game title , Sub-title
            Console.WriteLine("===My Game Dee===");
            Console.WriteLine("Hero vs Monster, Fight damage calulator\n");

            // Hero stats input HP ATK DEF
            Console.WriteLine("Hero Health");
            bool heroHPOK = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack");
            bool heroATKOK = int.TryParse(Console.ReadLine(), out int heroATK);
            Console.WriteLine("Hero Defence");
            bool heroDefenceOK = int.TryParse(Console.ReadLine(), out int heroDEF);

            // Monster stats input
            Console.WriteLine("Monster Health");
            bool monsterHealthOK = int.TryParse(Console.ReadLine(), out int monsterHP);
            Console.WriteLine("Monster Attack");
            bool monsterAttackOK = int.TryParse(Console.ReadLine(), out int monsterATK);
            Console.WriteLine("Monster Defence");
            bool monsterDefenceOK = int.TryParse(Console.ReadLine(), out int monsterDEF);

            //Input validation
            bool isHeroIntValid = heroHPOK && heroATKOK && heroDefenceOK;
            bool isMonsterIntValid = monsterHealthOK && monsterAttackOK && monsterDefenceOK;
            Console.WriteLine($"\nHero Status Valid {isHeroIntValid}");
            Console.WriteLine($"Monster Status Valid {isMonsterIntValid}");

            Console.WriteLine($"[Hero]     HP: {heroHp} , ATK: {heroATK}, DEF: {heroDEF}");
            Console.WriteLine($"[Monster]  HP: {monsterHP} , ATK: {monsterATK} , DEF: {monsterDEF}");


            //bool allIntValid = !isHeroIntValid && isMonsterIntValid; // ถ้าเอาแค่ชื่อ bool มาเช็ก คือ เช็กว่าเป็นจริงไหม แต่ถ้าใส่! ด้านหน้าคือตรงข้าม (true -> false)

            // Compound assignment : += จำลองสถานการณ์ก่อนผู้เล่นดื้ม Potion ก่อนต่อสู้
            int PotionHeal = 8;
            //heroHp = heroHp + PotionHeal;  //แบบยาว
            heroHp += PotionHeal;          //แบบสั่น
            Console.WriteLine($"\nHero drinks a potion." +
                $" healing {PotionHeal} HP." +
                $" hero HP now {heroHp}.");

            // Arithmetic + การโจมตี
            int normalDmg = Math.Max(0, heroATK - monsterDEF);  // ความแรงการโจมตีขึ้นอยู่กับการป้องกันของศัตรู
            Console.WriteLine($"\nNormal Attack would deal: {normalDmg} Dmg");

            // Precedence การโจมตีพิเศษ
            int powerDmg = Math.Max(0, (heroATK * 2) - monsterDEF);  // โจมตีคูณ 2
            Console.WriteLine($"Power Attack would deal: {powerDmg} Dmg");
             
            // Random , Simple percent chance. Critical chance.
            Random rngCrit = new Random();
            int roll = rngCrit.Next(1, 100 + 1);  // ต้องบวก 1 ค่ามากสุดเสมอ เช่นอยากได้ 100ต้องใส่ 101
            bool isCrit = roll <= 10; // 10% Chance จาก 100
            int CritDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; // bool 1-0 
            Console.WriteLine($"Critical hit roll: {roll} (critical): {isCrit}");
            Console.WriteLine($"If critical normal Attack would instead deal: {CritDmg}");




        }
    }
}
