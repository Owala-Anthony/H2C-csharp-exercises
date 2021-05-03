using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    { 
     while (true)
                Console.Write("Do you want to continue?\n>");
                String answer = Console.ReadLine();
                if(answer == "no")
                {  
                 Break;
                }
                Console.ReadKey();
    }
  } 
}
