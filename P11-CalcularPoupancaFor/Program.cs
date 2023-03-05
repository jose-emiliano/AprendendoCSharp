using System;

class Program
{
  static void Main(string[] args)
  {
    double investimento = 1000;
    double juros = 1 + (0.5/100);

    for(int mes = 1; mes <= 12; mes++)
    {
      investimento *= juros;
      Console.WriteLine("No mes " + mes + " você tem R$" + investimento + ".");
    }
  }
}