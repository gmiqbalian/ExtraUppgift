using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgift
{
    internal class App
    {
        public void extraUppgift()
        {
            Console.WriteLine("Den som ska spela måste tita bort nu!");
            Console.Write("Skriv in ett ord: ");
            string secretWord = Console.ReadLine();
            string[] solution = new string[secretWord.Length];
            //char guess = Convert.ToChar(Console.ReadLine());
            Console.Clear();


            string hiddenWord = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                solution[i] = "_" + " ";
                hiddenWord += solution[i];
            }

            int numberOfGuesses = 6;
            while (true)
            {
                Console.WriteLine($"Ord: {hiddenWord}");
                Console.Write("Gissa en bokstav eller ordet?");
                char guess = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord.Contains(guess))
                    {
                        Console.WriteLine($"Bra! Du har {numberOfGuesses} kvar.");
                        //hiddenWord = hiddenWord.Replace('_', guess);
                        hiddenWord[i] = guess;
                    }
                    else if (hiddenWord != secretWord)
                    {
                        numberOfGuesses--;
                        Console.WriteLine($"Fel Ord! Du har {numberOfGuesses} kvar.");
                    }
                    else
                    {
                        numberOfGuesses--;
                        Console.WriteLine($"Fel! Du har {numberOfGuesses} kvar.");
                    }

                }

            }
        }
    }
}
