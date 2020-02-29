using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tratarString = new TratarString();
            Console.WriteLine("Digite uma palavra");
         
            var palavra = Console.ReadLine();
         
            Console.WriteLine(tratarString.contarVogais(palavra));
        }
    }
}
