
    

// how to do functions

// Here is an example of a function that does not have parameters or a return type (hence the use of void):

// void DisplayMessage()
// {
//     Console.WriteLine("Hello world!");
// }




// The next example shows a function that accepts a single string parameter:

// void DisplayPersonalMessage(string userName)
// {
//     Console.WriteLine($"Hello {userName}");
// }




// The next example shows a function that accepts two integers as parameters. It adds them together and returns the result. Notice that 
// the function specifies a return value of int at the beginning of the definition.


// int AddNumbers(int first, int second)
// {
//     int sum = first + second;
//     return sum;
// }


// Use static for all of your functions until we start writing classes.

// static void DisplayMessage()
// {
//     Console.WriteLine("Hello world!");
// }

// static void DisplayPersonalMessage(string userName)
// {
//     Console.WriteLine($"Hello {userName}");
// }

// static int AddNumbers(int first, int second)
// {
//     int sum = first + second;
//     return sum;
// }


using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}