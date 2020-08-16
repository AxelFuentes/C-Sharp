using System;

class MainClass
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Ingresa primero numero:");
    int num1=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa segundo numero:");
    int num2=int.Parse(Console.ReadLine());

    int sum=num1+num2;

    Console.WriteLine("num1: "+num1);
    Console.WriteLine("num2: "+num2);
    Console.WriteLine(+num1+" + "+num2+" = "+sum);
    Console.ReadLine();
  }
}
