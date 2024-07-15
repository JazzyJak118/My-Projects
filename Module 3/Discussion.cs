/* Working with class examples and local methods
octopus, person,
*/

// octopus
using System;

public class Octopus
{  
  {
  public readonly string Name;
  public int Age = 10;
  static readonly int legs = 8;
  }

 public Octopus(string name)
    {
        Name = name;
    }
  void DisplayInfo()
 {
   Console.WriteLine($"Name: {Name}, Age: {Age}, Legs: {Legs}");
  }
  
}
