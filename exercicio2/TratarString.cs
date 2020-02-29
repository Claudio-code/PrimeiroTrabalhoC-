using System;
using System.Linq;
using System.Configuration; 
using System.Collections.Generic;

namespace exercicio2
{
    public class TratarString
    {
        public int contarVogais(string texto) 
        {
            int i, cv;
            char[] vogais = { 'a','e','i','o','u' }; 
            int total = 0;

            for (i = 0; i <= texto.Length - 1; i++) 
            {
                for (cv = 0; cv <= 4; cv++)
                {
                    if (Convert.ToChar(texto.Substring(i, 1)) == vogais[cv])
                    {
                        total++;
                    }

                }
            }
            
            return total;
        }
    }
}