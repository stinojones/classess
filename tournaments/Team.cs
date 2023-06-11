public class Team 
{
// variables
private List<Player> _roster = new List<Player>();
private List<string> _sponsor = new List<string>();
private string _name;

private int _wins = 0;
private int _losses = 0;

// constructor

// methods
public Team(string name)
{
    _name = name;
}

public void AddWin()
{
    _wins++;
}

public void AddLoss()
{
    _losses++;
}

public void AddPlayer(Player p)
{
    _roster.Add(p);
}

public void Display()
{
    Console.WriteLine($"{_name} {_wins}/{_losses}");
    foreach (Player p in _roster)
    {
        p.Display();
    }
}


public string GetTeamName(){

    return _name;
}












}