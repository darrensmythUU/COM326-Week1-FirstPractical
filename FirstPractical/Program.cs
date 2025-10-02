//Task1();
Task2();
//Task3();
//Task4();
//Task5();

void Task1()
{
    // Collects the users name and the age they will be in 5 years. Then prints it
    Console.WriteLine("Please enter your name.");
    string userName = Console.ReadLine();

    Console.WriteLine("Please enter your age.");
    int userAgeIn5Years = Convert.ToInt32(Console.ReadLine()) + 5;

    Console.WriteLine($"Hello {userName}, you will be {userAgeIn5Years} in 5 years.");
}

void Task2()
{
    // Collects the users age, determines whether they are a child, teenager or adult, then prints it to the console.
    Console.WriteLine("Please enter your age.");
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

}

void Task4()
{

}

void Task5()
{

}