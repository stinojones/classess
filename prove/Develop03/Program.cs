using System;

class Program
{
    static void Main(string[] args)
    {

        Reference Nephi = new Reference("1 Nephi", 1, 6);
        Nephi.Display();



        Word money = new Word("hello buddy, how are you?");
        money.HideWord();
        money.Display();

        money.ShowWord();
        money.Display();







        
    }
}