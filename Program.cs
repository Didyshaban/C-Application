


using System;

namespace TheLargestNumber
  { 
  class TheLargestNumber
  {
    public static void Main(string[] args){
        int num1,num2,num3,largest;

        Console.WriteLine("Enter the first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        largest = num1;

        else if (num2 > num1 && num2 > num3)
        largest = num2;
        else
        largest = num3;

        Console.WriteLine(" The largest number among {0},{1} and {2}  is {3} ",num1,num2,num3,largest);

        Console.WriteLine("Press Any Key to Exit");
        Console.ReadKey();

    }

  }
}