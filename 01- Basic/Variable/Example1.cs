
using System;
 public class Example1()
{
    public static void Mn()
    {  // Read two integers and print their sum
        int num1  = 10 ;  
        int num2 = 24;
        int sum = num1 + num2;
        Console.WriteLine("Print two integer " + num1 +" and "+ num2 + " their sum " + sum);

        // Read two integers and print sum, difference, product, quotient

        int difference = num1- num2;
        int product = num1 * num2;
       
        double quotient =   ((double)num1 / num2);

        Console.WriteLine("Print  " + sum  +" differnce" + difference+  "Product "+ product+ "quotient"+ quotient );
    }
}