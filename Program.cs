using System;
using System.Net.Http.Headers;

namespace RanberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu gameManager = new MainMenu();
            gameManager.Run();
        }
    }

    class MainMenu
    {
        private bool isRunning = true;

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

        private void PlayGame()
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

    class GameLoop
    {
        private int randomNumber;
        private int attempts = 0;

        public GameLoop(int randomNumber)
        {
            this.randomNumber = randomNumber;
        }

        public void Start()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Geben Sie eine Zahl von 1 bis 100 ein: ");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number < 1 || number > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 100 ein!");
                        Console.ResetColor();
                        Console.WriteLine();
                        continue;
                    }

                    attempts++;

                    if (number == randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du hast die Zahl erraten! Anzahl der Versuche: {0}", attempts);
                        Console.WriteLine();
                        Console.ResetColor();

                        break;
                    }
                    else if (number < randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Eingabe zu klein!");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    else if (number > randomNumber)
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("Eingabe zu hoch!");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
