using System;

namespace Exercicios
{
    class ExerciseTwo
    {
        public static void Two(string[] args)
        {

            Console.WriteLine("\nExercício 2");
            Console.WriteLine("Imprimir a soma dos números inteiros de 1 a 150");
            int soma = 0;
            for(int x = 0; x < 151; x++)
            {
                soma += x;
            }


            Console.WriteLine($"A soma dos números inteiros de 1 a 150 é de: {soma}");
            Console.WriteLine("******************* \nFim do exercício 2\n");
            Console.ReadLine();

        }
    }
}
