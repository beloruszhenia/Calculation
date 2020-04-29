using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //test strings
            string[] testStrings = { "10+15", "66-22", "-68-3", "5*45", "36/3" };
            int[] result = new int[testStrings.Length];
                        
            Calculation[] calc = new Calculation[testStrings.Length];

            for (int i = 0; i < testStrings.Length; i++)
            {
                calc[i] = new Calculation();
                calc[i].CalcStr = testStrings[i];
            }

            for (int i = 0; i < testStrings.Length; i++)
            {
                calc[i].CalcStr = testStrings[i];
                result[i] = calc[i].GetRes();
                
                Console.WriteLine("{0} = {1}", calc[i].CalcStr, calc[i].GetRes().ToString());
            }

            Console.ReadKey();


        }
    }
}
