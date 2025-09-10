using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VariableHUD_Zander
{
    internal class Program
    {
        static string playerName = "Dave";
        static string gameName = "Totally real text based game!";
        static string gameStudio = "Totally real game studio";
        static float health = 100f;
        static int defense = 10;
        static int money = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.WriteLine("Press any button to begin!");
            Console.ReadKey();
            Console.Clear();

            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"You are {playerName}, an adventerer preparing to head to the EVIL FOREST");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            TakeDamage(23);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"The second {playerName} stepped foot into the EVIL FOREST he was attacked by a wild goblin!!");
            Console.WriteLine($"{playerName} took 23 damage");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            AddMoney(10);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} swung at the goblin and defeated him! As {playerName} celebrated he noticed something shiny in the goblins pocket");
            Console.WriteLine($"{playerName} Earned 10 gold coins");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();

            TakeDamage(-2.5f);
            defense -= 10;
            AddMoney(-5);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"As {playerName} was resting, someone stole his shield and money! Luckily {playerName} had half his gold in his pocket");
            Console.WriteLine($"{playerName} didnt sleep much, he barely healed");
            Console.WriteLine($"{playerName} lost all defense and half his gold");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();

            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} followed the footsteps to get back his shield and gold, but on his way {playerName} came across a cave");
            Console.WriteLine($"Curiosity got the better of {playerName}, he went into the cave without caution!");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            TakeDamage(50);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"Before {playerName} could react he was attacked by a giant monster!");
            Console.WriteLine($"{playerName} lost a lot of health!");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            TakeDamage(-40);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} managed to get a lucky swing on the monster, defeating him");
            Console.WriteLine($"{playerName} found a health potion in the cave!");
            Console.WriteLine($"{playerName} gained 40 health!");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            TakeDamage(100);
            ShowHUD();
            Console.WriteLine(" ");
            Console.WriteLine("Turns out that health potion was poison...");
            Console.WriteLine($"{playerName} is DEAD");
            Console.WriteLine("GAME OVER");
            Console.WriteLine(" ");

        }

        static void ShowHUD()
        {
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.WriteLine(" ");
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,13}{2,10}{3,10}", playerName, health, defense, money);
        }

        static float TakeDamage(float damage)
        {
            return health -= damage;
        }

        static int AddMoney(int loot)
        {
            return money += loot;
        }
    }
}
