using System;

class Program
{
  static void Main(string[] args)
  {
    int idadeJoao = 16;
    int quantidadeDePessoas = 1;
    bool acompanhado = quantidadeDePessoas > 1;
    bool maiorDeIdade = idadeJoao > 18;
    bool podeEntrar = maiorDeIdade || acompanhado;

    if (podeEntrar)
    {
      Console.WriteLine("Pode entrar!");
    }
    else
    {
      Console.WriteLine("Não pode entrar!");
    }
  }
}