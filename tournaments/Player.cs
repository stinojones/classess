public class Player
{
    private string _firstname;
    private string _lastname;
    private int _jerseyNumber;


public Player(string firstName, string lastName, int jerseyNumber){
    _firstname = firstName;
    _lastname = lastName;
    _jerseyNumber = jerseyNumber;
}


public void updateJersey(int newNumber){
    _jerseyNumber = newNumber;
}


public void Display()
{
    Console.WriteLine($"{_firstname} {_lastname} {_jerseyNumber}");
}


}