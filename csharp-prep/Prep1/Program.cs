using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

// console.Write makes it so there is no new line made after the text and you can keep it going
        
        Console.Write("so if I wanted to keep writing on this line and not create a new one ");
        Console.WriteLine("I could do so with console.write above");

// console.WriteLine makes it possible to have a new line underneath made after text or anything is written

        Console.WriteLine("but if I did want a new line to start then");
        Console.WriteLine("I would use console.writeline");

// this is how you write out an input statement with the answer right next to the question

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

// input statement if you want answer underneath

        Console.WriteLine("What is your favorite food? ");
        string food = Console.ReadLine();

        int x = 31;
        int y = 22;
        int z = 30;

// starting the if statement you must use parenthesis and you don't need a semicolon to start it
        
        if (x > y)
        {
            string statement = "Greater";

            // you can add variable into the string by using $    like so
        Console.WriteLine($"the number of x is {statement} than y");  
        }
        
        
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");



        // how to indent your if statements
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("greater than both");
            }
        }
    



        // if and else statements

        

        if (x > y)
        {
            Console.WriteLine("greater than");
        }
        else
        {
            Console.WriteLine("less than");
        }


        // elif is written as else if in C#
        if (x > y)
        {
            Console.WriteLine("greater than y");
        }
        else if (x > z)
        {
            Console.WriteLine("greater than z");
        }
        else
        {
            Console.WriteLine("less than both");
        }


        // things like == and != are used in c#

        string name = "John";

        string favoriteColor = "string";
        if (name == "John")
        {
            Console.WriteLine("The name is John");
        }

        if (color != favoriteColor)
        {
            Console.WriteLine("That color is not my favorite");
        }




        // and command is written as && and the or command is ||



        if (name == "Peter" || name == "James" || name == "John")
        {
            Console.WriteLine("This is a biblical name.");
        }

        if (firstName == "Brigham" && lastName == "Young")
        {
            Console.WriteLine("Welcome Brother Brigham!");
        }

        if (!(name == "Peter" || name == "James" || name == "John"))
        {
            Console.WriteLine("This is a not one of those three");
        }






        // you can change strings to int's mid code by using int.Parse(userInput)
        // If the user typed in something other than a number, this would result in type of error called a Runtime Exception.
        Console.Write("What is your favorite number? ");
        string userInputed = Console.ReadLine();
        int number = int.Parse(userInputed);




        // Similarly, an integer can be converted to a string using the .ToString() function of the variable.
        int numbers = 42;
        string textVersion = numbers.ToString();


        
        
        
      














    




    



    
    }
}









