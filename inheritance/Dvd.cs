public class Dvd : Loanable
// the colon makes dvd able to inherit from Loanable
// dvd IS A loanable
{
private string _title;




public Dvd(string title)
{
    _title = title;
}



// override adds a change specifically for this class
    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
        
    }

}