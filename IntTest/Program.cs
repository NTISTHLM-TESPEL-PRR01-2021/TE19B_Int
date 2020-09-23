using System;

namespace IntTest
{
  class Program
  {
    static void Main(string[] args)
    {

      int hp;
      int damage;

      hp = 100;
      hp = 200;
      damage = 23;

      hp = hp - damage;
      hp -= damage;

      Console.WriteLine(hp);


      int points = 0;

      points += 1;

      points++;

      Console.WriteLine("Du har fått " + points + " poäng");

      if (points <= 4)
      {
        Console.WriteLine("HAI!");
      }


      Console.ReadLine();
    }
  }
}
