using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        //Code a second constructor that takes 5 parameters and assigns values to name, employerName, employerLocation,
        ///jobType, and jobCoreCompetency.
        //Generate the Equals() and GetHashCode() methods. Consider two Job objects equal when their id fields match.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string result = "\n";
            result += $"ID: {Id}\n";
            result += $"Name: {Name}\n";
            result += $"Employer: {(string.IsNullOrEmpty(EmployerName.Value) ? "Data not available" : EmployerName.Value)}\n";
            result += $"Location: {(string.IsNullOrEmpty(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value)}\n";
            result += $"Position Type: {(string.IsNullOrEmpty(JobType.Value) ? "Data not available" : JobType.Value)}\n";
            result += $"Core Competency: {(string.IsNullOrEmpty(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value)}\n";
            result += "\n";
            return result;
        }



    }
}

