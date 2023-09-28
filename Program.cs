//Tell the user what Amnestics are available directly into the Console using Console.Line 
//Reason I use Console.Line and only one Console.Write, Is because Console.WriteLine makes new lines
//While Console.Write does not make a new line and allows the number inputed to stick to the right as shown in the example challenge
Console.WriteLine("The following items are available: ");
Console.WriteLine("1 - Class-A Amnestics");
Console.WriteLine("2 - Class-B Amnestics");
Console.WriteLine("3 - Class-C Amnestics");
Console.WriteLine("4 - Class-D Amnestics");
Console.WriteLine("5 - Class-E Amnestics");
Console.WriteLine("6 - Class-F Amnestics");
Console.WriteLine("7 - Class-G Amnestics");
Console.Write("What number do you want to see the price of? ");
int foundationTokensInput = Convert.ToInt32(Console.ReadLine());
//Our switch statement, (I like switch statements cause I can read them better lol)
//Accessing my case word when using the switch statement
switch (foundationTokensInput)
{
    //creating the checks for each input possible listed in the menu I created
    //case 1-7 basically waiting for input of said listed numbers to be possibly ran if
    //the check goes through
    case 1:
        Console.WriteLine("Class-A Amnestics cost 10 foundation tokens");
        break;
    case 2:
        Console.WriteLine("Class-B Amnestics cost 16 foundation tokens");
        break;
    case 3:
        Console.WriteLine("Class-C Amnestics cost 24 foundation tokens");
        break;
    case 4:
        Console.WriteLine("Class-D Amnestics cost 2 foundation tokens");
        break;
    case 5:
        Console.WriteLine("Class-E Amnestics cost 20 foundation tokens");
        break;
    case 6:
        Console.WriteLine("Class-F Amnestics cost 200 foundation tokens");
        break;
    case 7:
        Console.WriteLine("Class-G Amnestics cost 2 foundation tokens");
        break;
}
