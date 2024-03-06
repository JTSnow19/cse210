using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        {
            job1._jobCompany = "RS Ent.";
            job1._jobLocation = "New York";
            job1._jobRate = 21;
            job1._jobTitle = "Designer";
        };
        job1.DisplayJobStats();

        Job job2 = new Job();
        {
            job2._jobCompany = "Blue Mammoth";
            job2._jobLocation = "Georgia";
            job2._jobRate = 34;
            job2._jobTitle = "Server Manager";
        };
        job2.DisplayJobStats();


        List<Job> jobList = new List<Job>()
        {
            job1, job2
        };

        Resume member = new Resume();
        {
            member._memberName = "Smitt";
            member._memberJob = jobList;
        };
        member.DisplayResume();
        foreach (Job item in member._memberJob)
            item.DisplayJobStats();
        }
    
}