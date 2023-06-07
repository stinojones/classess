public class Loanable 
// this is the inheritable class where all the similar variables and methods should be that are used in every class
// and now access everything underneath it
{
    // variables
    protected bool _isCheckedIn = true;
    // protected makes this bool available to all subclasses
    



// methods

    public void CheckOut()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }


// virtual makes this method available to ovveride in other classes and add more changes specifically for that class
    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }





}