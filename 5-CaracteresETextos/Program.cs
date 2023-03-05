using System;

class Program
{
  static void Main()
  {
    char inicial = 'a';
    Console.WriteLine(inicial);

    inicial = (char)77;
    Console.WriteLine(inicial);

    inicial = (char)(70 + 10);
    Console.WriteLine(inicial);

    string primeiraFrase = "José - Soluções Tecnológicas";
    Console.WriteLine(primeiraFrase);

    string listaDeCursos = @"Cursos disponíveis:
- Go
- C#
- Python
- Java";
    Console.WriteLine(listaDeCursos);

  }
}