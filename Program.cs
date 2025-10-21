// See https://aka.ms/new-console-template for more information
// Variant 7: Дано трьохзначне число. Вивести першу та останню цифру даного числа.
//Вхідні дані: d = 357 .
using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Labwork1
{
    class App
    {
        static void Main(string[] args)
        {   
            int d = 357;
            int a = d / 100;
            int b = d % 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

}

