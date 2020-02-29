using System;

namespace exercicio3
{
    public class ProcessadoString
    {
        public string retirarVogais(string palavra) 
        {
            string[] consolantes = {
                "b", "c", "d", "f", "g", "h", "j", "k", "l",
                "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"
            };
            
            for (int i = 0; i < consolantes.Length; i++)
            {
                var consolante = consolantes[i];
                palavra = palavra.Replace(consolante, "");
            }

            return palavra;
        }
    }
}