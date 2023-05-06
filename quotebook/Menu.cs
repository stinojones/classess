public class Menu 
{

    // variables
    // setting variables to themselves to link them together in this class
private Board _board;

public Menu(Board board)
{
    _board = board;
}

// constructor

// methods

public void Display()
{
    string response = "";
    string[] options = {"A","S","Q","F","R"};
    while (response != "Q")
    {
        while(options.Contains(response) == false)
        {
            Console.WriteLine("[A]dd Quote:\n[S]how Qutoes\n[Find]Quote by Author\n[R]andom Quote\n[Q]uit\n\nWhat do you want to do? ");
            response = Console.ReadLine() ?? String.Empty;
            // this above means if they input nothing then it'll come in as an empty string
            response = response.ToUpper();
            // this will always make the response uppercase for it to work

        }


        switch(response)
        // switch statement is like a bunch of else if statements like you did in C language
        {
            case "Q":
            Environment.Exit(0);
            // this just quits the enviroment
            break;
            case "A":
            Console.Write("Please enter your quote: ");
            string quote = Console.ReadLine() ?? string.Empty;
            Console.Write("Please enter your author ");
            string author = Console.ReadLine() ?? string.Empty;
            Console.Write("Please enter you source ");
            string source = Console.ReadLine() ?? string.Empty;
            Console.Write("Please enter you url ");
            string sourceUrl = Console.ReadLine() ?? string.Empty;

            _board.AddQuote(new Quote(author, quote, new Source(source, sourceUrl)));
            break;

            case "S":
            _board.ShowQuotes();
            break;

            case "F":
            Console.Write("Please enter your author ");
            author = Console.ReadLine() ?? string.Empty;
            _board.FindQuotesByAuthor(author);
            break;

            case "R":
            _board.GetRandomQuote();
            break;

        }
        response = "";
        // this will reset it to nothing in response and work
    }
    // the string[] states that it's a list

}












}