using System;

namespace Exercicios
{
    internal class ExerciseEight
    {
        internal static void Eight(object p)
        {
            Console.WriteLine("\nExercício 8.");
            Console.WriteLine("Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.\n");

            Console.WriteLine("Informe o valor de 'X'");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de 'Y'");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x % y == 0)
            {
                Console.WriteLine("'X' é multiplo de 'Y'");
            }
            else
            {
                Console.WriteLine("'X' não é multiplo de 'Y'");
            }

            Console.ReadLine();
        }
        
    }
}