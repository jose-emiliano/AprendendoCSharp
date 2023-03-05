using System;

class Program
{
  static void Main()
  {
    int idadeJoao = 16;
    int quantidadeDePessoas = 2;

    if (idadeJoao >= 18)
    {
      Console.WriteLine("Pode entrar");
    }
    else
    {
      if (quantidadeDePessoas > 1)
      {
        Console.WriteLine("Está acompanhado, pode entrar");
      }
      else
      {
        Console.WriteLine("Não pode entrar!");
      }
    }
  }
}