using System;

class MainClass {
  public static void Main (string[] args) {
    // FORK this starter file and save it to your own Repl.it account.
    
    // Declare and assign the variables here:
    string shuttleName = "Determination";
    int shuttleSpeedMph = 17500;
    int distanceToMarsKm = 225000000;
    int distanceToMoonKm = 384400;
    double milesPerKm = 0.621;
    
    // Code your solution to exercises B and C here:
    // Exercise B
    double milesToMars = distanceToMarsKm * milesPerKm;
    double milesToMoon = distanceToMoonKm * milesPerKm;
    double hoursToMars = milesToMars / shuttleSpeedMph;
    double hoursToMoon = milesToMoon / shuttleSpeedMph;
    double daysToMars = hoursToMars / 24;
    double daysToMoon = hoursToMoon / 24;

    // Exercise C
    Console.WriteLine(shuttleName + " will take " + daysToMars + " days to reach Mars.");






    // Code your solution to exercise D here:
    Console.WriteLine(shuttleName + " will take " + daysToMoon + " days to reach the Moon.");



    
  }
}