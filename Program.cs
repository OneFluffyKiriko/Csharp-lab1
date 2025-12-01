
using System;
using System.Security.Cryptography.X509Certificates;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Labwork1;

public class Program
{
    public static int FirstLast(int d)
    {
        int num1 = d / 100;
        int num2 = d % 10;
        Console.WriteLine($"First Number = {num1}, Last Number = {num2}");
        return num1 + num2;
    }

    static void Main(string[] args)
    {   
    //7: Дано трьохзначне число. Вивести першу та останню цифру даного числа.
        //Вхідні дані: d = 357 .
    FirstLast(357);

        
    }
}



