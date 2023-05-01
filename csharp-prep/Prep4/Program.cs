using System;

using System.Collections.Generic;
        // ^^ whenever making lists or any standard collection you've got to put this at the top of the code ^^

class Program

{
    static void Main(string[] args)
    {

        List<int> answers = new List<int>();
        int maximum = 0;
        int answer = 1;

        while (answer != 0)
        {
        Console.Write("Add a number: ");
        answer = int.Parse(Console.ReadLine());
            if(answer != 0)
            {
                answers.Add(answer);
                maximum = answers[0];
                foreach (int word in answers)
                if(word > maximum)
                {
                    maximum = word;
                }
            }
        }


int count = answers.Count;
int sum = answers.Sum();
float average = ((float)sum) / count;


Console.WriteLine("");
Console.WriteLine($"The total is {sum}");
Console.WriteLine("");
Console.WriteLine($"The average is {average}");
Console.WriteLine("");
Console.WriteLine($"The maximum is {maximum}");

    }
}












// how to make a list, you must specify the type list it'll be, either int or string

// List<int> numbers = new List<int>();

// List<string> words = new List<string>();
// words.Add("hello");
// words.Add("your mom");
// words.Add("beast");

// //  how to add items to the list

// foreach(string word in words)
// Console.WriteLine(word);

// Console.WriteLine(words[2]);

// //  above is how you index to the item you want, 0 is the first item



// // how to find the size of the list, it doesn't need to be in a foreach loop
// Console.WriteLine(words.Count);
