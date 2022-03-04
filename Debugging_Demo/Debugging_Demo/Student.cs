using System;
using System.Collections.Generic;
using System.Text;

namespace Debugging_Demo
{
    public class Student
    {
        public static List<Student> StudentList { get; set; } 
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime FirstDay { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Student(int id, string fName, string lName, DateTime date)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
            FirstDay = date;
        }
    }
}
