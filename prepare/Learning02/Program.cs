using System;

class Program
{
    static void Main(string[] args)
    {
        Job Fred = new Job();
        Fred.Company="Microsoft";
        Fred.JobTitle="Software Engeneer";
        Fred.StartYear=1995;
        Fred.EndYear=2019;
        Job Joe = new Job();
        Joe.Company="Apple";
        Joe.JobTitle="Goose Herder";
        Joe.StartYear=2019;
        Joe.EndYear=2023;
        Resume Steve = new Resume();
        Steve.jobs = new List<Job>();
        Steve.Name = "Steve Fredrickson";
        Steve.jobs.Add(Fred);
        Steve.jobs.Add(Joe);
        Steve.Display();
    }
}