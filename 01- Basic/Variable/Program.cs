using System;
using System.Diagnostics;

class Solution()
{
    static void Main()
    {
        int nums = 25 ;
        float nums1 = 19.5f;    
        Console.WriteLine("Print the Number:" + nums);
        Console.WriteLine("Print the Float Number : " + nums1);
        int age = 25;

        Console.WriteLine(age);

        //In these  let understand the byte how that we can implement in these   int consider 4 byte  which equal to the 32 bits
        // so their range will between int  32 mean the range -2,147,483,648 to 2,147,483,647 

        int number = -2147483648;
        Console.WriteLine("Printing the end of the int bits of 32 :"+ number);
        
        // int number1 = -2147483649;
        // Console.WriteLine(" Printing the end of the int bits of 32 :"+ number1);
        
        // E:\Let\C#Practise\01- Basic\Variable\Program.cs(18,23): error CS0266: Cannot implicitly convert type 'long' to 'int'. An explicit conversion exists (are you missing a cast?)

        // The build failed. Fix the build errors and run again.



        // Let understand the float system how it works and how i will implement 
        // float store the decimal point and float number 
        // same like the int it also stor the 4 byte = 32 bits .  means  32 
        // Approximately  8,9 significant decimal digits of precision.

        float speed = 25.7f;
        Console.WriteLine("Print the float : " + speed);



    // let begain to learn the double 
    // but it also the store the decimal and also  more precisely than the float 
    // so while double contain the  8byte which mean to 64 bits 
    // Approximately 15–17 significant decimal digits of precision.

    double pi = 3.14788898798787; 
    Console.WriteLine("Print the double  pi : " + pi );

    // let begin to learn the decimal 
    // decimal is the more highly percision than the other 
    // it is help for the practice the  finiical calculation ;
    // it contain the 16 byte which mean to the 128 bits.

    decimal pricetax = 29.3m; 
    decimal govttax = 3.9m; 
    decimal totalRevenueTax = pricetax + govttax;
    Console.WriteLine("Print the Total revenue tax :" + totalRevenueTax);

    // Lets begin to learn the char  
    //  char store the character  which is equal to the   2 byte means the 16 byte 
    
    char grade = 'A';
    Console.WriteLine("Print the grade :"+ grade);
    

    // let begin to learn the  string datatype 
    // string store text 
    // string is the variable amount of memory  which mean it can store the 2,4,8,16  byte in the memory 


    string  playerName  = "krish soni ";
    string gameaName = " Chocore Block Blast ";

    Console.WriteLine(playerName +" is playing the Game " + gameaName);



    //Let begin to learn the bool for these 
    // bool represent the logic states 
    // true false  or 0 and 1 states
    // bool store the 1 byte which means 2 byte ; 

    bool gameOver = false;
    Console.WriteLine("Print the bool  gameOver :" + gameOver);
     

     Example1.Mn();

    }
}