using System;
using System.Data;
class Program()
{
    static void Main()
    { // in these i have practice the c# using the for loops 
        int n =5;
        for(int i = 0 ; i < n ; i++)
        { 
            Console.WriteLine(i);
            
        }

        int a = 1;
        int sum =  0; 
        int num = 11 ;
        while(a < num)
        {  sum = sum +1;
            a = a+1;

            Console.WriteLine(sum);
         
        }
        int m = 10 ;
        while(m >= 1)
        {
            Console.WriteLine(m);
            m--;
        }
        
        int j = 1;
        int k =20;
        while (j <= k)
        {
            if (j % 2 == 0)
            {
                Console.WriteLine(j);
            }
            j++;
        }
        
        int l = 1;
        int y= 20;
        while (l < y)
        {
            if (!(l % 2 == 0))
            {
                Console.WriteLine(l);
            }
            l++;
        }

        int u = 1;
        int o = 10;
        while (u <= o)
        {
            int nums =u *u;
            Console.WriteLine(nums);
            u++;
        }



    }
}