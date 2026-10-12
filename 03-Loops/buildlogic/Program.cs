using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
class Program()
{
    static void Main()
    {
        int i = 0;
        int N = 10;
        int sum =0;

        
        while (i <= N)
        { 
            sum = sum +  i;
            i = i + 1;
           
         

        }
        Console.WriteLine(sum);


        // count the digit the number 
        int num =  13233;
        int count = 0;
        if (num == 0)
        {
            count = 1;
        }
        else
        {
            while(num > 0)
            {
                num = num  / 10;
                count = count +1;

            }
        }
        Console.WriteLine(count);

        
        int nums=111231;
        int reversed =0;
        while (nums > 0)
        {
            int digit = nums % 10;
            reversed = reversed* 10 +digit;
            nums = nums /10; 


        }
        Console.WriteLine(reversed);

    }
}