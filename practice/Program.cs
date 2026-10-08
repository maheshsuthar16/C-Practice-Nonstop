using System; // it means that i need to use these system 

class Program{
    static void Main(){// main method is the block  the of code which will perform the task or work 
      // Problem No    1 Positive , Negative, Zero
        int n = 25;
        if( n > 0){
            Console.WriteLine("Positive Number " + n );
        }
        else if (n < 0){
            Console.WriteLine("Negative Number" + n);

        }
        else{
            Console.WriteLine("Zero");
        }

    // Problem No 2  Odd or even 
    //    int n = 10 ;
       if(n % 2 ==0){
        Console.WriteLine("Even ");
       }
       else{
        Console.WriteLine("Odd");
       }

    //Problem 3 read the two number and print the greater number 

    int a= 29;
    int b = 44;
    if( a>b){
        Console.WriteLine(" A is greater than b");

    }else if(a<b){
        Console.WriteLine("b is greater than a ");  }
    else{
        Console.WriteLine("Both are equall ");
    }
  
    


    // Problem No 4  A person is eligible for vote or not 
    int age = 10;
    if(age >= 18){
        Console.WriteLine(" eligible");
    
    }else{
        Console.WriteLine("Not eligible");
    }



    int marks = 38;
    if(marks >= 40){
        Console.WriteLine("Pass");

    }
    else {
        Console.WriteLine("fail");
    }
    }
}
