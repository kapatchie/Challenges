using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> seenBefore = new List<string>(); List<string> input = new List<string>(); input.Add("A"); input.Add("B"); input.Add("C");
            List<char> charArray = new List<char>(); int counter = 1; int final = 0;

            string concat ="";

            for (int i = 0; i < input.Count; i++)
            {

                if (!seenBefore.Contains(input[i]))
                {
                    seenBefore.Add(input[i]); final++;
                }

                if (counter < input.Count)
                {
                    concat = input[i] + input[counter]; final++;
                }
                if (!seenBefore.Contains(concat) && concat != null)
                {
                    seenBefore.Add(concat); final++; concat = null;
                }
                counter++;
            }

            concat = null;


            for (int y = 0; y < input.Count; y++)
            {
                concat = concat + input[y]; final++;
            }

            seenBefore.Add(concat);

            for (int i = 0; i < seenBefore.Count; i++)
            {
                Console.WriteLine("{0} ", seenBefore[i]);
            }
            Console.WriteLine(final);

            Console.ReadLine();
        }
    }
}
