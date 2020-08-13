using System;

// class extends Student class
class GraduateStudent : Student
{
    private bool isThesisComplete;
    private string thesisAdvisor;
    // constructor extends base class constructor
    public GraduateStudent(string name, int hours, bool isThesisComplete, string thesisAdvisor) : base(name, hours)
    {
        this.isThesisComplete = isThesisComplete;
        this.thesisAdvisor = thesisAdvisor;
    }
    public void CheckThesis() // check if thesis is complete and display appropriate message
    {
        if(this.isThesisComplete)
        {
            Console.WriteLine($"{this.name} has completed their thesis, see {this.thesisAdvisor} for final comments");
        } else {
            Console.WriteLine($"{this.name} has NOT completed their thesis it still needs some work!");
        }
    }
}