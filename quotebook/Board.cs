public class Board
{

    // variables
    List<Quote> _quotes = new List<Quote>();
    // new list of quotes, refreence in between <> and variable name is _quotes and what it's equal to





// constructor
// if you don't write out the constructor, it'll be made automatically but not shown I think







// methods

private void NicePrint(string item)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"{item}");
    Console.WriteLine("-----------------------------");

}


public void ShowQuotes()
{
    foreach (Quote quote in _quotes)
    // have to specify the class it's in
    {
        NicePrint(quote.GetQuote());
        // you put a function inside of a function, in the same class so you don't need to call for it
    }
}

public void AddQuote(Quote quote)
{
_quotes.Add(quote);
}

public void GetRandomQuote()
{
    var random = new Random();
    var randomNumber = random.Next(0, _quotes.Count);
    // picks a random one from this list
    NicePrint(_quotes[randomNumber].GetQuote());
}


public void FindQuotesByAuthor(string author)
{
    foreach(Quote quote in _quotes)
    if(quote.hasAuthor(author))
    {
        NicePrint(quote.GetQuote());
    }

}

}