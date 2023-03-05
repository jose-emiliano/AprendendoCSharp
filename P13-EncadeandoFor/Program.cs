using System;

class Program
{
  static void Main(string[] args)
  {
    // Sem break
    for (int contadorLinhas = 0; contadorLinhas <= 10; contadorLinhas++)
    {
      for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }

    // Com break
    for (int contadorLinhas = 0; contadorLinhas <= 10; contadorLinhas++)
    {
      for (int contadorColunas = 0; contadorColunas <= 10; contadorColunas++)
      {
        Console.Write("*");
        if (contadorColunas >= contadorLinhas) break;
      }
      Console.WriteLine();
    }

  }
}