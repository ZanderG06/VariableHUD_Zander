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
        static void Main(string[] args)
        {
            string playerName = "Dave";
            string gameName = "Totally real text based game!";
            string gameStudio = "Totally real game studio";
            float health = 100f;
            int defense = 10;
            int money = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.WriteLine("Press any button to begin!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,14}{2,8}{3,12}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"You are {playerName}, an adventerer preparing to head to the EVIL FOREST");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            health -= 23;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,13}{2,9}{3,12}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"The second {playerName} stepped foot into the EVIL FOREST he was attacked by a wild goblin!!");
            Console.WriteLine($"{playerName} took 23 damage");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            money += 10;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,13}{2,9}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} swung at the goblin and defeated him! As {playerName} celebrated he noticed something shiny in the goblins pocket");
            Console.WriteLine($"{playerName} Earned 10 gold coins");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            health += 2.5f;
            defense -= 10;
            money /= 2;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,15}{2,6}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"As {playerName} was resting, someone stole his shield and money! Luckily {playerName} had half his gold in his pocket");
            Console.WriteLine($"{playerName} didnt sleep much, he barely healed");
            Console.WriteLine($"{playerName} lost all defense and half his gold");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,15}{2,6}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} followed the footsteps to get back his shield and gold, but on his way {playerName} came across a cave");
            Console.WriteLine($"Curiosity got the better of {playerName}, he went into the cave without caution!");
            Console.WriteLine("Press any button to continue");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            health /= 2;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,16}{2,5}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"Before {playerName} could react he was attacked by a giant monster!");
            Console.WriteLine($"{playerName} lost half his health!");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            health += 40;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,16}{2,5}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName} managed to get a lucky swing on the monster, defeating him");
            Console.WriteLine($"{playerName} found a health potion in the cave!");
            Console.WriteLine($"{playerName} gained 40 health!");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            health = 0;
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", "Player Name", "Health", "Defense", "Gold");
            Console.WriteLine("{0,0}{1,12}{2,9}{3,13}", playerName, health, defense, money);
            Console.WriteLine(" ");
            Console.WriteLine("Turns out that health potion was poison...");
            Console.WriteLine($"{playerName} is DEAD");
            Console.WriteLine("GAME OVER");
            Console.WriteLine(" ");
            Console.WriteLine(gameName);
            Console.WriteLine($"Created by {gameStudio}");
            Console.WriteLine(" ");
        }
    }
}
