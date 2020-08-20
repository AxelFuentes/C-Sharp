using System;

class Temperatura_Conversion
{
  public static void Main (string[] args) 
  {
    float Cel,Far;
    Console.WriteLine ("Dame mis celsius: ");
    Cel=float.Parse(Console.ReadLine());

    Far=(Cel*9)/5+32;

    Console.WriteLine(+Cel+"°C = "+Far+"°F");

    Console.ReadLine();
  }
}
