public class Job {
// variables

// when using private variables it lets others not able to use, you can do that then have the functions public
// variables that are set as private you should put an underscore before the variable name ex: _name

public string company = "";
public string jobTitle = "";
public int startYear;
public int endYear;




// constructor


public Job() {

}
// constructor uses functions that our defaults that will happen no matter what


// Methods
public void displayJobInfo(){
    Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");




}


















}