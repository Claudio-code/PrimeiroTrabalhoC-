using System;

namespace exercicio1
{
  class Program
  {

    static void Main(string[] args)
    {
      var calculadora = new Calculadora();
      
      Console.WriteLine("\n Calculadora \n");
      Console.WriteLine("Qual operacao vc deseja? \n\n");
      Console.WriteLine("soma = 1 \ndivisao = 2 \nsubtracao = 3 \nmultiplicacao = 4\n");
      var input = Console.ReadLine();
      // Console.WriteLine(input.Equals("2"));
      if (input.Equals("1")) {

        Console.WriteLine("\n digite o primeiro valor \n");
        

        var valor1 = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("\n digite o segundo valor \n");


        var valor2 = Convert.ToDecimal(Console.ReadLine());
        

        var resposta = calculadora.soma(valor1, valor2);
        Console.WriteLine(resposta);
        
      } else if (input.Equals("2")) {

        Console.WriteLine("\n digite o primeiro valor \n");
        

        var valor1 = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("\n digite o segundo valor \n");


        var valor2 = Convert.ToDecimal(Console.ReadLine());
        

        var resposta = calculadora.divisao(valor1, valor2);
        Console.WriteLine(resposta);

      } else if (input.Equals("3")) {
        
        Console.WriteLine("\n digite o primeiro valor \n");
        

        var valor1 = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("\n digite o segundo valor \n");


        var valor2 = Convert.ToDecimal(Console.ReadLine());
        

        var resposta = calculadora.subtracao(valor1, valor2);
        Console.WriteLine(resposta);
      } else if (input.Equals("4")) {

        Console.WriteLine("\n digite o primeiro valor \n");
        

        var valor1 = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("\n digite o segundo valor \n");


        var valor2 = Convert.ToDecimal(Console.ReadLine());
        

        var resposta = calculadora.multiplicacao(valor1, valor2);
        Console.WriteLine(resposta);
      } else {
       Console.WriteLine("\n opcao n existe \n"); 
      }
    }

    

  }
}
