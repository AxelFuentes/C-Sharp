using System;

public class ascii_evaluacion
{
  public static void Main(string[] args)
  {
    char caracter;
    Console.Write("Escriba el caracter: ");
    caracter = Char.Parse(Console.ReadLine());

    Console.WriteLine("El valor ASCII de '" + caracter + "' : " + (int)caracter);

    Console.ReadLine();
  }
}
