using System;

class Program
{
    static void Main(string[] args)
    {

  //Creating a new instance called Job1 from Our class "Job" and adding values to this new instance
       Job Job1 = new Job();
       
       Job1._company = "Microsoft";
       Job1._jobTitle = "Software Engineer";
       Job1._startYear = 2018;
       Job1._endYear = 2027;
       Job1.DisplayJobDetails();  //Calling my method which displays the job details

 //Creating another instance named Job2
       Job Job2 = new Job();
       Job2._company = "Apple";
       Job2._jobTitle = "Software Engineer";
       Job2._startYear = 2020;
       Job2._endYear = 2029;
       Job2.DisplayJobDetails();

//Creating a new object for the resume class (new resume class instance)
       Resume myResume = new Resume();
       myResume._name = "Ssali Arafat";
       myResume._jobList.Add(Job1);     //Adding the 2 Jobs from the Job class into my Resume Class
       myResume._jobList.Add(Job2);     //Adding them to our list in the resume (_jobList)
       myResume.DisplayResume();
    }
}