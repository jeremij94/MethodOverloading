﻿//Exercise 1:
//Create a new Console app in Visual Studio Community.
//Create a method named Add, that accepts two integers and returns the sum of those two integers
//Now create an overload of the Add method to account for being able to add two decimals together
//Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

using MethodOverloading;
// type "true" as a third parameter in the Add method for an integer in dollars.
    var answer = MethodOverloadAdd.Add(23,64, true);
Console.WriteLine(answer);
Console.ReadLine();




