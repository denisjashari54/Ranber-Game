using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanberGame
{
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
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
