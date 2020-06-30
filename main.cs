using System;

class MainClass {
  public static void Main (string[] args) {

  int counter = 0;
  double total = 0;

while(counter <= 6)
{
  Console.WriteLine("Enter the distance traveled (in miles)");
  double distance = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("The distance traveled was " + distance + " miles.");
  
  Console.WriteLine("Enter the time taken");
  double time = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("The time taken was " + time + " hours.");

  double speed = distance / time;
  Console.WriteLine("This vehicle traveled at " + speed + " miles per hour.");
  total = total + speed;
Console.WriteLine(" "); //Putting a gap between each entry.
  counter++;
}

double average = total / counter;
Console.WriteLine("The average speed for all vehicles is " + average + " miles per hour.");

  }
}