using System;
using System.Collections.Generic;
class ListsAndLoops
{
    public void SetUp()
    {
        Console.WriteLine("Lists and Loops"); // method message
    }
    public void ListCreation()
    {
        // define a list of strings : Autumn Kevin Erin Meka
        List<string> codeCrewStaff = new List<string>(){"Autumn", "Kevin", "Erin", "Meka"};

        Console.Write($"Enter a number between 0 and 3 : "); // prompt for input
        int userIndexPosition = Int16.Parse(Console.ReadLine()); // casting and saving input
        // formatted message based on user input - index position of element
        Console.WriteLine($"{codeCrewStaff[userIndexPosition]} is at position {userIndexPosition}");

        //  printing each element by index position
        Console.WriteLine($"CodeCrew Staff : {codeCrewStaff[0]}, {codeCrewStaff[1]}, {codeCrewStaff[2]}, {codeCrewStaff[3]} ");

        UsingForLoops(codeCrewStaff); // call private methods - output all elements
        UsingForEach(codeCrewStaff); // call private methods - output all elements
    }

    private void UsingForLoops(List<string> strList)
    {
        Console.WriteLine("Using For Loops!"); // method message
        // iterate through list and print each element
        for(int i = 0; i < strList.Count; i++)
        {
            Console.WriteLine($"Staff Member : {strList[i]}");
        }
    }

    private void UsingForEach(List<string> strList)
    {
        Console.WriteLine("Using For Each!"); // method message
        // iterate through list and print each element
        strList.ForEach(strItem => Console.WriteLine($"Staff Member : {strItem}"));
    }

    public void UsingWhileLoops()
    {
        string userInput = ""; // set initial value for loop
        // while userInput is not equal to q continue to prompt the user to enter q
        while(userInput != "q")
        {
            Console.Write("Enter anything or enter q to quit! : "); // prompt
            userInput = Console.ReadLine(); // update value of userInput to what the user enters
        }
    }

    public void CombiningLoops()
    {
        Console.WriteLine("Combining Loops"); // method message

        List<string> groceryList = new List<string>(); // define empty string

        string groceryItem = ""; // set initial value for while loop
        // while user input is not "done" continue to prompt the user to enter something
        while(groceryItem != "done")
        {
            Console.Write("Enter a grocery item or enter done to quit : "); // prompt
            groceryItem = Console.ReadLine(); // update value to what user entered
            groceryList.Add(groceryItem); // add item to list
        }

        groceryList.Remove("done"); // remove extra item

        Console.WriteLine($"You grocery list is {groceryList.Count} items long"); // output length of list

        // iterate through list  
        for(int i = 0; i < groceryList.Count; i++)
        {
            Console.WriteLine($"List Item : {groceryList[i]}");
        }

        // iterate through list
        groceryList.ForEach(groceryItem => Console.WriteLine($"List Item : {groceryItem}"));
    }

}