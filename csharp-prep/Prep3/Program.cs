using System;

class Program
{
    static void Main(string[] args)
    // we now have while looops
    
    {

//  you can make a class for a random number generator

Random randomGenerator = new Random();

int number = randomGenerator.Next(1, 10);

int guess = 0;

int amount = 0;
string play_again = "yes";

while(play_again == "yes")
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    amount += 1;
    
    if(guess < number){
        Console.WriteLine("");
        Console.WriteLine("Higher");
        Console.WriteLine("");
    }

    if(guess > number){
        Console.WriteLine("");
        Console.WriteLine("Lower");
        Console.WriteLine("");
    }

    if(guess == number){
        Console.WriteLine("");
        Console.WriteLine("You found the magic number!");
        Console.WriteLine("");
        Console.WriteLine($"You had a total of {amount} guessses");
        Console.WriteLine("");
        Console.Write("Would you like to play again? ");
        play_again = Console.ReadLine();
        Console.WriteLine("");
        amount = 0;
    }

}

Console.WriteLine("Thanks for playing the Guessing Game!");







//     string response = "yes";

//     while (response == "yes")
//     {
//         Console.Write("Do you want to continue? ");
//         response = Console.ReadLine();
//     }


//     // This loop works the same as a while loop,
//     //  with the exception that the body of the loop 
//     // runs once first, before the check is made for the first time. 
//     // This means that the body of the loop is guaranteed to run at least once.

//     do
// {
//     Console.Write("Do you want to continue? ");
//     response = Console.ReadLine();
// } while (response == "yes");

// // for loop of where it starts, ends, and the incrementation

// for (int i = 2; i <= 10; i = i + 1)
// {
//     Console.WriteLine(i);
// }



//  for the foreach loops remember to have it's typed variable defined, the variable being 'string' colors in this case

// foreach (string color in colors)
// {
//     Console.WriteLine(color);
// }

























    }
 
}

