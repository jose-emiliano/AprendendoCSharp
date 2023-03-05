using System;

class Program
{
  static void Main (string[] args)
  {
    int fator = 1;
    
    for (int i = 1; i <= 10; i ++)
    {
      fator *= i;
      Console.WriteLine("O fator de " + i + " é " + fator + ".");
    }
  }
}