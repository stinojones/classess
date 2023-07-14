public class Menu : Post
{

// ---------------------------------------variables-------------------------------------------
 string brackets = "========SOCIAL========";
private string _userinput = "";
Post post = new Post();

// ----------------------------------------constructor-------------------------------------------
public Menu()
{
}

// -----------------------------------------methods----------------------------------------------
public void Display()
{

    while (_userinput.ToLower() != "q")
    {
        Console.WriteLine(brackets);
        Console.WriteLine(" Main Menu");
        Console.WriteLine("[C]reate Post");
        Console.WriteLine("[V]iew Profile");
        Console.WriteLine("[H]ome Page");
        Console.WriteLine("[Q]uit");
        Console.WriteLine(" User: ");
        _userinput = Console.ReadLine();
        switch (_userinput.ToLower())
        {
            case "c":
                post.CreatePost();
                break;
            case "v":
                post.DisplayPost(_postList);
                break;
            case "h":

                break;
            case "q":
                Console.WriteLine("Thank You for Coming!");
                return;
        }
    }
}






}



