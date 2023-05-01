public class Resume {
//variables
public string name = "";
public List <Job> jobs = new List<Job>();

public string company = "";
public string jobTitle = "";
public int startYear;
public int endYear;

public void displayResumeInfo(){
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Jobs: ");
    foreach(Job job in jobs)
    job.displayJobInfo();


}







// constructor







// Methods









}