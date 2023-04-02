namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroHealthPower = new Dictionary<string, int>();
            Dictionary<string, int> heroManaPower = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = input[0];
                int healthPoints = int.Parse(input[1]);
                int manaPoints = int.Parse(input[2]);

                heroHealthPower[heroName] = healthPoints;
                heroManaPower[heroName] = manaPoints;
            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {

                string[] cmdType = commands.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmdActions = cmdType[0];
                string heroName = cmdType[1];

                if (cmdActions == "CastSpell")
                {
                    int manaNeeded = int.Parse(cmdType[2]);
                    string spellName = cmdType[3];

                    if (heroManaPower[heroName] >= manaNeeded)
                    {
                        heroManaPower[heroName] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroManaPower[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdActions == "TakeDamage")
                {
                    int heroDamage = int.Parse(cmdType[2]);
                    string attacker = cmdType[3];

                    heroHealthPower[heroName] -= heroDamage;

                    if (heroHealthPower[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {heroDamage} HP by {attacker} and now has {heroHealthPower[heroName]} HP left!");
                    }
                    else
                    {
                        heroHealthPower.Remove(heroName);
                        heroManaPower.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdActions == "Recharge")
                {
                    int amount = int.Parse(cmdType[2]);

                    if (heroManaPower[heroName] + amount > 200)
                    {
                        amount = 200 - heroManaPower[heroName];
                    }
                    heroManaPower[heroName] += amount;
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }

                else if (cmdActions == "Heal")
                {
                    int amount = int.Parse(cmdType[2]);

                    if (heroHealthPower[heroName] + amount > 100)
                    {
                        amount = 100 - heroHealthPower[heroName];
                    }
                    heroHealthPower[heroName] += amount;
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }


            }

            foreach (var hero in heroHealthPower)
            {
                string heroName = hero.Key;
                int hp = hero.Value;
                int mp = heroManaPower[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  MP: {mp}");
            }
        }
    }
}