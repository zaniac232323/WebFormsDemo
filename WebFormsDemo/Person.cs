using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class Person
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public string Phone { get; set; }
        public Person()
        {
         
        }
        public Person(string studentid,
                        string name,
                        double credits,
                        string phone)
        {
            StudentID = studentid;
            Name = name;
            Credits = credits;
            Phone = phone;
        }
    }
}