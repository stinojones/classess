using System;

class Program
{
    static void Main(string[] args)
    {
          // this is the Assignment of the grade calculator


        Console.Write("What is your grade percentage in the class? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        int gradeRemainder = grade % 10;

        string letter = "";
        string sign = "";

       
        if (grade < 60)
        {
            letter = "F";
        }

        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 80 && grade <90)
        {
            letter = "B";
        }
        else if (grade >= 90)
        {
            letter = "A";
        }
        if (letter == "D" || letter == "C" || letter == "B")
        {
            if (gradeRemainder >=7) 
            {
                sign = "+";
            }
            else if (gradeRemainder < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"You're Final Grade is a {letter}{sign}");  

        if (grade >= 70)    
        {
            Console.WriteLine("Great Job! You passed the class!");
        }
        else 
        {
            Console.WriteLine("Sorry, You did not pass the class, keep studying!");
        }

        
           

        





    }


}