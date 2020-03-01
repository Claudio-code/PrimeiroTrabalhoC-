using System;

namespace exercicio5
{
    public class VerificarIdade
    {
        public string verificar(string idadeString) 
        {
            int idade = Int32.Parse(idadeString);

            if (idade > 0 && idade <= 19)
            {
                return "Jovem";
            }
             else if (idade > 19 && idade <= 59)
            {
                return "adulto";
            }
             else if (idade > 59)
            {
                return "Idoso";
            } else {
                return "Input errado";
            }

            
        }
    }
}