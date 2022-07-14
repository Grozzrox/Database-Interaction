using System;

namespace School 
{
    class Course
    {
        // Fields

        private string Id;
        private string Name;
        private string Department;
        private string Location;
        private DateTime  StartDate;
        private List<Student> Roster;
        private Teacher Instructor;
        private List<string> Requirements;
        private int Capacity;
        private int CreditHours;
        private static int MaxId = 1;

        public Course(string Name, string Department, string Location, DateTime StartDate, int CreditHours)
        {
            this.Name = Name;
            this.Department = Department;
            this.Location = Location;
            this.StartDate = StartDate;
            this.CreditHours = CreditHours;
            this.Roster = new List<Student>();
            this.Requirements = new List<string>();
            this.Id = Department.Substring(0, 3) + "-" + MaxId.ToString();
            MaxId++;
        }

    }
}