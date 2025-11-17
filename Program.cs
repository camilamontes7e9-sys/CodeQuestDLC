using System;
using System.Text;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string InsertNamePrompt = "Enter your wizard's name: ";
        const string TrainingMsg = "Day {0} -> {1} has trained for a total of {2} hours and gained {3} power points.";
        const string TrainingCompleteMsg = "Training complete! {0} has achieved a total power of {1} points and earned the title '{2}'.";
        const string RankE = "Raoden el Elantrí";
        const string RankD = "Zyn el Buguejat";
        const string RankC = "Arka Nullpointer";
        const string RankB = "Elarion de les Brases";
        const string RankA = "ITB-Wizard el Gris";
        const int TotalDaysTraining = 5;
        const int MaxHoursPerDay = 25;
        const int MaxPowerPerDay = 11;
        const int MinHoursPerDay = 1;
        const int MinPowerPerDay = 1;
        const string ExitMessage = "Exiting game. Goodbye!";

        int op, totalPower = 0, totalHours = 0; ;
        string? wizardName, wizardTitle;

        Random random = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);


            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                op = -1;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                op = -1;
            }

            switch (op)
            {
                case 1: //Train your wizard
                    Console.Write(InsertNamePrompt);
                    wizardName = Console.ReadLine();

                    for (int day = 1; day <= TotalDaysTraining; day++)
                    {

                        totalHours += random.Next(MinHoursPerDay, MaxHoursPerDay);
                        totalPower += random.Next(MinPowerPerDay, MaxPowerPerDay);

                        Console.WriteLine(TrainingMsg, day, wizardName, totalHours, totalPower);

                    }

                    string finalMessage = "";
                    const string MsgE = "Repeteixes a 2a convocatòria.";
                    const string MsgD = "Encara confons la vareta amb una cullera.";
                    const string MsgC = "Ets un Invocador de Brises Màgiques.";
                    const string MsgB = "Uau! Pots invocar dracs sense cremar el laboratori!";
                    const string MsgA = "Has assolit el rang de Mestre dels Arcans!";

                    if (totalPower < 20)
                    {
                        finalMessage = MsgE;
                        wizardTitle = RankE;
                    }
                    else if (totalPower >= 20 && totalPower < 30)
                    {
                        finalMessage = MsgD;
                        wizardTitle = RankD;
                    }
                    else if (totalPower >= 30 && totalPower < 35)
                    {
                        finalMessage = MsgC;
                        wizardTitle = RankC;
                    }
                    else if (totalPower >= 35 && totalPower < 40)
                    {
                        finalMessage = MsgB;
                        wizardTitle = RankB;
                    }
                    else 
                    {
                        finalMessage = MsgA;
                        wizardTitle = RankA;
                    }

                    Console.WriteLine(finalMessage);
                    Console.WriteLine(TrainingCompleteMsg, wizardName, totalPower, wizardTitle);

                    break;
                case 2: //Check the dungeon
                    break;
                case 3: //Loot the mine
                    break;
                case 0:
                    Console.WriteLine(ExitMessage);
                    break;
            }
        } while (op != 0);

    }

}