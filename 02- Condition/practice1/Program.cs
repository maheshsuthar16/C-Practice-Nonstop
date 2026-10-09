using System;
using System.Globalization;

class Program(){
    static void Main(){
    int marks = 55;
        if( marks >= 80){
            Console.WriteLine("A");
        } else if(marks >= 70) {
        Console.WriteLine("B");
   
        }else if(marks >= 60){
            Console.WriteLine("C");
        }
        else if( marks >= 50)
        { Console.WriteLine("D");}

        else{
            Console.WriteLine("E");
        }
 // Solving the question for the range type all coming 
    int  nums= 10;
    if(nums <= 5  && nums >= 50)
        {
            Console.WriteLine("At the range ");
        }
        else
        {
            Console.WriteLine("Not ate the range ");
        }
    
    int num = 15;
        if((num % 3 == 0) && (num % 5 == 0))
        {
            Console.WriteLine("It is divisible by 3 and 5 ");
        }
        else
        {
            Console.WriteLine("It is not divisible by 3 and 5");
        }
    
    int es = 9;
        if((es % 3==0 ) || ( es % 5 == 0))
        {
            Console.WriteLine("Its done");

        }
        else
        {
            Console.WriteLine( "it id not ");
        }

    string username = "admin";
    string password ="5555";
    

        if((username =="admin")  && (password == "3330"))
        {
            Console.WriteLine("successful Login");
        }
        else
        {
            Console.WriteLine("unsucessful , try again ");
        }    
    
    bool hasTicket = true;
    int age = 20;
        if (hasTicket)
        {
            if(age>= 18)
            {
                Console.WriteLine("he or she can watch the adult movie ");
            }
            else
            {
                Console.WriteLine("he or she cant watch these movie ");
            }
        }

        if(age>= 18 && hasTicket)
        {
            Console.WriteLine("yes he can watch the movie");
        }
        else
        {
            Console.WriteLine("no");
            
        }
        bool isLogin = false;
        if (!isLogin)
        {
            Console.WriteLine("login sucessful ");
        }















    }


}

