using System;
using System.Collections;
using System.Text;
namespace CodeQuestDLC_;

public class Program
{
    static void Main()
    {
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
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";
        const string ExitMessage = "Exiting game...";

        // Training Wizard
        const string InsertNamePrompt = "Enter your wizard's name: ";
        const string RankE = "Raoden the Elantris";
        const string RankD = "Zyn the Bugged";
        const string RankC = "Arka Nullpointer";
        const string RankB = "Elarion of the flames";
        const string RankA = "ITB-Wizard the Grey";
        const string MsgE = "Repeat to the 2nd call.";
        const string MsgD = "You still confuse the rod with a spoon.";
        const string MsgC = "You are a Summoner of Magical Breezes.";
        const string MsgB = "Wow! You can summon dragons without burning down the lab!";
        const string MsgA = "You have reached the rank of Arcane Master!";
        const int TotalDaysTraining = 5;
        const int MaxHoursPerDay = 25;
        const int MaxPowerPerDay = 11;
        const int MinHoursPerDay = 1;
        const int MinPowerPerDay = 1;

        int input;
        Random random = new Random();

        //Increase LVL 
        const string EnterDungeonMsg = "You enter the dungeon and and you face various enemies...";
        const string RollDiceMsg = "Now you must roll a dice to defeat the enemy";

        int wizardLevel = 0;

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
            Console.Write(MenuPrompt);


            try
            {
                input = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                input = -1;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
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

                        totalHours += random.Next(MinHoursPerDay, MaxHoursPerDay);
                        totalPower += random.Next(MinPowerPerDay, MaxPowerPerDay);

                        Console.WriteLine($"Day {day} -- {wizardName} has trained for a total of {totalHours} hours and gained {totalPower} power points");
                        Console.ReadKey();
                    }

                    if (totalPower < 20)
                    {
                        Console.WriteLine(MsgE);
                        wizardTitle = RankE;
                    }
                    else if (totalPower >= 20 && totalPower < 30)
                    {
                        Console.WriteLine(MsgD);
                        wizardTitle = RankD;
                    }
                    else if (totalPower >= 30 && totalPower < 35)
                    {
                        Console.WriteLine(MsgC);
                        wizardTitle = RankC;
                    }
                    else if (totalPower >= 35 && totalPower < 40)
                    {
                        Console.WriteLine(MsgB);
                        wizardTitle = RankB;
                    }
                    else
                    {
                        Console.WriteLine(MsgA);
                        wizardTitle = RankA;
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine($"Training complete! {wizardName} has achieved a total power of {totalPower} points and earned the title {wizardTitle}");
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
