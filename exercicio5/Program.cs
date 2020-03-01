using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade \n");

            var idade = Console.ReadLine();
            var verificar = new VerificarIdade();
            Console.WriteLine(verificar.verificar(idade));
        }
    }
}
