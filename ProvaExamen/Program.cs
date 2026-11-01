using System;

public class Program
{
    static void Main()
    {
        // Allows emojis and accents to be displayed correctly in the terminal.
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";

        const string ErrorNotNumber = "Error: you must type a number, not text.";
        const string ErrorTooBig = "Error: that number is too big.";
        const string ErrorRange = "Error: the option must be between 0 and 3.";
        const string ErrorNoInput = "Error: no input received.";
        const string EnterWizardName = "Enter your wizards name";
        const string ChosenOption = "You chose: ";
        const string MeditationMessage = "⌛ Day ";
        const string MeditationHoursMessage = ", you have meditated ";
        const string MeditationPowerMessage = " hours and you earned ";
        const string PointsMessage = " points!";
        const string LevelUpMessage = "🎉 Congratulations ";
        const string LevelUpText = ", you have reached level ";
        const string CurrentLevelMessage = "🌟 ";
        const string CurrentLevelText = ", your current level is ";
        const string FinalPowerMessage = "💪🏻 Your final power is: ";
        const string SecondCallMessage = "💀 You suck";
        const string RankMessage = "🪄 You obtain the rank ";
        const string FirstRank = "Raoden the Elantrian";
        const string SecondRankMessage = "🤡 You still confuse the wand with a spoon";
        const string SecondRank = "Zyn the Bugged";
        const string ThirdRankMessage = "🫡 You're an Invocator of Magic Breezes";
        const string ThirdRank = "Arka Nullpointer";
        const string FourthRankMessage = "🔥 Wow! You can invoke dragons without burning the laboratory!";
        const string FourthRank = "Elarion de les Brases";
        const string FivthRankMessage = "🧙🏻‍ You have reached the rank of Master of the Arcans!";
        const string FivthRank = "ITB-Wizard the Grey";

        const int TotalDoors = 3;
        const int MaxAttempts = 3;
        const int MinCode = 1;
        const int MaxCode = 5;
        const string DungeonIntroMessage = "🐉 You enter the Dungeon of the Dragon RAMón the Mighty...";
        const string DoorMessage = "🚪 Door ";
        const string DoorCodeHint = "Every door is protected by a digital access code between 1 and 5.";
        const string AttemptPrompt = "🔑 Enter the access code - attempt ";
        const string WrongCodeMessage = "❌ Wrong code.";
        const string AttemptsLeftMessage = " Attempts left: ";
        const string ErrorCodeNotNumber = "Error: the code must be a number, not text.";
        const string ErrorCodeTooBig = "Error: that number is too big.";
        const string ErrorCodeRange = "Error: the code must be between 1 and 5.";
        const string ErrorCodeNoInput = "Error: no input received.";
        const string DragonExpelMessage = "The dragon 🐲 has detected your presence and has expelled you from the server!";
        const string DragonRespectMessage = "The dragon 🐲 respects you. You have unlocked the next level!";
        const string FinalLevelMessage = "You have unlocked the final level. You can keep the 💎 treasure of the dragon 🐲!";

        const string LockedDungeonMessage = "🔒 The dungeon is locked. You must train your wizard first (option 1).";
        const string LockedMineMessage = "🔒 The mine is locked. You must clear the dungeon first (option 2).";

        const int TotalDigs = 5;
        const int MinBits = 5;
        const int MaxBits = 50;
        const int NoLootChance = 20;
        const int GoldGpuThreshold = 200;
        const string MineIntroMessage = "💰 Under the dragon's lair you find a mine full of magic bitcoins...";
        const string DigMessage = "⛏️ Excavation ";
        const string NoLootMessage = "Today is not your lucky day, you have found 0 bits 🪙.";
        const string LootMessageStart = "Today is your lucky day, you have found ";
        const string LootMessageEnd = " bits 🪙.";
        const string TotalBitsMessage = "👛 Total bits so far: ";
        const string FinalBitsMessage = "💰 Total bits looted: ";
        const string GoldGpuMessage = "You have unlocked the golden GPU ⚜️! Your spells now run at 120 FPS!";
        const string IntegratedGpuMessage = "Your magic card is still integrated 🪵. Go back to the mine to try your luck!";


        string WizardName = "";

        bool wizardTrained = false;
        bool dungeonCompleted = false;

        // Sentinel value: -1 is NOT a valid option.
        // It is needed because the compiler does not guarantee that 'option' is assigned
        // inside the try block (an exception may occur before the assignment).
        int option = -1;
        bool isValid;

        do
        {
            isValid = false; // At the start of each iteration, assume the input is NOT valid.

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                // int.Parse can throw: FormatException, OverflowException,
                // or ArgumentNullException (if ReadLine returns null with Ctrl+Z / Ctrl+D).
                option = int.Parse(Console.ReadLine());

                // Range validation: if it fails, we throw the exception ourselves.
                if (option < 0 || option > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(option), ErrorRange);
                }



                // If we reach this point, no exception was thrown: the input is valid.
                isValid = true;
                Console.WriteLine(ChosenOption + option);

                if (option == 1)
                {
                    int totalPoints = 0;
                    int level = 0;
                    int previousLevel = 0;
                    string rank = "";
                    Console.WriteLine(EnterWizardName);
                    WizardName = Console.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        var random = new Random();

                        int hour = random.Next(0, 25);
                        int points = random.Next(1, 11);
                        totalPoints += points;

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine(MeditationMessage + i + " → " + WizardName
                            + MeditationHoursMessage + hour + MeditationPowerMessage + points + PointsMessage);

                        level = totalPoints / 10;

                        if (level > previousLevel)
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(LevelUpMessage + WizardName + LevelUpText + level + "!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        previousLevel = level;
                        Console.WriteLine("");
                        Console.WriteLine(CurrentLevelMessage + WizardName + CurrentLevelText + level);
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FinalPowerMessage + totalPoints);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (totalPoints < 20)
                    {
                        rank = FirstRank;
                        Console.WriteLine("");
                        Console.WriteLine(SecondCallMessage);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(RankMessage + "→ " + rank);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    else if (totalPoints >= 20 && totalPoints < 30)
                    {
                        rank = SecondRank;
                        Console.WriteLine("");
                        Console.WriteLine(SecondRankMessage);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(RankMessage + "→ " + rank);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (totalPoints >= 30 && totalPoints < 35)
                    {
                        rank = ThirdRank;
                        Console.WriteLine("");
                        Console.WriteLine(ThirdRankMessage);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(RankMessage + "→ " + rank);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (totalPoints >= 35 && totalPoints < 40)
                    {
                        rank = FourthRank;
                        Console.WriteLine("");
                        Console.WriteLine(FourthRankMessage);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(RankMessage + "→ " + rank);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (totalPoints >= 40)
                    {
                        rank = FivthRank;
                        Console.WriteLine("");
                        Console.WriteLine(FivthRankMessage);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(RankMessage + "→ " + rank);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                    wizardTrained = true;
                }

                if (option == 2 && !wizardTrained)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(LockedDungeonMessage);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (option == 2)
                {
                    bool dungeonSurvived = true;
                    var random = new Random();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(DungeonIntroMessage);
                    Console.WriteLine(DoorCodeHint);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int door = 1; door <= TotalDoors && dungeonSurvived; door++)
                    {
                        int secretCode = random.Next(MinCode, MaxCode + 1);
                        bool doorOpened = false;

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(DoorMessage + door + " / " + TotalDoors);
                        Console.ForegroundColor = ConsoleColor.White;

                        for (int attempt = 1; attempt <= MaxAttempts && !doorOpened; attempt++)
                        {
                            int guess = -1;
                            bool isGuessValid = false;

                            do
                            {
                                isGuessValid = false;
                                Console.Write(AttemptPrompt + attempt + "/" + MaxAttempts + ": ");

                                try
                                {
                                    guess = int.Parse(Console.ReadLine());

                                    if (guess < MinCode || guess > MaxCode)
                                    {
                                        throw new ArgumentOutOfRangeException(nameof(guess), ErrorCodeRange);
                                    }

                                    isGuessValid = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(ErrorCodeNotNumber);
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine(ErrorCodeTooBig);
                                }
                                catch (ArgumentNullException)
                                {
                                    Console.WriteLine(ErrorCodeNoInput);
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    Console.WriteLine(ErrorCodeRange);
                                }
                            } while (!isGuessValid);

                            if (guess == secretCode)
                            {
                                doorOpened = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(WrongCodeMessage + AttemptsLeftMessage + (MaxAttempts - attempt));
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }

                        if (!doorOpened)
                        {
                            dungeonSurvived = false;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(DragonExpelMessage);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (door == TotalDoors)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(FinalLevelMessage);
                            dungeonCompleted = true;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(DragonRespectMessage);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                }

                if (option == 3 && !dungeonCompleted)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(LockedMineMessage);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (option == 3)
                {
                    int totalBits = 0;
                    var random = new Random();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(MineIntroMessage);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int dig = 1; dig <= TotalDigs; dig++)
                    {
                        int luck = random.Next(1, 101);
                        int bitsFound = 0;

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine(DigMessage + dig + " / " + TotalDigs);

                        if (luck <= NoLootChance)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(NoLootMessage);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            bitsFound = random.Next(MinBits, MaxBits + 1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(LootMessageStart + bitsFound + LootMessageEnd);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        totalBits += bitsFound;
                        Console.WriteLine(TotalBitsMessage + totalBits);
                    }

                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(FinalBitsMessage + totalBits);

                    if (totalBits > GoldGpuThreshold)
                    {
                        Console.WriteLine(GoldGpuMessage);
                    }
                    else
                    {
                        Console.WriteLine(IntegratedGpuMessage);
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                }


            }
            catch (FormatException)              // Text that is not a number: "abc", "3.5", ""
            {
                Console.WriteLine(ErrorNotNumber);
            }
            catch (OverflowException)            // Number that does not fit in an int: "99999999999"
            {
                Console.WriteLine(ErrorTooBig);
            }
            catch (ArgumentNullException)        // ReadLine returned null
            {
                Console.WriteLine(ErrorNoInput);
            }
            catch (ArgumentOutOfRangeException)  // The exception we threw for the range
            {
                Console.WriteLine(ErrorRange);
            }
            finally
            {
                // Always executes, whether there is an error or not.
                Console.WriteLine("----------------------------");
            }

            // Repeat if the input was invalid OR if the user did not choose to exit
            // Check !isValid first because, after an error, 'option' may
            // still contain 0 from a previous iteration.
        } while (!isValid || option != 0);



    }
}