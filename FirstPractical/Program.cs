//Task1();
//Task2();
//Task3();
//Task4();
Task5();

void Task1()
{
    // Collects the users name and the age they will be in 5
    // years. Then prints it.
    Console.WriteLine("Please enter your name.");
    string userName = Console.ReadLine();

    Console.WriteLine("Please enter your age.");
    int userAgeIn5Years = Convert.ToInt32(Console.ReadLine()) + 5;

    Console.WriteLine($"Hello {userName}, you will be {userAgeIn5Years} in 5 years.");
}

void Task2()
{
    // Collects the users age, determines whether they are a child, teenager
    // or adult, then prints it to the console.
    Console.WriteLine("Please enter your age to determine whether you are a child, teenager or adult.");
    int userAge = Convert.ToInt32(Console.ReadLine());

    if (userAge > 110)
    {
        Console.WriteLine($"The user's age of {userAge} is not valid due to being over the maximum age limit of 110.");
    }
    else if (userAge < 0)
    {
        Console.WriteLine($"The user's age of {userAge} is not valid due to being under the minimum age limit of 0.");
    }
    else if (userAge > 19)
    {
        Console.WriteLine($"With an age of {userAge}, this user is an adult.");
    }
    else if (userAge >= 13)
    {
        Console.WriteLine($"With an age of {userAge}, this user is a teenager.");
    }
    else
    {
        Console.WriteLine($"With an age of {userAge}, this user is a child.");
    }
}

void Task3()
{
    // Collects a number from the user, determines if it is positive,
    // negative or 0 and then prints the result to the console.
    Console.WriteLine("Please enter a number that you wish to determine whether it is positive, negative or zero.");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber > 0)
    {
        Console.WriteLine($"The user's number of {userNumber} is positive.");
    }
    else if (userNumber < 0)
    {
        Console.WriteLine($"The user's number of {userNumber} is negative.");
    }
    else
    {
        Console.WriteLine($"The user's number of {userNumber} is zero.");
    }
}

void Task4()
{
    // Collects a year from the user, determines if it is a
    // leap year, and then prints the result to the console.
    Console.WriteLine("Please enter a year that you wish to know whether it is a leap year or not.");
    int userYear = Convert.ToInt32(Console.ReadLine());

    if ((userYear % 4 == 0 && userYear % 100 != 0) || userYear % 400 == 0)
    {
        Console.WriteLine($"The user's year of {userYear} is a leap year.");
    }
    else 
    {
        Console.WriteLine($"The user's year of {userYear} is not a leap year.");
    }
}

void Task5()
{
    // Collects a number from the user, determines if it is odd
    // or even, and then prints the result to the console.
    Console.WriteLine("Please enter a number that you wish to find out whether it is even or odd.");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 0)
    {
        Console.WriteLine($"The user's number of {userNumber} is an even number.");
    }
    else
    {
        Console.WriteLine($"The user's number of {userNumber} is not an even number.");
    }
}