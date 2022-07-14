using System;

namespace School 
{
    class Student : Person
    {
        // Fields
        public double GPA = 0.0;
        public int YearsCompleted;

        // Constructor
        public Student(string name, string email, string phone, string address1, 
            string address2, string city, string state, string zip, int age, int YearsCompleted)
        {
            this.name = name;
            this.Id = MaxId;
            MaxId++;
            this.email = email;
            this.phone = phone;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.age = age;
            this.YearsCompleted = YearsCompleted;
        }

        // Methods
    }
}