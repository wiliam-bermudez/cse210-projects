using System;

class Program
{
    
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();   

        job1._company="Microsoft";
        job1._jobTitle="Software Engineer";
        job1._startYear=2010;
        job1._endYear=2024;

        job2._company="Apple";
        job2._jobTitle="Software Engineer";
        job2._startYear=2013;
        job2._endYear=2023;    

        Resume myResume = new Resume();

        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume._name = "Wiliam Antonio Bermudez Solis";
        
        myResume.Display();
        int counter=0;
        foreach (Job j in myResume._job)
        {
            myResume._job[counter].Display();
            counter = counter+1;
        }

    }
    

    
}