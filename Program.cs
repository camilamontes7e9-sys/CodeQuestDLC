using System;
using System.Collections;
using System.Numerics;
using System.Text;
namespace CodeQuestDLC_;

public class Program
{
    static void Main()
    {
        //Menu options

        Console.OutputEncoding = Encoding.UTF8;
        const string MenuTitle = "===== MAIN MENU - CODEQUEST ✨​🕹️​⚔️​=====";
        const string MenuOption1 = "1. Train your wizard🧙";
        const string MenuOption2 = "2. Increase Level🎲🪄";
        const string MenuOption3 = "3. Loot the mine⛏️🪙";
        const string MenuOption4 = "4. Show inventory🎒​";
        const string MenuOption5 = "5. Buy items⭐👑";
        const string MenuOption6 = "6. Show attacks by LVL🏹🗡️";
        const string MenuOption7 = "7. Decode ancient Scroll🔍📜";
        const string MenuOptionExit = "0. Exit game";
        const string MenuChoose = "Choose an option (1-7) - (0) to exit: ";
        const string ErrorMessage = "Invalid input. Please enter a number between 0 and 7.";
        const string ExitMessage = "Exiting game...";

        //Training Wizard
        const string InsertNamePrompt = "Enter your wizard's name: ";
        const string RankA = "Raoden the Elantris";
        const string RankB = "Zyn the Bugged";
        const string RankC = "Arka Nullpointer";
        const string RankD = "Elarion of the flames";
        const string RankE = "ITB-Wizard the Grey";
        const string MsgA = "Repeat to the 2nd call.";
        const string MsgB = "You still confuse the rod with a spoon.";
        const string MsgC = "You are a Summoner of Magical Breezes.";
        const string MsgD = "Wow! You can summon dragons without burning down the lab!";
        const string MsgE = "You have reached the rank of Arcane Master!";
        const int TotalDaysTraining = 5;
        const int MaxHours = 25;
        const int MaxPower = 11;
        const int MinHours = 1;
        const int MinPower = 1;

        int input;
        Random random = new Random();

        //Increase LVL 
        const string EnterDungeonMsg = "You enter the dungeon and and you face various enemies...";
        const string RollDiceMsg = "Now you must roll a dice to defeat the enemy";

        //Loot the mine
        const string LootTheMineMsg = "You enter the mine and start collecting resources...";
        const string ErrorMsg = "Invalid input. Please enter two numbers between 0 and 4.";
        const string EnterInputLoot = "Enter two numbers between 0, 4 to loot";
        const string FirstX = "Enter the first cordenate x: ";
        const string SecondY = "Enter the second cordenate y: ";
        const int Attempts = 5;
        const int CoinChance = 50;
        int bits = 0;


        int wizardLevel = 0;
        string[,] hiddenMine = new string[,]
        {
            { "", "", "", "", ""},
            { "", "", "", "", ""},
            { "", "", "", "", ""},
            { "", "", "", "", ""},
            { "", "", "", "", ""}
        };
        for (int cy = 0; cy < hiddenMine.GetLength(0); cy++)
        {
            for (int cx = 0; cx < hiddenMine.GetLength(0); cx++)
            {
                int randomNum = random.Next(0, 101);
                if (randomNum >= CoinChance)
                {
                    hiddenMine[cy, cx] = "c";
                }
            }
        }

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuChoose);


            try
            {
                input = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMessage);
                input = -1;
            }
            catch (Exception)
            {
                Console.WriteLine(ErrorMessage);
                input = -1;
            }

            switch (input)
            {
                case 1: //Train your wizard

                    int totalPower = 0, totalHours = 0;
                    string? wizardName;
                    string wizardTitle;

                    Console.WriteLine(" ");
                    Console.Write(InsertNamePrompt);
                    wizardName = Console.ReadLine();
                    Console.WriteLine(" ");

                    for (int day = 1; day <= TotalDaysTraining; day++)
                    {
                        totalHours += random.Next(MinHours, MaxHours);
                        totalPower += random.Next(MinPower, MaxPower);

                        Console.WriteLine($"Day {day} -- {wizardName} has trained for a total of {totalHours} houra and gained {totalPower} power points");
                        Console.ReadKey();
                    }

                    if (totalPower < 20)
                    {
                        Console.WriteLine(MsgA);
                        wizardTitle = RankA;
                    }
                    else if (totalPower >= 20 && totalPower < 30)
                    {
                        Console.WriteLine(MsgB);
                        wizardTitle = RankB;
                    }
                    else if (totalPower >= 30 && totalPower < 35)
                    {
                        Console.WriteLine(MsgC);
                        wizardTitle = RankC;
                    }
                    else if (totalPower >= 35 && totalPower < 40)
                    {
                        Console.WriteLine(MsgD);
                        wizardTitle = RankD;
                    }
                    else
                    {
                        Console.WriteLine(MsgE);
                        wizardTitle = RankE;
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine($"Training complete!! {wizardName} has gained a total of {totalPower} points and earned the title of {wizardTitle}");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    break;
                case 2: //Increase LVL 

                    Console.WriteLine(" ");
                    Console.WriteLine(EnterDungeonMsg);

                    string[,] enemies = new string[,]
                    {
                        { "Wandering Skeleton 💀", " 3"},
                        { "Forest Goblin 👹", " 5"},
                        { "Green Slime 🟢", " 10"},
                        { "Ember Wolf 🐺", " 11"},
                        { "Giant Spider 🕷️", " 18"},
                        { "Iron Golem 🤖", " 15"},
                        { "Lost Necromancer 🧝‍", " 20"},
                        { "Ancient Dragon 🐉", " 50"}
                    };

                    int randomEnemy = random.Next(enemies.GetLength(0));
                    string enemyName = enemies[randomEnemy, 0];
                    int hp = Convert.ToInt32(enemies[randomEnemy, 1]);

                    Console.WriteLine($"{enemyName} with {hp} hp has appeared!");
                    Console.WriteLine(" ");

                    Console.WriteLine(RollDiceMsg);

                    const string Dice1 =
                        "      _ _ _ _ _ _ _ \r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |             |   /\r\n" +
                        "  |      o      |  /\r\n" +
                        "  |             | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";

                    const string Dice2 =
                        "      _ _ _ _ _ _ _ _\r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |         o   |   /\r\n" +
                        "  |             |  /\r\n" +
                        "  |  o          | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";
                    const string Dice3 =
                        "      _ _ _ _ _ _ _ _\r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |          o  |   /\r\n" +
                        "  |      o      |  /\r\n" +
                        "  |  o          | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";
                    const string Dice4 =
                        "      _ _ _ _ _ _ _ _\r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |  o      o   |   /\r\n" +
                        "  |             |  /\r\n" +
                        "  |  o      o   | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";
                    const string Dice5 =
                        "      _ _ _ _ _ _ _ _\r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |  o       o  |   /\r\n" +
                        "  |      o      |  /\r\n" +
                        "  |  o       o  | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";
                    const string Dice6 =
                        "      _ _ _ _ _ _ _ _\r\n" +
                        "     /             /|\r\n" +
                        "    /             / |\r\n" +
                        "   / _ _ _ _ _ _ /  |\r\n" +
                        "  |             |   |\r\n" +
                        "  |  o      o   |   /\r\n" +
                        "  |  o      o   |  /\r\n" +
                        "  |  o      o   | /\r\n" +
                        "  |             |/\r\n" +
                        "  '- - - - - - -'\r\n";

                    int rollDice = random.Next(1, 7);

                    Console.ReadKey();

                    while (hp > 0)
                    {

                        switch (rollDice)
                        {
                            case 1:
                                Console.WriteLine(Dice1);
                                break;
                            case 2:
                                Console.WriteLine(Dice2);
                                break;
                            case 3:
                                Console.WriteLine(Dice3);
                                break;
                            case 4:
                                Console.WriteLine(Dice4);
                                break;
                            case 5:
                                Console.WriteLine(Dice5);
                                break;
                            case 6:
                                Console.WriteLine(Dice6);
                                break;
                        }

                        hp -= rollDice;

                        if (hp > 0)
                        {
                            Console.WriteLine($"The {enemyName} has {hp} hp left. Press any key to roll again.");
                            Console.ReadKey();
                            rollDice = random.Next(1, 7);
                            Console.Beep();
                        }
                        else
                        {
                            Console.WriteLine($"You have defeated the {enemyName}!");
                        }
                        if (hp <= 0)
                        {
                            wizardLevel++;
                            Console.WriteLine($"You have now level up! Your level is {wizardLevel}✨");
                            Console.WriteLine(" ");
                        }

                    }
                    break;
                case 3: //Loot the mine

                    Console.WriteLine(" ");
                    Console.WriteLine(LootTheMineMsg);
                    string[,] mine = new string[,]
                    {
                        {"➖", "➖", "➖", "➖", "➖"},
                        {"➖", "➖", "➖", "➖", "➖"},
                        {"➖", "➖", "➖", "➖", "➖"},
                        {"➖", "➖", "➖", "➖", "➖"},
                        {"➖", "➖", "➖", "➖", "➖"}
                    };
                    
                    for (int i = 0; i < mine.GetLength(0); i++)
                    {
                        for (int j = 0; j < mine.GetLength(1); j++)
                        {
                            Console.Write(mine[i, j]);
                        }
                        Console.WriteLine();
                    }

                    for (int a = 0; a < Attempts; a++)
                    {
                        Console.WriteLine($"You have {Attempts -a} attempts and {bits} bits!");
                        Console.WriteLine(EnterInputLoot);

                        int x, y;

                        try
                        {
                            Console.WriteLine(FirstX);
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(SecondY);
                            y = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(ErrorMsg);
                            a--;
                            continue;

                        }

                        if (x < 0 || x >= mine.GetLength(1) || y < 0 || y >= mine.GetLength(0))
                        {
                            Console.WriteLine(ErrorMsg);
                            a--;
                            continue;
                        }

                        if (mine[y, x] != "➖")
                        {
                            Console.WriteLine("You already loot this spot...");
                            continue;
                        }
                        
                        if (hiddenMine[y, x] == "c")
                        {
                            mine[y, x] = "🪙";
                            hiddenMine[y, x] = "";
                            bits = random.Next(5, 51);
                            Console.WriteLine($"You have found a coin!");
                        }
                        else
                        {
                            mine[y, x] = "❌";
                        }

                        if(a == Attempts -1)
                        {
                            Console.WriteLine("You have no attempts left");
                        }
                        for (int i = 0; i < mine.GetLength(0); i++)
                        {
                            for (int j = 0; j < mine.GetLength(1); j++)
                            {
                                Console.Write(mine[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }

                        break;
                case 4: //Show inventory
                    break;
                case 5: //Buy items
                    break;
                case 6: //Show attacks by LVL
                    break;
                case 7: //Decode ancient Scroll
                    break;
                case 0:
                    Console.WriteLine(ExitMessage);
                    Console.ReadKey();
                    break;
            }
        } while (input != 0);

    }

}
