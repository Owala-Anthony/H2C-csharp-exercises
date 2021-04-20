using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      int first =3;
      int second = 2;
    bool isFirstLargerThanSecond = first > second;

    if (isFirstLargerThanSecond)
    { 
    Console.WriteLine("The larger number is 3!");
    }

    int third = 4;
    bool isThirdLargerThanFirst = third > first;

    if (isThirdLargerThanFirst)
    {
                Console.WriteLine("The larger number is 4!");
    }

    int fouth = 3;
    bool isfouthEqualToFirst = fouth == first;
    if (isfouthEqualToFirst)
    { 
                Console.WriteLine("They are equal");
    }

    }
  }
}
