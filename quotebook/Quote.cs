public class Quote
{
    // variables
    private string _author = "";
    private string _quote = "";
    private Source _source;
    // has source as the return because it's returning as the source which has the name and url if included



    // constructor
    public Quote(string person, string quote, Source source)
    {
        _author = person;
        _quote = quote;
        _source = source;

    }


    // methods

    public bool hasAuthor(string name)
    {
        if (_author.ToUpper().Contains(name.ToUpper()))
        // checking if theres a specific name in the _author variable that contains a name both uppercased for some reason
        {
            return true;
        }
        else
        return false;
    }

    public string GetQuote()
    {
        return $"\"{_quote}\"\n{_author} - {_source.Stringify()}";
    }




}