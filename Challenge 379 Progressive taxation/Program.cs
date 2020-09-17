using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_379_Progressive_taxation
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = 0;


            double totalTax = 0;

            double[] taxRate = { 0.10, 0.25, 0.40 };
            double[] incomeCap = { 10000, 30000, 100000 };

            Console.WriteLine("Please Enter your income: ");
            income = int.Parse(Console.ReadLine());

            double calculatedTax = 0;

            // gee - 3000 ????
            
            for (int i = 0; i < incomeCap.Length; i++)
            {
                if (incomeCap[i] <= income)
                {
                    calculatedTax = taxRate[i]  * (income  -  incomeCap[i]);
                    totalTax = totalTax  + calculatedTax;
                }
            }
            
            

            Console.WriteLine(totalTax);
            Console.ReadLine();





        }
    }
}