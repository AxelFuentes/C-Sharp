using System;

public class Cambiar_dos_Valores 
{
  public static void Main (string[] args) 
  {
    int num1,num2,temp;
    Console.WriteLine("\nIngrese el primer numero: ");
    num1=int.Parse(Console.ReadLine());
    Console.WriteLine("\nIngrese el segundo numero: ");
    num2=int.Parse(Console.ReadLine());

    temp=num1;
    num1=num2;
    num2=temp;

    Console.Write("\nDespues del Cambio: ");
    Console.Write("\nPrimer numero: "+num1);
    Console.Write("\nSegundo numero: "+num2);

    Console.ReadLine();
  }
}
