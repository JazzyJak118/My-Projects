// Dividing and conversion
using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Hello Welcome to the Dividing and Conversion Calculator");
//Enter first number
    Console.WriteLine("Please enter the first number: ");
// Have first number read input
    string input1 = Console.ReadLine();

// Enter second number    
    Console.WriteLine("Please enter the second number: ");

    //Have second read input
    string input2 = Console.ReadLine();
    
    try
  {  
  // convert first string input to int
  int number1 = Convert.ToInt32(input1);

  // convert second string input to int

  int number2 = Convert.ToInt32(input2);

  // Divide first number by second number to get result

  int result = number1 / number2;
  Console.WriteLine($"The result is: " + result);
  
    
  }
// catch for errors
    catch (FormatException ex)
   {
    Console.WriteLine("Error: One or more of the inputs is not a number"); 
    Console.WriteLine("Error: " + ex.Message);
     
    }
    // catch for divide by zero error
    catch (DivideByZeroException ex)
    
    {
      Console.WriteLine("Error: Division by zero is not allowed");
      Console.WriteLine("Error: " + ex.Message);
      
    }
    // catch for any other error
    catch (Exception ex)
    {


      Console.WriteLine("Error: An unknown error occured");
      Console.WriteLine("Error: " + ex.Message);
    }
    // Finish return
    Console.WriteLine("Thank you for using the Dividing and Conversion Calculator");
    
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    }
  static int Divide(int input1, int input2)
  {

    return input1 / input2;
  }
  
  }
