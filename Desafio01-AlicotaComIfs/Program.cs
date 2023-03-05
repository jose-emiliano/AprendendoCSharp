using System;

// O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. Ele descobriu no site da receita o seguinte:

// De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
// De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
// De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        double ir = 0;
        double maxValue = 0;
        double alicota = 0;
        double salarioDescocntado = 0;

        if (salario >= 1900 && salario <= 2800)
        {
          ir = 0.075;
          maxValue = 142;
          
          if (salario * ir > maxValue)
          {
            alicota = maxValue;
          }
          else
          {
            alicota = salario * ir;
          }
        }
        else if (salario <= 3751)
        {
          ir = 0.15;
          maxValue = 350;
          
          if (salario * ir > maxValue)
          {
            alicota = maxValue;
          }
          else
          {
            alicota = salario * ir;
          }
        }
        else if (salario <= 4664)
        {
          ir = 0.225;
          maxValue = 636;
          
          if (salario * ir > maxValue)
          {
            alicota = maxValue;
          }
          else
          {
            alicota = salario * ir;
          }
        }

        if (salario >= 1900 && salario <= 4664)
        {
          salarioDescocntado = salario - alicota;

          Console.WriteLine("Sua alicota é de " + alicota + ", e o seu salário descontato é de: R$" + salarioDescocntado + ".");
        }
        else
        {
          Console.WriteLine("O programa não está apto para receber valores maiores que R$4664,00 e menores que R$1900,00.");
        }
    }
}