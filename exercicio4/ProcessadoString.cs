using System;

namespace exercicio4
{
    public class ProcessadoString
    {
        public string retirarVogais(string palavra) 
        {
            string[] vogais = {
                "a", "e", "i", "o", "u"
            };
            
            for (int i = 0; i < vogais.Length; i++)
            {
                var voagal = vogais[i];
                palavra = palavra.ToLower();
                palavra = palavra.Replace(voagal, "");
            }

            return palavra;
        }
    }
}