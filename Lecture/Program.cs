using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 08 13 Lecture"); // sanity message

            // create a ListAndLoops object
            ListsAndLoops lecture = new ListsAndLoops();

            // Call ListAndLoops methods on the instance of the ListAndLoops class
            lecture.SetUp(); // output sanity message
            lecture.ListCreation(); // create a list and call private methods to output list elements
            lecture.UsingWhileLoops(); // prompt user to enter q to quit
            lecture.CombiningLoops(); // prompt user to add items to a list and enter done to display list elements

            // create a Student object
            Student student1 = new Student("Chris", 18);
            // call Student methods on the instance of the Student class
            student1.DisplayProperties();
            student1.AddClasses();

            // create a GraduateStudent object - derived from Student class
            GraduateStudent gradStudent1 = new GraduateStudent("Ellen", 12, true, "Avigal");
            // call Student and GraduateStudent methods on instance of GraduateStudent class - derived from Student class
            gradStudent1.DisplayProperties();
            gradStudent1.CheckThesis();
        }
    }
}
