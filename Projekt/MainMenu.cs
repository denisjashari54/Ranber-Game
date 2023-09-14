using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanberGame
{
    class MainMenu
    {
        public bool isRunning = true;

        public void Run()
        {
            while (isRunning)
            {
                Console.WriteLine("### RANBER GAME ###");
                Console.WriteLine("###################");
                Console.WriteLine();

                Console.WriteLine("Wähle eine Aktion aus: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] Spielen");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[2] Beenden");
                Console.WriteLine();
                Console.ResetColor();

                Console.Write("Aktion: ");

                try
                {
                    int action = Convert.ToInt32(Console.ReadLine());

                    switch (action)
                    {
                        case 1:
                            PlayGame();
                            break;
                        case 2:
                            isRunning = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Aktion. Bitte wählen Sie 1 oder 2!");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                    Console.ResetColor();
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        public void PlayGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 101);
                GameLoop game = new GameLoop(randomNumber);
                game.Start();

                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("Möchten Sie noch einmal spielen? (y/n): ");
                    string playAgainInput = Console.ReadLine().ToLower();

                    if (playAgainInput == "y")
                    {
                        playAgain = true;
                        validInput = true;
                    }
                    else if (playAgainInput == "n")
                    {
                        playAgain = false;
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'y' für Ja oder 'n' für Nein ein.");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }

                Console.Clear();
            }
        }
    }
}
