using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Havel_Hakimi_algorithm
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> peopleCount = new List<int>();

            string input;
            bool stop = false;
            while (true)
            {
                Console.WriteLine("Enter the Amount of People: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    peopleCount = input.Split(' ')
                           .Select(int.Parse).ToList();


                    while (true)
                    {
                        peopleCount = removeZeros(peopleCount);
                        if (peopleCount.Count == 0)
                        {
                            Console.WriteLine("True");
                            break;
                        }
                        peopleCount = sort(peopleCount);
                        int lengthCheck = peopleCount[0];
                        peopleCount.RemoveAt(0);
                        if (LengthCheck(peopleCount, lengthCheck))
                        {
                            Console.WriteLine("False");
                            break;
                        }
                        peopleCount = FrontElimination(peopleCount, lengthCheck);

                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
        static List<int> removeZeros(List<int> peopleCount)
        {
            while (peopleCount.Contains(0))
                peopleCount.Remove(0);

            return peopleCount;
        }
        static void displayToScreen(List<int> peopleCount)
        {
            for (int i = 0; i < peopleCount.Count; i++)
            {
                Console.Write(peopleCount[i] + " ");
            }
        }
        static List<int> sort(List<int> peopleCount)
        {
            peopleCount.Sort();
            peopleCount.Reverse();

            return peopleCount;
        }
        static bool LengthCheck(List<int> peopleCount, int N)
        {
            if (peopleCount.Count < N)
                return true;
            else
                return false;
        }
        static List<int> FrontElimination(List<int> peopleCount, int N)
        {
            for (int i = 0; i < peopleCount.Count; i++)
            {
                if (i < N)
                    peopleCount[i] = peopleCount[i] - 1;
            }
            return peopleCount;
        }
    }
}
