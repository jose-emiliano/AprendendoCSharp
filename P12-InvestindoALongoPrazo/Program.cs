using System;

class Program
{
  static void Main(string[] args)
  {
    double fatorDeRendimento = 1.005;
    double investimento = 1000;

    for (int anos = 1; anos <= 5; anos++)
    {
      for (int mes = 1; mes <= 12; mes++)
      {
        investimento *= fatorDeRendimento;
      }

      fatorDeRendimento += 0.001;
    }
  
    Console.WriteLine("Depois de 5 anos você terá R$" + investimento + ".");
  }

}