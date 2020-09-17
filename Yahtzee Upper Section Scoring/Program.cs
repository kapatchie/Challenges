using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Upper_Section_Scoring
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int counterA = 0; int counterB = 0; int max = 0;

                Console.WriteLine("Enter Dice Scores seperated by a space"); 
                string input = Console.ReadLine();

                int[] yahtzee_Upper = input.Split(' ')
                    .Select(int.Parse).ToArray();

                for (int i = 0; i < yahtzee_Upper.Length; i++)
                {
                    counterA = yahtzee_Upper[i];

                    for (int y = 0; y < yahtzee_Upper.Length; y++)
                    {

                        if (yahtzee_Upper[i] == yahtzee_Upper[y])
                            counterB++;
                    }

                    if (counterA * counterB > max)
                        max = counterA * counterB;
                    counterB = 0;
                }
                Console.WriteLine(max); Console.ReadLine(); Console.Clear();
            }
        }
    }
}
