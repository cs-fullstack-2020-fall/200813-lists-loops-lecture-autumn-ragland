# 20 08 13 Lists and Loops Lecture

### Set Up
- Create a new .NET console application by running `dotnet new console -o Lecture`
- Change the default output in the Program Main method to `20 08 13 Lecture`
- Create a new class called `ListsAndLoops`
    - define a public method that outputs `Lists and Loops` to the console
    - create an instance of this class in the Main method
    - call the method defined above on the instance of the ListAndLoops class
### Code Together
#### List Review
- Define a public method in the `ListsAndLoops` class called `ListCreation()`
- In the ListCreation method define a list called codeCrewStaff with the names : Autumn, Kevin, Erin and Meka
- In the ListCreation method prompt to enter a number between 0 and 3 in the console and print the corresponding element
- In the ListCreation method print all names in the codeCrewStaff list 
#### For Loops
- Define a private method in the `ListsAndLoops` class called `UsingForLoops()` that accepts a list of strings
- In the UsingForLoops method loop through the passed in array using a for loop
- On each iteration through the for loop display the message `Staff Member LIST_ELEMENT`
- Call the UsingForLoops method in the ListCreation method passing in the codeCrewStaff list
#### For Each
- Define a private method in the `ListAndLoops` class called `UsingForEach()` that accepts a list of strings
- Refactor the logic of the UsingForLoops method to use for each and produce the same output
- Call the UsingForEach method in the ListCreation method passing in the codeCrewStaff list
#### While Loops
- Define a public method in the `ListsAndLoops` class called `UsingWhileLoops()`
- In the UsingWhileLoops method prompt the user to enter anything or enter q to quit
- Continue to prompt the user until they enter q 
#### Combining Loops
- Define a public method in the `ListsAndLoops` class called `CombiningLoops()`
- In the CombiningLoops method create an empty array of strings called `groceryList`, prompt the user to add a grocery item until they enter 'done' and add each item to the groceryList List
- Output the length of their grocery list
- Output the items in the groceryList using a for loops
- Output the items in the groceryList using a forEach
#### Incorporating Classes
- Create a new class called `Student` with properties name(string), hours(integer), and courses(list of strings)
- Define the name and number of hours in the constructor
- Define a method to display the student's name, number of hours, and number of course in the console
- Define a method to allow the user to add multiple courses to a student's list of courses until they input 'done' then display the number of courses total and all courses added
- Define a new class called `GraduateStudent` that extends the `Student` class. 
- Add properties isThesisComplete(boolean) and thesisAdvisor(string)
- Set the new properties in the constructor and inherit all properties from the base class `Student`
- Define method to check if a graduate student's thesis is complete and display an appropriate message 
- Create an Student object and a GraduateStudent object. Call appropriate methods on both