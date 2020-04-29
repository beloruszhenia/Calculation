using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res;
            int a;

            string myStr = "-1  ";

            int.TryParse(myStr, out a);
                        
            res = int.TryParse(myStr, out a);
            Console.WriteLine("String is a numeric representation: " + res);

        }
    }
}
