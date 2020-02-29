using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var processandoString = new ProcessadoString();            
            
            Console.WriteLine("digite uma palavra para retirar as consolantes \n");
            
            var palavra = Console.ReadLine();

            Console.WriteLine(processandoString.retirarVogais(palavra));
        }
    }
}
