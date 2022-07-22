using System;

namespace RpConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //when there are two methods with the same name (method signature)...
            //but different set if parameters, it is called "method overloading"
        
        Console.WriteLine(43);

        // variables are used to hold data.
        //each variable is declared and given a data type.
        //this type cannot be changed without certain qualifications being met.
        //conventionally, vairables are writtenInCamelCase.
        /**CamelCase - no spaces, starts with a lowercase letter, all other words start with a capital letter 
        PascalCase - no spaces, starts with an uppercase letter and all other words begin with capital letters too
        **/


        string myString = "Beverly is super kewl..."; //""called an "empty string"
        int myint = 44;
        myint = 2147483647;

        Console.WriteLine(myint.GetType());
        Console.WriteLine(myString.GetType());

        int myInt1 = 1 + 2;
        Console.WriteLine(myInt1);
//Operators
        Console.WriteLine(myInt1 - myInt1);
        Console.WriteLine(100/ 10);
        Console.WriteLine(Math.Pow(100,2));
        Console.WriteLine(100*2);

        //string interpolation
        Console.WriteLine($"The division is => {101 / 10}"); //returns the integer 
        Console.WriteLine($"The modulus is => {100 % 6}"); //returns the modulus or remainder 

        int myInt2 = 10;

        Console.WriteLine(myInt2++);
        Console.WriteLine(myInt2);
        Console.WriteLine(++myInt2);

        Console.WriteLine(myInt2--);
        Console.WriteLine(myInt2);
        Console.WriteLine(--myInt2);

        /** Flow Control*/
        //this is like an if statement 
        int x,y,z;
        x = 5;
        y = 6;
        z = 7;

        if (y > x)
        {
            Console.WriteLine("x is greater than y");
        }
        else if (y > x)
        {

            Console.WriteLine("y is greater than x");
        }
        else 
        {
            Console.WriteLine("y and x are equal"); 
        }
        
        
        
        
        int a,b,c;
        a = 7;
        b = a;
        c = b++;
        
        //this is like a if statement 
        c = a >= 100 ? b : c / 10;  
        
        //arrays
        //in a computer, a string is a consecutive group of char (character) memory locations 
        char[]myCharArr = new char [] {'1'/**element 0*/,'q'/**element 1*/,'a'/**element 2*/,'z'/**element 3*/,'v'/**element 4*/};
        Console.WriteLine($"The element 1 is => {myCharArr[1]}");

       //Exceptions - most specific to least specific
        try
        {
            Console.WriteLine($"The element 1 is => {myCharArr[7]}");
            Console.WriteLine($"THE EXCEPTION WAS CAUGHT. THIS WILL NOT RUN.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"The out of range exception was thrown. The dealio is {ex.Message}");
        }
        
        
       



        }
    }
}
