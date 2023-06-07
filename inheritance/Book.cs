public class Book : Loanable
// book IS A loanable
{
// variables
    private string _title;
    private string _isbn;
    private int _upc;




// constructor


    public Book(string title, string isbn, int upc)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    // methods

    public override void Display()
    {
        ShowBookDetails();
        base.Display();
    }

    public void ShowBookDetails()
    {
        Console.WriteLine($"{_title} :: {_isbn} :: {_upc} Checked in: {_isCheckedIn}");

    }









}




