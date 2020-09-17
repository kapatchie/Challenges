using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectly_balanced
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int counterA = 0;
                int counterB = 0;
                
                Console.WriteLine("Please enter a string containing only X & Y");
                string input = Console.ReadLine().ToLower();

                char[] splitString = input.ToCharArray();

                for (int i = 0; i < splitString.Length; i++)
                {
                    if (splitString[i] == 'x')
                        counterA++;
                    else
                        counterB++;
                }

                if (counterA == counterB)
                    Console.WriteLine("Balanced");
                else
                    Console.WriteLine("Not Balanced");
                    
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
