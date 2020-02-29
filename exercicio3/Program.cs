using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var processandoString = new ProcessadoString();            
            
            Console.WriteLine(processandoString.retirarVogais("casa"));
        }
    }
}
