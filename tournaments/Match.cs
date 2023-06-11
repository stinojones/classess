public class Match
{
    // variables
    private Team _team1;
    private Team _team2;

    // constructor
    public Match(Team t1, Team t2)
    {
        _team1 = t1;
        _team2 = t2;
    }



    public void DecideWin()
    {
        Console.WriteLine("Which Team Won?");
        Console.WriteLine($"1){_team1.GetTeamName()}");
        Console.WriteLine($"2){_team2.GetTeamName()}");
        string winner = Console.ReadLine();
        if(winner == "1")
        {
            _team1.AddWin();
            _team2.AddLoss();

        }
        else{

             _team2.AddWin();
            _team1.AddLoss();

        }
    }















}