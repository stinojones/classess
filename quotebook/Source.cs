public class Source
{
    // variables
    private string _name = "";
    private string _url = "";



    
// constructor
 
 public Source(string name , string url= "")
//  the = ""       is an if statement for if there is no url then it'll still work and have nothing there
 {
    _name = name;
    _url = url;
 }


// methods

public string Stringify()
{
    return $"{_name} {_url}";
}

}