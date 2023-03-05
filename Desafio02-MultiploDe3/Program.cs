using System;

class Program
{
  static void Main(string[] args)
  {

    for (int numero = 1; numero <= 100; numero++)
    {
      if(numero % 3 == 0)
      {
        Console.WriteLine(numero);
      }
    }
  }
}