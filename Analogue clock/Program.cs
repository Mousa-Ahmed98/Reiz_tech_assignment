while(true)
{
    int hours, minutes;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter hours (1-12): ");
    bool success = int.TryParse(Console.ReadLine(), out hours);

    Console.Write("Enter minutes (0-59): ");
    bool success2 = int.TryParse(Console.ReadLine(), out minutes);
    
    //Validating inputs
    if (success && success2 && hours >= 1 && hours <= 12 && minutes >= 0 && minutes <= 59)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(GetLesserAngle(hours, minutes));
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Hours should be numeric values from 1 to 12, and minutes should be numeric values from 0 to 59.");
    }

}


double GetLesserAngle(int hours, int minutes)
{
    //Get the position of hour's hand
    int posOfHours = (hours % 12) * 5;
    //Getting difference between hours and minutes ang calculate the angle
    double angle = Math.Abs(minutes - posOfHours) /5.0 * 30.0;

    //Hour's hand will have extra angle if {minutes} is greater than 0
    //Add this extra angle if hour's hand is after minute's hand, otherwise subtract it from
    //the final result;
    angle = posOfHours >= minutes? angle + (minutes / 60.0) * 30 
        : angle - (minutes / 60.0) * 30;
        
    //Get the absolute value;
    angle = Math.Abs(angle);
    return Math.Min(angle, 360 - angle);
}