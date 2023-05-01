using System;

class Program
{
   

    static void Main(string[] args)
    {

         Job software_engineer = new Job();
         software_engineer.company = "Apple";
         software_engineer.startYear = 2019;
         software_engineer.endYear = 2023;
         software_engineer.jobTitle = "Software Engineer";
         software_engineer.displayJobInfo();

         Job manager = new Job();
         manager.company = "Microsoft";
         manager.startYear = 2019;
         manager.endYear = 2023;
         manager.jobTitle = "Manager";
         manager.displayJobInfo();
        //  this is a function which needes parentheses to display



         Resume myResume = new Resume();
         myResume.name = "Austin Jones";
         myResume.jobs.Add(software_engineer);
         myResume.jobs.Add(manager);


        //  adding a value to list inside of this class

        myResume.displayResumeInfo();






         



   



        

        
        


























    }
}