using System;
using System.Collections.Generic; // required for List

class Student
{
    protected string name;
    protected int hours;
    protected List<string> courses = new List<string>(); // empty list of strings

    public Student(string name, int hours) // set the value of name and hours in constructor
    {
        this.name = name;
        this.hours = hours;
    }
    public void DisplayProperties() // output properties formatted 
    {
        Console.WriteLine($"{this.name} is allotted {this.hours} hours this semester and is currently enrolled in {this.courses.Count} classes");
    }

    public void AddClasses() // allow user to add multiple courses then output all courses
    {
        string newCourse = ""; // initial value for loop
        while(newCourse != "done") // continue to prompt until user enters "done"
        {
            Console.Write("Add a new course : "); // prompt
            newCourse = Console.ReadLine(); // update value
            this.courses.Add(newCourse); // add value
        }
        this.courses.Remove("done"); // remove extra value
        Console.WriteLine($"{this.name} is currently enrolled in {this.courses.Count} classes"); // output length
        this.courses.ForEach(course => Console.WriteLine($"Course : {course}")); // output all elements in list
    }
}