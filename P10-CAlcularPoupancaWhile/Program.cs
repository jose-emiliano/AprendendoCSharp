using System;

class Program
{
  static void Main(string[] args)
  {
    double investimento = 1000;
    double juros = 1 + (0.5/100);
    int mes = 1;

    while (mes <= 12)
    {
      investimento *= juros;
      Console.WriteLine("No mes " + mes + " você tem R$" + investimento + ".");
      
      mes++;
    }
  }
}